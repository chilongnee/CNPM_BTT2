using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbb_quequan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public class queQuan
        {
            public string Name { get; set; }
            public override string ToString()
            {
                return "" + Name;
            }
        }

        public class dsMon
        {
            public string Mon { get; set; }
            public override string ToString()
            {
                return "" + Mon;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Chào mừng bạn đến đăng ký môn học");
            string line = "";
            List<queQuan> queQuans = new List<queQuan>();
            System.IO.StreamReader streamReader = new System.IO.StreamReader("quequan.txt");

            while((line = streamReader.ReadLine()) != null)
            {
                queQuan quequan = new queQuan();
                quequan.Name = line;
                queQuans.Add(quequan);
            }

            cbb_quequan.DataSource = queQuans;
            cbb_quequan.DisplayMember = "Name";
            cbb_quequan.ResetText();

            string line2 = "";
            List<dsMon> dsMons = new List<dsMon>();
            System.IO.StreamReader streamReaderdsMon = new System.IO.StreamReader("dsmon.txt");

            while ((line2 = streamReaderdsMon.ReadLine()) != null)
            {
                dsMon dsmon = new dsMon();
                dsmon.Mon = line2;
                dsMons.Add(dsmon);
            }

            gridview.DataSource = dsMons;

            gridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txtbox_hovaten.Clear();
            txtbox_lop.Clear();
            txtbox_mssv.Clear();
            cbb_quequan.ResetText();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txtbox_mssv.Text == "")
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin");
                txtbox_mssv.Focus();
            } else if (txtbox_lop.Text == "")
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin");
                txtbox_lop.Focus();
            } else if(txtbox_hovaten.Text == "")
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin");
                txtbox_hovaten.Focus();
            } else if(cbb_quequan.Text == "")
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin");
            } else
            {
                TextWriter txt = new StreamWriter("output.txt");
                txt.Write(txtbox_hovaten.Text + " - ");
                txt.Write(txtbox_lop.Text + " - ");
                txt.Write(txtbox_mssv.Text + " - ");
                txt.Write(cbb_quequan.Text + " - ");
                txt.Write(gridview.CurrentCell.Value);
                txt.Close();

                MessageBox.Show("Bạn đã đăng ký thành công");
            }
        }
    }
}
