using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.BusinessLogiclayer;
using QuanLyBanHang.Model;

namespace QuanLyBanHang
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanvien.DataSource = Bus.GetListNhanVien();
            //chinh sua gia diện
            dgvNhanvien.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dgvNhanvien.Columns["TenNV"].HeaderText = "Tên nhân viên";
            dgvNhanvien.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvNhanvien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvNhanvien.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvNhanvien.Columns["Luong"].HeaderText = "Lương";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtManv.Text = string.Empty;
            txtTennv.Text = string.Empty;
            txtGioitinh.Text = string.Empty;
            txtDiachi.Text = string.Empty;
            txtLuong.Text = string.Empty;
            dateNgaysinh.Value = DateTime.Now;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtManv.Text==" "|| txtTennv.Text==" ")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            NhanVien1 nv = new NhanVien1();
            nv.manv = txtManv.Text;
            nv.tennv = txtTennv.Text;
            nv.ngaysinh = dateNgaysinh.Value;
            nv.gioitinh = txtGioitinh.Text;
            nv.luong = float.Parse(txtLuong.Text);
            nv.diachi = txtDiachi.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn thêm nhân viên {0} tên nhân viên {1}", nv.manv, nv.tennv),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if(Bus.Insert(nv)>0)
                {
                    MessageBox.Show("Thêm thành công!");
                    NhanVien_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi!");
            }
        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtManv.Text = dgvNhanvien.CurrentRow.Cells["MaNV"].Value.ToString();
            txtTennv.Text = dgvNhanvien.CurrentRow.Cells["TenNV"].Value.ToString();
            txtDiachi.Text = dgvNhanvien.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtGioitinh.Text = dgvNhanvien.CurrentRow.Cells["GioiTinh"].Value.ToString();
            dateNgaysinh.Text = dgvNhanvien.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txtLuong.Text = dgvNhanvien.CurrentRow.Cells["Luong"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtManv.Text == " " || txtTennv.Text == " ")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            NhanVien1 nv = new NhanVien1();
            nv.manv = txtManv.Text;
            nv.tennv = txtTennv.Text;
            nv.ngaysinh = dateNgaysinh.Value;
            nv.gioitinh = txtGioitinh.Text;
            nv.luong = float.Parse(txtLuong.Text);//chuyển từ string sang float
            nv.diachi = txtDiachi.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn sửa nhân viên {0} tên nhân viên {1}", nv.manv, nv.tennv),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.Update(nv) > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    NhanVien_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtManv.Text == " " || txtTennv.Text == " ")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            NhanVien1 nv = new NhanVien1();
            nv.manv = txtManv.Text;
            nv.tennv = txtTennv.Text;
            nv.ngaysinh = dateNgaysinh.Value;
            nv.gioitinh = txtGioitinh.Text;
            nv.luong = float.Parse(txtLuong.Text);//chuyển từ string sang float
            nv.diachi = txtDiachi.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn xóa nhân viên {0} tên nhân viên {1}", nv.manv, nv.tennv),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.Delete(nv) > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    NhanVien_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi!");
            }
        }

        public void Hienthi(string nhanvien)
        {
            dgvNhanvien.DataSource = Bus.Search(nhanvien);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = string.Empty;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Hienthi("where MaNV like N'%" + txtTimKiem.Text + "%'");
        }
    }
}
