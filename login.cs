using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlinhanvien
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = tendangnhap.Text;
            string password = matkhau.Text;

            if (ValidateLogin(username, password))
            {
                //MessageBox.Show("Đăng nhập thành công!");
                this.Hide();
                dashboard dashboard = new dashboard();
                dashboard.Show();
         
                // Thực hiện các hành động sau khi đăng nhập thành công
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại tên đăng nhập và mật khẩu!");
            }
        }
        private bool ValidateLogin(string username, string password)
        {
            // Thực hiện kiểm tra tên đăng nhập và mật khẩu trong cơ sở dữ liệu hoặc các phương thức xác thực khác
            // Trong ví dụ này, chúng ta chỉ kiểm tra xem tên đăng nhập và mật khẩu có phải là "admin" không

            if (username == "admin" && password == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonthoat2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}