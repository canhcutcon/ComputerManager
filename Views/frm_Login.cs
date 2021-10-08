using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_ComputerManager;

namespace Views

{
    public partial class frm_Login : Form
    {
        int dem = 0;
        public frm_Login()
        {
            InitializeComponent();
        }

        public DTO_Login user;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text.Length == 0 || txtPassword.Text.Length == 0)
            {
                dem++;
                MessageBox.Show("Please enter username, password!");
            }else if (txtUsername.Text.Equals("Canhcutcon") && txtPassword.Text.Equals("giang123"))
            {
                user = new DTO_Login(txtUsername.Text, txtPassword.Text);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
