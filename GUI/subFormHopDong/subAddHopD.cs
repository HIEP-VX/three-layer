using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class subAddHopD : Form
    {

        public bool isExit = true;
        public event EventHandler Logout;
        public event Action DataAdded;

        public subAddHopD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO HopDong (ngayLamHD, noiLamHD) values ('" + dateTimeNL.Value + "',N'" + txtNoiLap.Text + "')";
            try
            {
                AccessData.execQuery(query);
                MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
            DataAdded?.Invoke();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }
    }
}
