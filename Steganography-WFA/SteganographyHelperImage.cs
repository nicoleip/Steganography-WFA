using System;
using System.Drawing;
using AForge.Imaging.Filters;
using System.Collections;
using System.Data;
using System.Linq;


namespace Steganography_WFA
{
    class SteganographyHelperImage
    {

        public static Bitmap encryptImage(Bitmap mainImage, Bitmap hiddenImage)
        {
            if (hiddenImage.Height != mainImage.Height || hiddenImage.Width != mainImage.Width)
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

            for (int i = 0; i < mainImage.Height; i++)
            {
                for (int j = 0; j < mainImage.Width; j++)
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

            return mainImage;
        }

        public static Bitmap decryptImage(Bitmap EncryptedImage, Bitmap hiddenImage)
        {
            byte[] BitsToDecrypt = new byte[8];
            byte[] AlphaBits;
            byte[] RedBits;
            byte[] GreenBits;
            byte[] BlueBits;

            byte newGrey = 0;

            Color pixelToDecrypt = new Color();

            for (int i = 0; i < EncryptedImage.Height; i++)
            {
                for (int j = 0; j < EncryptedImage.Width; j++)
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

            return hiddenImage;
        }

        public static byte[] getBits(byte mainpixel)
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

        public static byte getByte(byte[] bits)
        {
            String bitString = "";

            for (int i = 0; i < 8; i++)
                bitString += bits[i];
            byte newPixel = Convert.ToByte(bitString, 2);

            return newPixel;
        }

        public static Bitmap toGrayscale(Bitmap bitmap)
        {
            int i, j, grey;
            Color color;

            for (i = 0; i < bitmap.Width; i++)
            {
                for (j = 0; j < bitmap.Height; j++)
                {
                    color = bitmap.GetPixel(i, j);
                    grey = (int)((color.R + color.G + color.B) / 3);

                    bitmap.SetPixel(i, j, Color.FromArgb(grey, grey, grey));
                }
            }

            return bitmap;
        }
    }
}
