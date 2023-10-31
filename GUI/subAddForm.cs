using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using DAL;

namespace GUI
{
    public partial class subAddForm : Form
    {

        public bool isExit = true;
        public event EventHandler Logout;
        public event Action DataAdded;

        public subAddForm()
        {
            InitializeComponent();
        }

        #region Event
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }
        #endregion

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO NhanVien (maNV, tenNV, soDT) values ('" + txtmaNV.Text + "','" + txttenNV.Text + "','" + txtsoDT.Text + "')";
            try
            {
                AccessData.execQuery(query);
                MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
            DataAdded?.Invoke();
        }
    }
}
