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
        private int loggedAccount;
        public accountControl()
        {
            InitializeComponent();

            LoadAccount();
            LoadCongTrinh();
            LoadNhanVien();
            LoadPhongBan();
            InitData();

            congTrinhDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
            congTrinhDataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 129, 115);

            nhanVienGridView.DefaultCellStyle.SelectionBackColor = Color.White;
            nhanVienGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 129, 115);

            phongBanDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
            phongBanDataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 129, 115);

            accountDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
            accountDataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 129, 115);
        }

        public int LoggedAccount
        {
            set { loggedAccount = value;}
        }

        bool checkTaiKhoanHopLe(int q)
        {
            if (q == 0 || q == 1) return true;
            else
            {
                MessageBox.Show("Tài khoản không đủ điều kiện truy cập", "Không có quyền truy cập");
                return false;
            }

        }
        void LoadAccount() {
            accountDataGridView.Rows.Clear();
            List<Account> accountList = AccountDAO.Instance.LoadAccountList();
            foreach (var item in accountList)
            {
                accountDataGridView.Rows.Add(item.AccountID, item.AccountUsername, item.AccountType);
            }
        }

        void LoadCongTrinh()
        {
            congTrinhDataGridView.Rows.Clear();
            List<CongTrinh> congTrinhList = CongTrinhDAO.Instance.LoadCongTrinh();

            foreach (var item in congTrinhList)
            {
                congTrinhDataGridView.Rows.Add(item.Id, item.Name, item.DiaDiem, DateTime.Parse(item.NgayKhoiCong).ToShortDateString(), DateTime.Parse(item.NgayCapPhep).ToShortDateString(), DateTime.Parse(item.NgayHoanThanhDuKien).ToShortDateString() , item.MaPhongQL);
            }
        }

        void LoadNhanVien()
        {
            List<NhanVien> nvList = NhanVienDAO.Instance.LoadNhanVien();

            foreach (var item in nvList)
            {
                if (item.GioiTinh == false) nhanVienGridView.Rows.Add(item.Id, item.TenNV, DateTime.Parse(item.NgaySinh).ToShortDateString(),"Nam", item.DiaChi, item.MaPhong);
                else nhanVienGridView.Rows.Add(item.Id, item.TenNV, DateTime.Parse(item.NgaySinh).ToShortDateString(), "Nữ", item.DiaChi, item.MaPhong);
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
            if (checkTaiKhoanHopLe(loggedAccount))
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
           
        }

        private void addNVBTN_Click(object sender, EventArgs e)
        {
           if (checkTaiKhoanHopLe(loggedAccount))
            {
                fNVAdd addNV = new fNVAdd();
                addNV.ShowDialog();
                nhanVienGridView.Rows.Clear();
                LoadNhanVien();
            }
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
            if (checkTaiKhoanHopLe(loggedAccount))
            {
                fPhongBanAdd phongBanAddFrom = new fPhongBanAdd();
                phongBanAddFrom.ShowDialog();
                phongBanDataGridView.Rows.Clear();
                LoadPhongBan();
            }
        }

        private void phongBanDeleteBtn_Click(object sender, EventArgs e)
        {
            if (checkTaiKhoanHopLe(loggedAccount))
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

        private void congTrinhDelBtn_Click(object sender, EventArgs e)
        {
            if (checkTaiKhoanHopLe(loggedAccount))
            {
                DialogResult res = MessageBox.Show("Bạn có chắc muốn xóa không ?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    if (congTrinhDataGridView.SelectedRows.Count > 0)
                    {
                        int selectedRowIndex = congTrinhDataGridView.SelectedRows[0].Index;
                        DataGridViewRow selectedRow = congTrinhDataGridView.Rows[selectedRowIndex];
                        int maNhanVien = Convert.ToInt32((selectedRow.Cells["MaCongTrinh"].Value));
                        string q = "delete from dbo.CongTrinh where MaCongTrinh=" + maNhanVien;
                        DataProvider.Instance.ExcuteQuery(q);
                        congTrinhDataGridView.Rows.RemoveAt(selectedRowIndex);
                    }
                    else
                    {
                        MessageBox.Show("Hãy chọn hàng muốn xóa!", "Thông báo");
                    }
                }
            }
        }

        private void searchCongTrinhBtn_Click(object sender, EventArgs e)
        {
            if (checkTaiKhoanHopLe(loggedAccount))
            {
                fCongTrinhAdd fCongTrinhAddForm = new fCongTrinhAdd();
                fCongTrinhAddForm.ShowDialog();
                LoadCongTrinh();
            }

        }

        private void accountDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (accountDataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = accountDataGridView.SelectedRows[0].Index;
                DataGridViewRow selectedRow = accountDataGridView.Rows[selectedRowIndex];
                int maAccount = Convert.ToInt32((selectedRow.Cells["maAccount"].Value));
                int maType = Convert.ToInt32((selectedRow.Cells["accountType"].Value));
                inpuUsernameTB.Text = accountDataGridView.Rows[selectedRowIndex].Cells[1].Value.ToString();
                accountTypeCB.SelectedIndex = maType;
                

            }
        }

        void InitData()
        {
            DataTable PhanCapAccount = new DataTable();
            PhanCapAccount.Columns.Add("MaPhanCap");
            PhanCapAccount.Columns.Add("TenGoi");

            PhanCapAccount.Rows.Add(0, "Admin");
            PhanCapAccount.Rows.Add(1, "Trưởng phòng");
            PhanCapAccount.Rows.Add(2, "Nhân viên");

            accountTypeCB.ValueMember = "MaPhanCap";
            accountTypeCB.DisplayMember = "TenGoi";
            accountTypeCB.DataSource = PhanCapAccount;
            accountTypeCB.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void accountDelBTN_Click(object sender, EventArgs e)
        {
            if (checkTaiKhoanHopLe(loggedAccount))
            {
                DialogResult res = MessageBox.Show("Bạn có chắc muốn xóa không ?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    if (accountDataGridView.SelectedRows.Count > 0)
                    {
                        int selectedRowIndex = accountDataGridView.SelectedRows[0].Index;
                        DataGridViewRow selectedRow = accountDataGridView.Rows[selectedRowIndex];
                        int maAccount = Convert.ToInt32((selectedRow.Cells["maAccount"].Value));
                        string q = "delete from dbo.Account where MaAccount=" + maAccount;
                        DataProvider.Instance.ExcuteQuery(q);
                        accountDataGridView.Rows.RemoveAt(selectedRowIndex);
                    }
                    else
                    {
                        MessageBox.Show("Hãy chọn hàng muốn xóa!", "Thông báo");
                    }
                }
            }
        }

        private void accountAddBTN_Click(object sender, EventArgs e)
        {
            if (checkTaiKhoanHopLe(loggedAccount))
            {
                int ID = CapID();
                string userName = inpuUsernameTB.Text;
                string password = inputPassTB.Text;
                int accountType = int.Parse(accountTypeCB.SelectedValue.ToString());

                if (!String.IsNullOrEmpty(userName) && !String.IsNullOrEmpty(password))
                {
                    string q = "select MaAccount from dbo.Account where userName='" + userName + "'";
                    int checkIsExist = DataProvider.Instance.ExcuteNonQuery(q);
                    if (checkIsExist > 0)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo");
                    }
                    else
                    {
                        int okcheck = DataProvider.Instance.ExcuteNonQuery("addAccount @maAccount , @userName , @userPass , @type", new object[] { ID, userName, password, accountType });
                        MessageBox.Show("Đã thêm " + okcheck + " tài khoản!");
                        inpuUsernameTB.Text = "";
                        inputPassTB.Text = "";
                        LoadAccount();
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi nhập liệu", "Thông báo");
                }
            }
        }

        int CapID()
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("select MaAccount from dbo.Account");
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns["MaAccount"];
            dt.PrimaryKey = key;

            for (int i = 0; i < dt.Rows.Count + 1; i++)
            {
                if (!dt.Rows.Contains(i))
                {
                    return i;
                }
            }

            return 0;
        }

        private void searchCTBTN_Click(object sender, EventArgs e)
        {
            Search(searchContentCongTrinhTB.Text, congTrinhDataGridView);
        }


        private void searchContentCongTrinhTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Search(searchContentCongTrinhTB.Text, congTrinhDataGridView);
            }
        }

        private void searchNVBTN_Click(object sender, EventArgs e)
        {
            Search(searchNVTB.Text, nhanVienGridView);
        }

        private void searchNVTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Search(searchNVTB.Text, nhanVienGridView);
            }
        }

        private void searchPBBTN_Click(object sender, EventArgs e)
        {
            Search(searchPBTB.Text, phongBanDataGridView);
        }



        void Search(string searchQ, DataGridView grid)
        {
            try
            {
                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchQ))
                    {
                        row.Selected = true;
                        break;
                    }
                    else if (row.Cells[1].Value.ToString().ToLower().Contains(searchQ))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void searchPBTB_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
