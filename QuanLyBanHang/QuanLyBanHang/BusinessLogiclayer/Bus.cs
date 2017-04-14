using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyBanHang.DataAccessLayer;
using QuanLyBanHang.Model;

namespace QuanLyBanHang.BusinessLogiclayer
{
    class Bus
    {

        //nhan viên
        public static DataTable GetListNhanVien()
        {
            return Dao.GetListNhanVien();
        }

        public static int Insert(NhanVien1 nv)
        {
            return Dao.Insert(nv);
        }

        public static int Update(NhanVien1 nv)
        {
            return Dao.Update(nv);
        }

        public static int Delete(NhanVien1 nv)
        {
            return Dao.Delete(nv);
        }

        public static DataTable Search(string ten)
        {
            return Dao.Search(ten);
        }

        //khach hang

        public static DataTable GetListKhachHang()
        { return Dao.GetListKhachHang(); }

        public static int InsertKH(KhachHang kh)
        {
            return Dao.InsertKH(kh);
        }

        public static int UpdateKH(KhachHang kh)
        {
            return Dao.UpdateKH(kh);
        }

        public static int DeleteKH(KhachHang kh)
        {
            return Dao.DeleteKH(kh);
        }

        public static DataTable SearchKh(string ten)
        {
            return Dao.SearchKh(ten);
        }
    }
}
