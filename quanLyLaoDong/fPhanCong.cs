using quanLyLaoDong.DAO;
using quanLyLaoDong.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyLaoDong
{
    public partial class fPhanCong : Form
    {
        public fPhanCong()
        {
            InitializeComponent();
            InitData();

        }

        void InitData()
        {
            //get data for CongTrinh
            DataTable data = DataProvider.Instance.ExcuteQuery("select MaCongTrinh,TenGoi from dbo.CongTrinh");
            congTrinhCB.ValueMember = "MaCongTrinh";
            congTrinhCB.DisplayMember = "TenGoi";

            congTrinhCB.DataSource = data;
            congTrinhCB.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        void SearchNhanVien(string searchQ)
        {
            nhanVienGridView.Rows.Clear();
            List<NhanVien> list = NhanVienDAO.Instance.searchNhanVien(searchQ);
  
            if (searchQ == "")
            {
                foreach (var item in list)
                {
                    if (item.GioiTinh == false) nhanVienGridView.Rows.Add(item.Id, item.TenNV, item.NgaySinh, "Nam", item.DiaChi, item.MaPhong);
                    else nhanVienGridView.Rows.Add(item.Id, item.TenNV, item.NgaySinh, "Nữ", item.DiaChi, item.MaPhong);
                }
            }
            else
            {
                if (int.TryParse(searchQ, out int n))
                {
                    foreach (var item in list)
                    {
                        if (item.GioiTinh == false) nhanVienGridView.Rows.Add(item.Id, item.TenNV, item.NgaySinh, "Nam", item.DiaChi, item.MaPhong);
                        else nhanVienGridView.Rows.Add(item.Id, item.TenNV, item.NgaySinh, "Nữ", item.DiaChi, item.MaPhong);
                    }
                }
                else
                {
                    CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
                    TextInfo textInfo = cultureInfo.TextInfo;

                    string holder = textInfo.ToTitleCase(searchQ);
                    var item = list.Where(x => x.TenNV.Contains(holder)).ToList();
                    if (item != null)
                    {
               
                        foreach (var item2 in item)
                        {
                            if (item2.GioiTinh == false) nhanVienGridView.Rows.Add(item2.Id, item2.TenNV, item2.NgaySinh, "Nam", item2.DiaChi, item2.MaPhong);
                            else nhanVienGridView.Rows.Add(item2.Id, item2.TenNV, item2.NgaySinh, "Nữ", item2.DiaChi, item2.MaPhong);
                        }

                    }
                    else MessageBox.Show("Không tìm thấy!");
                }

            }



        }

        private void searchContentTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string searchStr = searchContentTB.Text;
                SearchNhanVien(searchStr);

            }
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            string searchStr = searchContentTB.Text;
            
            SearchNhanVien(searchStr);


        }

        private void addPCBTN_Click(object sender, EventArgs e)
        {
            if (nhanVienGridView.SelectedRows.Count > 0)
            {
                string MaNV = nhanVienGridView.SelectedRows[0].Cells[0].Value.ToString();
                string TenNV = nhanVienGridView.SelectedRows[0].Cells[1].Value.ToString();
                int TenCongTrinh = (int)congTrinhCB.SelectedValue;

                if (checkData(MaNV, TenCongTrinh))
                {
                    confirmDataGridView.Rows.Add(MaNV, TenNV, 0, TenCongTrinh);
                }
    
               
            }
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        bool checkData(string maNV, int ct)
        {

            if (DataProvider.Instance.ExcuteNonQuery("getPhanCong @maNhanVien , @maCongTrinh", new object[] { maNV, ct }) == 0)
            {
                MessageBox.Show("Nhân viên này đã có trong cơ sở dữ liệu");
                return false;
            }

            for (int i = 0; i < confirmDataGridView.Rows.Count; i++)
            {
                string holder = confirmDataGridView.Rows[i].Cells[0].Value.ToString();
                int holde2 = (int) confirmDataGridView.Rows[i].Cells[3].Value;
                if (holder == maNV && holde2 == ct)
                {
                    MessageBox.Show("Nhân viên này đã có trong danh sách");
                    confirmDataGridView.ClearSelection();
                    confirmDataGridView.Rows[i].Selected = true;
                    confirmDataGridView.Focus();
                    return false;
                }
                else
                {
                    
                }
            }

            return true;
        }

        private void phanCongBTN_Click(object sender, EventArgs e)
        {

            if (confirmDataGridView.Rows.Count > 0)
            {
                for (int i = 0; i < confirmDataGridView.Rows.Count; i++)
                {
                    int Id = CapID();
                    int MaNV = int.Parse(confirmDataGridView.Rows[i].Cells[0].Value.ToString());
                    int MaCT = int.Parse(confirmDataGridView.Rows[i].Cells[3].Value.ToString());
                    double soGio = double.Parse(confirmDataGridView.Rows[i].Cells[2].Value.ToString());

                    string q = "insert into dbo.PhanCong(MaPhanCong, MaCongTrinh, MaNhanVien, SoGio) values (" + Id + " , " + MaCT + " ," + MaNV + " ," + soGio + ")";
                    //DataProvider.Instance.ExcuteQuery("addPhanCong @maPhanCong , @maCongTrinh , @maNV , @soGio", new object[] { Id , MaCT, MaNV, soGio });
                    DataProvider.Instance.ExcuteQuery(q);

                }
                Close();
            }
            else
            {
                MessageBox.Show("Không có sự phân công mới nào được lưu!", "Thông báo");
            }
        }

        int CapID()
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("select MaPhanCong from dbo.PhanCong");
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns["MaPhanCong"];
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

        private void confirmDataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void confirmDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            
        }

        private void confirmDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(floatSoGio_KeyPress);
            if (confirmDataGridView.CurrentCell.ColumnIndex == 0) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(floatSoGio_KeyPress);
                }
            }
        }

        private void floatSoGio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void confirmDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            
        }
    }
}
