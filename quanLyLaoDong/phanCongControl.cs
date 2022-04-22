using quanLyLaoDong.DAO;
using quanLyLaoDong.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyLaoDong
{
    public partial class phanCongControl : UserControl
    {
        public phanCongControl()
        {
            InitializeComponent();
            LoadPhanCong();
            phanCongDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
            phanCongDataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 129, 115);
        }

        private void phanCongControl_Load(object sender, EventArgs e)
        {

        }

        void LoadPhanCong()
        {
            phanCongDataGridView.Rows.Clear();
            List<PhanCong> phanCongList = PhanCongDAO.Instance.LoadPhanCong();
            List<CongTrinh> ctList = CongTrinhDAO.Instance.LoadCongTrinh();
            List<NhanVien> nvList = NhanVienDAO.Instance.LoadNhanVien();
            string tenCT = "";
            string tenNV = "";
            foreach (var item in phanCongList)
            {
             
                foreach (var itemCT in ctList)
                {
                    if (item.MaCongTrinh == itemCT.Id)
                    {
                        tenCT = itemCT.Name;
                    }
                }

                foreach (var itemNV in nvList)
                {
                    if (item.MaNV == itemNV.Id)
                    {
                        tenNV = itemNV.TenNV;
                    }
                }

                phanCongDataGridView.Rows.Add(item.MaPhanCong, tenCT, tenNV, item.SoGio);
            }
        }

        private void addPhanCongBTN_Click(object sender, EventArgs e)
        {
            fPhanCong phanCongAddForm = new fPhanCong();
            phanCongAddForm.ShowDialog();

            LoadPhanCong();
        }

        private void delBTN_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc muốn xóa không ?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                if (phanCongDataGridView.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = phanCongDataGridView.SelectedRows[0].Index;
                    DataGridViewRow selectedRow = phanCongDataGridView.Rows[selectedRowIndex];
                    int maPhanCong = Convert.ToInt32((selectedRow.Cells["MaPhanCong"].Value));
                    string q = "delete from dbo.PhanCong where MaPhanCong=" + maPhanCong;
                    DataProvider.Instance.ExcuteQuery(q);
                    phanCongDataGridView.Rows.RemoveAt(selectedRowIndex);
                }
                else
                {
                    MessageBox.Show("Hãy chọn hàng muốn xóa!", "Thông báo");
                }
            }
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            UpdateData();

        }

        private void phanCongDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateData();
        }

        void UpdateData()
        {
            if (phanCongDataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = phanCongDataGridView.SelectedRows[0].Index;
                DataGridViewRow selectedRow = phanCongDataGridView.Rows[selectedRowIndex];
                int MaPhanCong = Convert.ToInt32((selectedRow.Cells["MaPhanCong"].Value));
                fPhanCongEdit fPhanCongForm = new fPhanCongEdit();

                fPhanCongForm.maPhanCong = MaPhanCong.ToString();
                fPhanCongForm.maNhanVienTrans = selectedRow.Cells["MaNhanVien"].Value.ToString();
                fPhanCongForm.TenCongTrinhTrans = selectedRow.Cells["MaCongTrinh"].Value.ToString();

                fPhanCongForm.ShowDialog();
                phanCongDataGridView.Rows.Clear();

                LoadPhanCong();
            }
        }
    }
}
