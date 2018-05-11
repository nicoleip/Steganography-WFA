using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging.Filters;

namespace Steganography_WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBrowseMain_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif |JPEG Image (.jpeg)|*.jpeg |Png Image (.png)|*.png";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxMainImage.ImageLocation = ofd.FileName;
                buttonBrowseHidden.Enabled = true;
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {

        }

        private void buttonBrowseHidden_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif |JPEG Image (.jpeg)|*.jpeg |Png Image (.png)|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap img = new Bitmap(ofd.FileName);
                pictureBoxHiddenImage.Image = toGrayscale(img);           
            }
        }

        private Bitmap toGrayscale(Bitmap bitmap)
        {
            int i, j, grey;
            Color color;

            for(i=0; i< bitmap.Width; i++)
            {
                for(j=0; j<bitmap.Height; j++)
                {
                    color = bitmap.GetPixel(i, j);
                    grey = (int)((color.R + color.G + color.B) / 3);

                    bitmap.SetPixel(i, j, Color.FromArgb(grey, grey, grey));
                }
            }

            return bitmap;
        }

        private void buttonGenerateHiddenImage_Click(object sender, EventArgs e)
        {
            Bitmap mainImage = new Bitmap(pictureBoxMainImage.Image);
            Bitmap hiddenImage = new Bitmap(pictureBoxHiddenImage.Image);

            if(hiddenImage.Height != mainImage.Height || hiddenImage.Width != mainImage.Width)
            {
                ResizeBilinear resizeFilter = new ResizeBilinear(mainImage.Width, mainImage.Height);
                hiddenImage = resizeFilter.Apply(hiddenImage);
            }

            Color pixelContainerImage = new Color();
            Color pixelMsgImage = new Color();

            byte[] MsgBits;
            byte[] AlphaBits;
            byte[] RedBits;
            byte[] GreenBits;
            byte[] BlueBits;

            byte newAlpha = 0;
            byte newRed = 0;
            byte newGreen = 0;
            byte newBlue = 0;

            for(int i=0; i< mainImage.Height; i++)
            {
                for(int j=0; j< mainImage.Width; j++)
                {
                    pixelMsgImage = hiddenImage.GetPixel(j, i);
                    MsgBits = getBits((byte)pixelMsgImage.R);

                    pixelContainerImage = mainImage.GetPixel(j, i);
                    AlphaBits = getBits((byte)pixelContainerImage.A);
                    RedBits = getBits((byte)pixelContainerImage.R);
                    GreenBits = getBits((byte)pixelContainerImage.G);
                    BlueBits = getBits((byte)pixelContainerImage.B);

                    AlphaBits[6] = MsgBits[0];
                    AlphaBits[7] = MsgBits[1];

                    RedBits[6] = MsgBits[2];
                    RedBits[7] = MsgBits[3];

                    GreenBits[6] = MsgBits[4];
                    GreenBits[7] = MsgBits[5];

                    BlueBits[6] = MsgBits[6];
                    BlueBits[7] = MsgBits[7];

                    newAlpha = getByte(AlphaBits);
                    newRed = getByte(RedBits);
                    newGreen = getByte(GreenBits);
                    newBlue = getByte(BlueBits);

                    pixelContainerImage = Color.FromArgb(newAlpha, newRed, newGreen, newBlue);
                    mainImage.SetPixel(j, i, pixelContainerImage);
                }
            }

            pictureBoxResultImage.Image = mainImage;

        }

        private byte[] getBits(byte mainpixel)
        {
            int pixel = 0;
            pixel = (int)mainpixel;

            BitArray bits = new BitArray(new byte[] { (byte)pixel });
            bool[] boolarray = new bool[bits.Count];

            bits.CopyTo(boolarray, 0);
            byte[] bitsArray = boolarray.Select(bit => (byte)(bit ? 1 : 0)).ToArray();
            Array.Reverse(bitsArray);
            return bitsArray;
        }

        private byte getByte(byte[] bits)
        {
            String bitString = "";

            for(int i=0; i <8; i++)
                bitString += bits[i];
           byte newPixel = Convert.ToByte(bitString, 2);

            return newPixel;
        }

        private void buttonSaveGeneratedImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Bitmap Image (.bnp)|*.bmp";

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxResultImage.Image.Save(sfd.FileName);
            }
        }
    }
}
