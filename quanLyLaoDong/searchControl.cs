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

        }

        void SearchNhanVien(string searchQ)
        {

            List<NhanVien> list = NhanVienDAO.Instance.searchNhanVien(searchQ);
            if (searchQ == "")
            {
                resultDataGridView.DataSource = list;
            }
            else
            {
               if (int.TryParse(searchQ, out int n))
                {
                    resultDataGridView.DataSource = list;
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
                    }
                    else MessageBox.Show("Không tìm thấy!");
                }
               
            }
            


        }

        void dataInitation()
        {   
            searchCategoryCB.Items.Add("Phân công");
            searchCategoryCB.Items.Add("Công trình");
            searchCategoryCB.Items.Add("Nhân viên");
            searchCategoryCB.Items.Add("Phòng ban");

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
    }
}
