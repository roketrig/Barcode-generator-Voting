using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zen.Barcode;

namespace Barcode_Generator_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void barcode_btn_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox1.Image = barcode.Draw(textBox1.Text, 50);
        }

        private void qr_btn_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrcode.Draw(textBox2.Text, 50);
        }
        private byte[] GenerateQRCodeData(string data)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            Image qrImage = qrcode.Draw(data, 50);

            using (MemoryStream ms = new MemoryStream())
            {
                qrImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void kaydet_btn_Click(object sender, EventArgs e)
        {
            string qrData = textBox2.Text;
            byte[] qrCodeData = GenerateQRCodeData(qrData);
            string dosyaYolu = Path.Combine(Application.StartupPath, "qrcode.dat");

            File.WriteAllBytes(dosyaYolu, qrCodeData);
        }

        private void okut_btn_Click(object sender, EventArgs e)
        {
            Barcode_Reader yeniform = new Barcode_Reader();
            yeniform.Show();
            this.Hide();
        }
    }
}
