using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace forgotPassword
{
    public partial class ResetPassword : Form
    {
        string username = sendCode.to;
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtResetPass.Text == txtResetPassVer.Text)
            {
                SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=forgetPassword;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[forgotPassword] SET [password] = '" + txtResetPassVer.Text + "' WHERE username='" + username + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("reset successfully");
            }
            else
            {
                MessageBox.Show("the new password don't match so enter same password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
    }
}
