using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using static System.Net.Mime.MediaTypeNames;

namespace Barcode_Generator_Reader
{
    public partial class Barcode_Reader : Form
    {
        public Barcode_Reader()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Veri Dosyaları (*.dat)|*.dat|Tüm Dosyalar (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string dosyaYolu = openFileDialog.FileName;

                BarcodeReader barcodeReader = new BarcodeReader();

                using (Bitmap image = (Bitmap)System.Drawing.Image.FromFile(dosyaYolu))
                {
                    Result result = barcodeReader.Decode(image);

                    if (result != null)
                    {
                        string okunanVeri = result.Text;
                        MessageBox.Show($"Okunan Veri: {okunanVeri}");
                    }
                    else
                    {
                        MessageBox.Show("QR Kodu veya Barkod okunamadı.");
                    }
                }
            }
        }
    }
}
