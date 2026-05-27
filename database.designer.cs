using System;
using System.ComponentModel;
using System.Linq;
using Microsoft.Data.SqlClient;

namespace CSharp_68PM1_NguyenHoangTung_0027968
{
    public class databaseDataContext : IDisposable
    {
        private readonly string _connectionString;

        public databaseDataContext(string connectionString)
        {
            _connectionString = connectionString;
            lophocs = new BindingList<lophoc>();
            tbl_sinhviens = new BindingList<tbl_sinhvien>();
            InitializeData();
        }

        public BindingList<lophoc> lophocs { get; set; }
        public BindingList<tbl_sinhvien> tbl_sinhviens { get; set; }

        private void InitializeData()
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    using (var cmd1 = new SqlCommand("SELECT MaLop, TenLop, NienKhoa FROM lophoc", conn))
                    using (var reader1 = cmd1.ExecuteReader())
                    {
                        while (reader1.Read())
                        {
                            lophocs.Add(new lophoc
                            {
                                MaLop = reader1["MaLop"].ToString(),
                                TenLop = reader1["TenLop"].ToString(),
                                NienKhoa = reader1["NienKhoa"] == DBNull.Value ? "" : reader1["NienKhoa"].ToString()
                            });
                        }
                    }

                    using (var cmd2 = new SqlCommand(
                        "SELECT MaSV, HoTen, NgaySinh, GioiTinh, QueQuan, SoDienThoai, MaLop FROM tbl_sinhvien", conn))
                    using (var reader2 = cmd2.ExecuteReader())
                    {
                        while (reader2.Read())
                        {
                            tbl_sinhviens.Add(new tbl_sinhvien
                            {
                                MaSV = reader2["MaSV"].ToString(),
                                HoTen = reader2["HoTen"].ToString(),
                                NgaySinh = reader2["NgaySinh"] != DBNull.Value ? Convert.ToDateTime(reader2["NgaySinh"]) : (DateTime?)null,
                                GioiTinh = reader2["GioiTinh"] == DBNull.Value ? "" : reader2["GioiTinh"].ToString(),
                                QueQuan = reader2["QueQuan"] == DBNull.Value ? "" : reader2["QueQuan"].ToString(),
                                SoDienThoai = reader2["SoDienThoai"] == DBNull.Value ? "" : reader2["SoDienThoai"].ToString(),
                                MaLop = reader2["MaLop"] == DBNull.Value ? "" : reader2["MaLop"].ToString()
                            });
                        }
                    }
                }
            }
            catch { }
        }

        public void SaveChanges()
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                var dbLops = new System.Collections.Generic.List<string>();
                using (var cmd = new SqlCommand("SELECT MaLop FROM lophoc", conn))
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) dbLops.Add(r["MaLop"].ToString());

                var memLops = new System.Collections.Generic.HashSet<string>(lophocs.Select(l => l.MaLop ?? ""));

                foreach (var ma in dbLops)
                    if (!memLops.Contains(ma))
                        using (var cmd = new SqlCommand("DELETE FROM lophoc WHERE MaLop=@ma", conn))
                        { cmd.Parameters.AddWithValue("@ma", ma); cmd.ExecuteNonQuery(); }

                foreach (var lop in lophocs)
                {
                    var sql = dbLops.Contains(lop.MaLop ?? "")
                        ? "UPDATE lophoc SET TenLop=@ten, NienKhoa=@nk WHERE MaLop=@ma"
                        : "INSERT INTO lophoc(MaLop,TenLop,NienKhoa) VALUES(@ma,@ten,@nk)";
                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ma", (object)lop.MaLop ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ten", (object)lop.TenLop ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@nk", string.IsNullOrEmpty(lop.NienKhoa) ? (object)DBNull.Value : lop.NienKhoa);
                        cmd.ExecuteNonQuery();
                    }
                }

                var dbSVs = new System.Collections.Generic.List<string>();
                using (var cmd = new SqlCommand("SELECT MaSV FROM tbl_sinhvien", conn))
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) dbSVs.Add(r["MaSV"].ToString());

                var memSVs = new System.Collections.Generic.HashSet<string>(tbl_sinhviens.Select(s => s.MaSV ?? ""));

                foreach (var ma in dbSVs)
                    if (!memSVs.Contains(ma))
                        using (var cmd = new SqlCommand("DELETE FROM tbl_sinhvien WHERE MaSV=@ma", conn))
                        { cmd.Parameters.AddWithValue("@ma", ma); cmd.ExecuteNonQuery(); }

                foreach (var sv in tbl_sinhviens)
                {
                    var sql = dbSVs.Contains(sv.MaSV ?? "")
                        ? "UPDATE tbl_sinhvien SET HoTen=@ht,NgaySinh=@ns,GioiTinh=@gt,QueQuan=@qq,SoDienThoai=@sdt,MaLop=@lop WHERE MaSV=@ma"
                        : "INSERT INTO tbl_sinhvien(MaSV,HoTen,NgaySinh,GioiTinh,QueQuan,SoDienThoai,MaLop) VALUES(@ma,@ht,@ns,@gt,@qq,@sdt,@lop)";
                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ma", (object)sv.MaSV ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ht", (object)sv.HoTen ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ns", sv.NgaySinh.HasValue ? (object)sv.NgaySinh.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@gt", string.IsNullOrEmpty(sv.GioiTinh) ? (object)DBNull.Value : sv.GioiTinh);
                        cmd.Parameters.AddWithValue("@qq", string.IsNullOrEmpty(sv.QueQuan) ? (object)DBNull.Value : sv.QueQuan);
                        cmd.Parameters.AddWithValue("@sdt", string.IsNullOrEmpty(sv.SoDienThoai) ? (object)DBNull.Value : sv.SoDienThoai);
                        cmd.Parameters.AddWithValue("@lop", string.IsNullOrEmpty(sv.MaLop) ? (object)DBNull.Value : sv.MaLop);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public void Dispose() { }
    }

    public class lophoc
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string NienKhoa { get; set; }
    }

    public class tbl_sinhvien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string QueQuan { get; set; }
        public string SoDienThoai { get; set; }
        public string MaLop { get; set; }
    }
}