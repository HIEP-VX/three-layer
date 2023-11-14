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
    public partial class Login : Form
    {
        account acc = new account();
        accountBLL accBLL = new accountBLL();
        List<account> list = listAccount.Instance.accounts;

        public Login()
        {
            InitializeComponent();
            this.AcceptButton = btnSubmit;
        }

        bool KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (tenDangNhap == list[i].User_name && matKhau == list[i].Password)
                {
                    // trả kết quả là loại tài khoản này là loại tài khoản gì
                    ConstVariable.loaiTaiKhoan = list[i].TypeAccount;
                    return true;
                }
            }
            return false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            /*string textA = txtusername.Text;
            string textB = txtpassword.Text;*/
            /*if (KiemTraDangNhap(txtusername.Text, txtpassword.Text) && textA != "" && textB != "")
            {
                MainForm f = new MainForm();
                f.Show();
                this.Hide();
                f.Logout += F_Logout;
            }*/
           /* acc.User_name = txtusername.Text;
            acc.Password = txtpassword.Text;

            string getUser = accBLL.checkLogin(acc);

            bool isValid = true; // bien kiem tra hop le
            
            // the hien tra lai ket qua neu nghiep vu khong dung
            switch(getUser)
            {
                case "required_account":
                    MessageBox.Show("The account cannot be empty!");
                    isValid = false;
                    break;
                case "required_password":
                    MessageBox.Show("The password cannot be empty!");
                    isValid = false;
                    break;
                case "Username or password is incorrect.":
                    MessageBox.Show("Username or password is incorrect.");
                    isValid = false;
                    break;
            }

            // den doan nay la tai khoan va mat khau da dung
            //  && KiemTraDangNhap(txtusername.Text, txtpassword.Text) && textA != "" && textB != ""
            if (isValid)
            {
                FormMain2 fm = new FormMain2();
                fm.Show();
                this.Hide();
            }*/
           DataTable dt = new DataTable();
            dt = AccessData.getData("select * from taiKhoan where user_name = '" + txtusername.Text + "'and  password = '" + txtpassword.Text + "'");
            if(dt.Rows.Count > 0)
            {
                user.currentUser = txtusername.Text;
                FormMain2 fm = new FormMain2();
                fm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect.");
            }

            
        }

        

        private void btnSubmit_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSubmit.PerformClick();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
