using Booking.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking.UI
{
    public partial class ucLayThongTin1 : UserControl
    {
        public ucLayThongTin1()
        {
            InitializeComponent();
            SetComboBox();
        }
        QuanLiDatPhong qldp = new QuanLiDatPhong();
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void taoDanhSach(ComboBox cb, String ThanhPho)
        {
            List<String> dsTP = new List<String>();
            dsTP = qldp.taoDanhSachDiaChi(ThanhPho);
            cb.DataSource = dsTP;
        }
        private void SetComboBox()
        {
            taoDanhSach(comboBox1, "ThanhPho");
            taoDanhSach(comboBox2, "Quan");
            taoDanhSach(comboBox3, "Phuong");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ucLayThongTin1_Load(object sender, EventArgs e)
        {

        }
    }
}
