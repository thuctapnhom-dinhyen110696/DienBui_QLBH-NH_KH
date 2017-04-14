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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load_1(object sender, EventArgs e)
        {
            dgvKhachhang.DataSource = Bus.GetListKhachHang();
            //
            dgvKhachhang.Columns["MaKH"].HeaderText = "Mã khách hàng";
            dgvKhachhang.Columns["TenKH"].HeaderText = "Tên khách hàng";
            dgvKhachhang.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvKhachhang.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvKhachhang.Columns["SDT"].HeaderText = "Số điện thoại";
            dgvKhachhang.Columns["DiemTL"].HeaderText = "Điểm tích lũy";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtDiachi.Text = string.Empty;
            txtDiemtl.Text = string.Empty;
            txtMakh.Text = string.Empty;
            txtSdt.Text = string.Empty;
            txtTenkh.Text = string.Empty;
            dateNgaysinh.Value = DateTime.Now;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMakh.Text == " " || txtTenkh.Text == " ")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            KhachHang kh = new KhachHang();
            kh.makh = txtMakh.Text;
            kh.tenkh = txtTenkh.Text;
            kh.ngaysinh = dateNgaysinh.Value;
            kh.sdt = txtSdt.Text;
            kh.diemtl = float.Parse(txtDiemtl.Text);
            kh.diachi = txtDiachi.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn thêm khách hàng {0} tên khách hàng {1}", kh.makh, kh.tenkh),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertKH(kh) > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                    frmKhachHang_Load_1(sender, e);
                }
                else
                    MessageBox.Show("Lỗi!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMakh.Text == " " || txtTenkh.Text == " ")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            KhachHang kh = new KhachHang();
            kh.makh = txtMakh.Text;
            kh.tenkh = txtTenkh.Text;
            kh.ngaysinh = dateNgaysinh.Value;
            kh.sdt = txtSdt.Text;
            kh.diemtl = float.Parse(txtDiemtl.Text);
            kh.diachi = txtDiachi.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn sửa khách hàng {0} tên khách hàng {1}", kh.makh, kh.tenkh),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateKH(kh) > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    frmKhachHang_Load_1(sender, e);
                }
                else
                    MessageBox.Show("Lỗi!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMakh.Text == " " || txtTenkh.Text == " ")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            KhachHang kh = new KhachHang();
            kh.makh = txtMakh.Text;
            kh.tenkh = txtTenkh.Text;
            kh.ngaysinh = dateNgaysinh.Value;
            kh.sdt = txtSdt.Text;
            kh.diemtl = float.Parse(txtDiemtl.Text);
            kh.diachi = txtDiachi.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn xóa khách hàng {0} tên khách hàng {1}", kh.makh, kh.tenkh),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteKH(kh) > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    frmKhachHang_Load_1(sender, e);
                }
                else
                    MessageBox.Show("Lỗi!");
            }
        }

        private void dgvKhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMakh.Text = dgvKhachhang.CurrentRow.Cells["MaKH"].Value.ToString();
            txtTenkh.Text = dgvKhachhang.CurrentRow.Cells["TenKH"].Value.ToString();
            txtDiachi.Text = dgvKhachhang.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtSdt.Text = dgvKhachhang.CurrentRow.Cells["SDT"].Value.ToString();
            dateNgaysinh.Text = dgvKhachhang.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txtDiemtl.Text = dgvKhachhang.CurrentRow.Cells["DiemTL"].Value.ToString();
        }

        public void Hienthi(string khachhang)
        {
            dgvKhachhang.DataSource = Bus.SearchKh(khachhang);
        }

        private void txtTimkiem_Click(object sender, EventArgs e)
        {
            txtTimkiem.Text = string.Empty;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Hienthi("where MaKH like N'%" + txtTimkiem.Text + "%'");
        }
    }
}
