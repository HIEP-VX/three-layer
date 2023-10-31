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

namespace GUI
{
    public partial class Login : Form
    {
        account acc = new account();
        accountBLL accBLL = new accountBLL();

        public Login()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            acc.User_name = txtusername.Text;
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

            if (isValid)
            {
                FormMain2 fm = new FormMain2();
                fm.Show();
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
