using quanLyLaoDong.DAO;
using quanLyLaoDong.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyLaoDong
{
    public partial class accountControl : UserControl
    {
        public accountControl()
        {
            InitializeComponent();

            LoadAccount();
            LoadCongTrinh();
            LoadNhanVien();
            LoadPhongBan();
        }


        void LoadAccount()
        {
            DataProvider data = new DataProvider();
            accountDataGridView.DataSource = data.ExcuteQuery("select * from dbo.Account");
        }

        void LoadCongTrinh()
        {
            List<CongTrinh> congTrinhList = CongTrinhDAO.Instance.LoadCongTrinh();

            foreach (var item in congTrinhList)
            {
                congTrinhDataGridView.Rows.Add(item.Id, item.Name, item.DiaDiem, item.NgayKhoiCong, item.NgayCapPhep, item.NgayHoanThanhDuKien, item.MaPhongQL);
            }
        }

        void LoadNhanVien()
        {
            List<NhanVien> nvList = NhanVienDAO.Instance.LoadNhanVien();

            foreach (var item in nvList)
            {
                if (item.GioiTinh == false) nhanVienGridView.Rows.Add(item.Id, item.TenNV, item.NgaySinh,"Nam", item.DiaChi, item.MaPhong);
                else nhanVienGridView.Rows.Add(item.Id, item.TenNV, item.NgaySinh, "Nữ", item.DiaChi, item.MaPhong);
            }
        }

        void LoadPhongBan()
        {
            List<PhongBan> nvList = PhongBanDAO.Instance.LoadPhongBan();

            foreach (var item in nvList)
            {
                phongBanDataGridView.Rows.Add(item.MaPhong, item.TenPhong);
            }
        }

        private void nvXoaBTN_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc muốn xóa không ?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                if (nhanVienGridView.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = nhanVienGridView.SelectedRows[0].Index;
                    DataGridViewRow selectedRow = nhanVienGridView.Rows[selectedRowIndex];
                    int maNhanVien = Convert.ToInt32((selectedRow.Cells["intMaNhanVien"].Value));
                    string q = "delete from dbo.NhanVien where MaNhanVien=" + maNhanVien;
                    DataProvider.Instance.ExcuteQuery(q);
                    nhanVienGridView.Rows.RemoveAt(selectedRowIndex);
                }
                else
                {
                    MessageBox.Show("Hãy chọn hàng muốn xóa!", "Thông báo");
                }
            }
           
        }

        private void addNVBTN_Click(object sender, EventArgs e)
        {
            fNVAdd addNV = new fNVAdd();
            addNV.ShowDialog();
            nhanVienGridView.Rows.Clear();
            LoadNhanVien();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            UpdateDataNV();


        }

        private void nhanVienGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDataNV();
        }

        void UpdateDataNV()
        {
            if (nhanVienGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = nhanVienGridView.SelectedRows[0].Index;
                DataGridViewRow selectedRow = nhanVienGridView.Rows[selectedRowIndex];
                int maNhanVien = Convert.ToInt32((selectedRow.Cells["intMaNhanVien"].Value));
                fNVEdit fNVEditForm = new fNVEdit();

                fNVEditForm.msnvTrasfer = maNhanVien.ToString();
                fNVEditForm.hoTenTrasfer = selectedRow.Cells["txtTenNhanVien"].Value.ToString();
                fNVEditForm.NgaySinhTrasfer = selectedRow.Cells["txtNgaySinhNV"].Value.ToString();
                fNVEditForm.phongQLTransfer = selectedRow.Cells["txtMaPhongQL"].Value.ToString();
                fNVEditForm.GioiTinhTransfer = selectedRow.Cells["bitGioiTinhNV"].Value.ToString();
                fNVEditForm.DiaChiTransfer = selectedRow.Cells["txtDiaChi"].Value.ToString();
                fNVEditForm.ShowDialog();
                nhanVienGridView.Rows.Clear();
                LoadNhanVien();
            }
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            fPhongBanAdd phongBanAddFrom = new fPhongBanAdd();
            phongBanAddFrom.ShowDialog();
            phongBanDataGridView.Rows.Clear();
            LoadPhongBan();
        }

        private void phongBanDeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc muốn xóa không ?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                if (phongBanDataGridView.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = phongBanDataGridView.SelectedRows[0].Index;
                    DataGridViewRow selectedRow = phongBanDataGridView.Rows[selectedRowIndex];
                    int maNhanVien = Convert.ToInt32((selectedRow.Cells["intMaPhong"].Value));
                    string q = "delete from dbo.PhongBan where MaPhong=" + maNhanVien;
                    DataProvider.Instance.ExcuteQuery(q);
                    phongBanDataGridView.Rows.RemoveAt(selectedRowIndex);
                }
                else
                {
                    MessageBox.Show("Hãy chọn hàng muốn xóa!", "Thông báo");
                }
            }
        }
    }

}
