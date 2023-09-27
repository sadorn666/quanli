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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string imagePath = "path_to_image.jpg";
            Image originalImage = Image.FromFile(imagePath);

            int newWidth = 100;
            int newHeight = 100;

            // Thay đổi kích thước ảnh
            Image resizedImage = ResizeImage(originalImage, newWidth, newHeight);
            pictureBox1.Image = resizedImage;
        }
        private Image ResizeImage(Image image, int newWidth, int newHeight)
        {
            // Tạo một Bitmap mới với kích thước mới
            Bitmap resizedBitmap = new Bitmap(newWidth, newHeight);

            // Tạo một đối tượng Graphics từ Bitmap mới
            using (Graphics graphics = Graphics.FromImage(resizedBitmap))
            {
                // Cài đặt chế độ chất lượng cao
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                // Vẽ ảnh đã thay đổi kích thước lên Bitmap mới
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            // Trả về ảnh đã thay đổi kích thước
            return resizedBitmap;
        }

        private void buttonthoat2_Click(object sender, EventArgs e)
        {
            
            login login = new login();
            login.Show();
            this.Close();
        }
    }
}
