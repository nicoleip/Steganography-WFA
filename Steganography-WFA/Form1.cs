using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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

        public enum State
        {
            Hiding,
            Filling_With_Zeros
        };

        private Bitmap bitmap = null;
        private string extractedText = string.Empty;

        private void buttonBrowseMain_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif |JPEG Image (.jpeg)|*.jpeg |JPG Image (.jpg)|*.jpg |Png Image (.png)|*.png";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxMainImage.ImageLocation = ofd.FileName;
                buttonBrowseHidden.Enabled = true;
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif |JPEG Image (.jpeg)|*.jpeg |JPG Image (.jpg)|*.jpg |Png Image (.png)|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxMainImg.ImageLocation = ofd.FileName;
                buttonGenerateImage.Enabled = true;
            }
        }

        private void buttonBrowseHidden_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif |JPEG Image (.jpeg)|*.jpeg |JPG Image (.jpg)|*.jpg |Png Image (.png)|*.png";
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

        private static Bitmap embedText(string text, Bitmap bmp)
        {
            State state = State.Hiding;

            int charIndex = 0;
            int charValue = 0;

            long pixelelementIndex = 0;

            int zeros = 0;

            int R, G, B = 0;

            for(int i=0; i < bmp.Height; i++)
            {
                for(int j=0; j<bmp.Width; j++)
                {
                    Color pixel = bmp.GetPixel(j, i);

                    R = pixel.R - pixel.R % 2;
                    G = pixel.G - pixel.G % 2;
                    B = pixel.B - pixel.B % 2;

                    for(int n=0; n<3; n++)
                    {
                        if(pixelelementIndex % 8 == 0)
                        {
                            if(state == State.Filling_With_Zeros && zeros == 8)
                            {
                                if((pixelelementIndex -1) % 3 < 2)
                                {
                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }

                                return bmp;
                            }

                            if(charIndex >= text.Length)
                            {
                                state = State.Filling_With_Zeros;
                            } else
                            {
                                charValue = text[charIndex++];
                            }
                        }

                        switch (pixelelementIndex % 3)
                        {
                            case 0:
                                {
                                    if(state == State.Hiding)
                                    {
                                        R += charValue % 2;
                                        charValue /= 2;
                                    }
                                } break;

                            case 1:
                                {
                                    if (state == State.Hiding)
                                    {
                                        G += charValue % 2;
                                        charValue /= 2;
                                    }
                                } break;

                            case 2:
                                {
                                    if (state == State.Hiding)
                                    {
                                        B += charValue % 2;
                                        charValue /= 2;
                                    }
                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }break;
                        }

                        pixelelementIndex++;

                        if(state == State.Filling_With_Zeros)
                        {
                            zeros++;
                        }
                    }
                }
            }

            return bmp;
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

        private void buttonBrowseDecrypt_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|JPG Image (.jpg)|*.jpg|Png Image (.png)|*.png ";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureDecryptImg.ImageLocation = ofd.FileName;
            }
        }

        private void buttonGenerateDecrypted_Click(object sender, EventArgs e)
        {
            Bitmap EncryptedImage = (Bitmap)pictureDecryptImg.Image;
            Bitmap hiddenImage = new Bitmap(EncryptedImage.Width, EncryptedImage.Height);

            byte[] BitsToDecrypt = new byte[8];
            byte[] AlphaBits;
            byte[] RedBits;
            byte[] GreenBits;
            byte[] BlueBits;

            byte newGrey = 0;

            Color pixelToDecrypt = new Color();

            for(int i=0; i < EncryptedImage.Height; i++)
            {
                for (int j=0; j < EncryptedImage.Width; j++)
                {
                    pixelToDecrypt = EncryptedImage.GetPixel(j, i);

                    AlphaBits = getBits((byte)pixelToDecrypt.A);
                    RedBits = getBits((byte)pixelToDecrypt.R);
                    GreenBits = getBits((byte)pixelToDecrypt.G);
                    BlueBits = getBits((byte)pixelToDecrypt.B);

                    BitsToDecrypt[0] = AlphaBits[6];
                    BitsToDecrypt[1] = AlphaBits[7];
                    BitsToDecrypt[0] = AlphaBits[6];
                    BitsToDecrypt[1] = AlphaBits[7];
                    BitsToDecrypt[2] = RedBits[6];
                    BitsToDecrypt[3] = RedBits[7];
                    BitsToDecrypt[4] = GreenBits[6];
                    BitsToDecrypt[5] = GreenBits[7];
                    BitsToDecrypt[6] = BlueBits[6];
                    BitsToDecrypt[7] = BlueBits[7];

                    newGrey = getByte(BitsToDecrypt);

                    pixelToDecrypt = Color.FromArgb(newGrey, newGrey, newGrey);

                    hiddenImage.SetPixel(j, i, pixelToDecrypt);
                }

            }

            pictureBoxExtractedImg.Image = hiddenImage;
            buttonSaveExtracted.Enabled = true;
        }

        private void buttonSaveExtracted_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png ";

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxExtractedImg.Image.Save(sfd.FileName);
            }
        }

        private void browseExtractText_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif |JPEG Image (.jpeg)|*.jpeg |JPG Image (.jpg)|*.jpg |Png Image (.png)|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxExtractTextImg.ImageLocation = ofd.FileName;
                buttonExtractText.Enabled = true;
            }
        }

        private static string extractText(Bitmap bmp)
        {
            int ColorUnitIndex = 0;
            int charValue = 0;

            string extractedText = String.Empty;

            for(int i=0; i< bmp.Height; i++)
            {
                for(int j=0; j<bmp.Width; j++)
                {
                    Color pixel = bmp.GetPixel(j, i);

                    for (int n=0; n<3; n++)
                    {
                        switch(ColorUnitIndex %3)
                        {
                            case 0:
                                {
                                    charValue = charValue * 2 + pixel.R % 2;
                                }break;

                            case 1:
                                {
                                    charValue = charValue * 2 + pixel.G % 2;
                                }break;

                            case 2:
                                {
                                    charValue = charValue * 2 + pixel.B % 2;
                                }break;
                        }

                        ColorUnitIndex++;
                    }

                    if(ColorUnitIndex % 8 == 0)
                    {
                        charValue = reverseBtis(charValue);

                        if (charValue == 0)
                        {
                            return extractedText;
                        }

                        char c = (char)charValue;

                        extractedText += c.ToString();
                    }
                }
            }

            return extractedText;
        }

        private static int reverseBtis(int n)
        {
            int result = 0;

            for(int i=0; i < 8; i++)
            {
                result = result * 2 + n % 2;

                n /= 2;
            }

            return result;
        }

        private void buttonExtractText_Click(object sender, EventArgs e)
        {
            
            bitmap = (Bitmap)pictureBoxExtractTextImg.Image;

            string extractedText = extractText(bitmap);

            textBoxExtractedText.Text = extractedText;
        }

        private void buttonGenerateImage_Click(object sender, EventArgs e)
        {
            bitmap = (Bitmap)pictureBoxMainImg.Image;
            string text = textBoxHiddenText.Text;

            bitmap = embedText(text, bitmap);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Bitmap Image (.bmp)|*.bmp";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                switch (sfd.FilterIndex)
                {
                    case 0:
                        {
                            bitmap.Save(sfd.FileName, ImageFormat.Png);
                        }
                        break;
                    case 1:
                        {
                            bitmap.Save(sfd.FileName, ImageFormat.Bmp);
                        }
                        break;
                }
            }


        }

       
    }
}
