using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Imaging;

namespace CBIR
{
    public partial class frmInputImage : Form
    {
        public frmInputImage()
        {
            InitializeComponent();
            
        }

        private void btnBrowes_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFD = new OpenFileDialog();
            DialogResult dlr = oFD.ShowDialog();
            if (dlr != DialogResult.Cancel)
            {
                pbINewImage.ImageLocation = oFD.FileName;
            }
        }

        private void ConvertImgetoHistrograms(string imgLocation)
        {
            System.Drawing.Bitmap picture = new System.Drawing.Bitmap(imgLocation);
            // Luminance
            long[] myHistogram1 = new long[256];

            for (int i = 0; i < picture.Size.Width; i++)
                for (int j = 0; j < picture.Size.Height; j++)
                {
                    System.Drawing.Color c = picture.GetPixel(i, j);

                    long Temp = 0;
                    Temp += c.R;
                    Temp += c.G;
                    Temp += c.B;

                    Temp = (int)Temp / 3;
                    myHistogram1[Temp]++;
                }

            
            //image 2
            String image2 = @"C:\Users\Tasawer Nawaz\Desktop\1235.jpg";
            long[] myHistogram2 = new long[256];
            System.Drawing.Bitmap picture1 = new System.Drawing.Bitmap(image2);
            // Luminance
            for (int i = 0; i < picture1.Size.Width; i++)
                for (int j = 0; j < picture1.Size.Height; j++)
                {
                    System.Drawing.Color c = picture1.GetPixel(i, j);

                    long Temp = 0;
                    Temp += c.R;
                    Temp += c.G;
                    Temp += c.B;

                    Temp = (int)Temp / 3;
                    myHistogram2[Temp]++;
                }

            // meauring difference

            float[] diff = new float[256];
            for (int i = 0; i < 255; i++)
            {
                diff[i] = ((float)Math.Abs(myHistogram1[i] - myHistogram2[i])) / 255;
            }

            float degreeOfDiff = diff.Sum() / myHistogram1.Length * 100;
            bool sameDistribution = degreeOfDiff == 0;

            MessageBox.Show(degreeOfDiff + "%");
            //MessageBox.MessageBox.Show(sameDistribution.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ConvertImgetoHistrograms(pbINewImage.ImageLocation);
        }
    }
}
