using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyBanHang.Model;
using QuanLyBanHang.DataAccessLayer;

namespace QuanLyBanHang.DataAccessLayer
{
    class Dao
    {
        //nhan vien
        public static DataTable GetListNhanVien()
        {
            return DataProvider.GetData("select * from NHANVIEN");
        }

        public static int Insert(NhanVien1 nv)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manv", nv.manv),
                new SqlParameter("@ten", nv.tennv),
                new SqlParameter("@gt", nv.gioitinh),
                new SqlParameter("@ns", nv.ngaysinh),
                new SqlParameter("@diachi", nv.diachi),
                new SqlParameter("@luong", nv.luong)
            };
            return DataProvider.ExecuteNonQuery("them_nv", para);
        }

        public static int Update(NhanVien1 nv)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manv", nv.manv),
                new SqlParameter("@ten", nv.tennv),
                new SqlParameter("@gt", nv.gioitinh),
                new SqlParameter("@ns", nv.ngaysinh),
                new SqlParameter("@diachi", nv.diachi),
                new SqlParameter("@luong", nv.luong)
            };
            return DataProvider.ExecuteNonQuery("sua_nv", para);
        }

        public static int Delete(NhanVien1 nv)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manv", nv.manv)
            };
            return DataProvider.ExecuteNonQuery("xoa_nv", para);
        }

        public static DataTable Search(string ten)
        {
            return DataProvider.GetData("select * from NHANVIEN " + ten);
        }

        // khach hang
        public static DataTable GetListKhachHang()
        {
            return DataProvider.GetData("select * from KHACHHANG");
        }

        public static int InsertKH(KhachHang kh)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@makh", kh.makh),
                new SqlParameter("@tenkh", kh.tenkh),
                new SqlParameter("@ngaysinh", kh.ngaysinh),
                new SqlParameter("@diachi", kh.diachi),
                new SqlParameter("@sdt", kh.sdt),
                new SqlParameter("@diemtl", kh.diemtl)
            };
            return DataProvider.ExecuteNonQuery("them_kh", para);
        }

        public static int UpdateKH(KhachHang kh)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@makh", kh.makh),
                new SqlParameter("@tenkh", kh.tenkh),
                new SqlParameter("@ngaysinh", kh.ngaysinh),
                new SqlParameter("@diachi", kh.diachi),
                new SqlParameter("@sdt", kh.sdt),
                new SqlParameter("@diemtl", kh.diemtl)
            };
            return DataProvider.ExecuteNonQuery("sua_kh", para);
        }

        public static int DeleteKH(KhachHang kh)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@makh", kh.makh)
            };
            return DataProvider.ExecuteNonQuery("xoa_kh", para);
        }

        public static DataTable SearchKh(string ten)
        {
            return DataProvider.GetData("select * from KHACHHANG " + ten);
        }
    }
}
