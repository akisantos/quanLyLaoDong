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
    public partial class searchControl : UserControl
    {
        public searchControl()
        {
            InitializeComponent();
            dataInitation();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void searchBTN_Click(object sender, EventArgs e)
        {
            
            string searchStr = searchContentTB.Text;
            string searchCategory = searchCategoryCB.Text;
            if (searchStr == "")
            {
                Search("", searchCategory);
            }
            else Search(searchStr, searchCategory);
        }

    

        void Search(string sq, string searchCategory)
        {

            if (searchCategory == "Nhân viên")
            {
                SearchNhanVien(sq);
            }

            if (searchCategory == "Phân công")
            {
                SearchPhanCong(sq);
            }           

        }

        void SearchNhanVien(string searchQ)
        {
            ClearGridView();

            List<NhanVien> list = NhanVienDAO.Instance.searchNhanVien(searchQ);

            if (searchQ == "")
            {
   
                resultDataGridView.DataSource = list;
                NVGridStyle();

            }
            else
            {
               if (int.TryParse(searchQ, out int n))
                {
                    resultDataGridView.DataSource = list;
                    NVGridStyle();
                }
                else
                {
                    CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
                    TextInfo textInfo = cultureInfo.TextInfo;

                    string holder = textInfo.ToTitleCase(searchQ);
                    var item = list.Where(x => x.TenNV.Contains(holder)).ToList();
                    if (item != null)
                    {
                        resultDataGridView.DataSource = item;
                        NVGridStyle();
                    }
                    else MessageBox.Show("Không tìm thấy!");
                }
               
            }

        }

        void NVGridStyle()
        {
            resultDataGridView.Columns[0].HeaderText = "ID";
            resultDataGridView.Columns[1].HeaderText = "Họ tên";
            resultDataGridView.Columns[2].HeaderText = "Ngày sinh";
            resultDataGridView.Columns[3].HeaderText = "Giới tính";
            resultDataGridView.Columns[4].HeaderText = "Địa chỉ";
            resultDataGridView.Columns[5].HeaderText = "Mã phòng quản lý";
            
        }

        void SearchPhanCong(string searchQ)
        {
            ClearGridView();
            List<PhanCong> phanCongList = PhanCongDAO.Instance.LoadPhanCong();
            List<CongTrinh> ctList = CongTrinhDAO.Instance.LoadCongTrinh();
            List<NhanVien> nvList = NhanVienDAO.Instance.LoadNhanVien();
            string tenCT = "";
            string tenNV = "";

            resultDataGridView.Columns.Add("MaPhanCong", "Mã phân công");
            resultDataGridView.Columns.Add("TenCT", "Tên công trình");
            resultDataGridView.Columns.Add("TenNV", "Tên nhân viên");
            resultDataGridView.Columns.Add("soGio", "Số giờ phân công");


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

                resultDataGridView.Rows.Add(item.MaPhanCong, tenCT, tenNV, item.SoGio);
            }
        }

        void dataInitation()
        {   
            searchCategoryCB.Items.Add("Phân công");
            searchCategoryCB.Items.Add("Nhân viên");
            searchCategoryCB.SelectedIndex = 0;
            searchCategoryCB.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void searchCategoryCB_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void searchContentTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string searchStr = searchContentTB.Text;
                string searchCategory = searchCategoryCB.Text;
                Search(searchStr, searchCategory);
            }
        }

        void ClearGridView()
        {
            resultDataGridView.DataSource = null;
            resultDataGridView.Columns.Clear();
            resultDataGridView.Rows.Clear();
        }
    }
}
