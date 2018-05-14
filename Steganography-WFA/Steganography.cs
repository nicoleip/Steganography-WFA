using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;


namespace Steganography_WFA
{
    public partial class Steganography : Form
    {
        public Steganography()
        {
            InitializeComponent();
        }        

        private void buttonBrowseMain_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif |JPEG Image (.jpeg)|*.jpeg |JPG Image (.jpg)|*.jpg |Png Image (.png)|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
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
                pictureBoxHiddenImage.Image = SteganographyHelperImage.toGrayscale(img);
            }
        }       

        private void buttonGenerateHiddenImage_Click(object sender, EventArgs e)
        {
            Bitmap mainImage = new Bitmap(pictureBoxMainImage.Image);
            Bitmap hiddenImage = new Bitmap(pictureBoxHiddenImage.Image);

            mainImage = SteganographyHelperImage.encryptImage(mainImage, hiddenImage);

            pictureBoxResultImage.Image = mainImage;

        }       

        private void buttonSaveGeneratedImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Bitmap Image (.bnp)|*.bmp";

            if (sfd.ShowDialog() == DialogResult.OK)
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

            hiddenImage = SteganographyHelperImage.decryptImage(EncryptedImage, hiddenImage);

            pictureBoxExtractedImg.Image = hiddenImage;
            buttonSaveExtracted.Enabled = true;
        }

        private void buttonSaveExtracted_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png ";

            if (sfd.ShowDialog() == DialogResult.OK)
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

        private void buttonExtractText_Click(object sender, EventArgs e)
        {

            Bitmap bmp = (Bitmap)pictureBoxMainImg.Image;

            string extractedText = SteganographyHelperText.extractText(bmp);

            textBoxExtractedText.Text = extractedText;
        }

        private void buttonGenerateImage_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBoxMainImg.Image;
            string text = textBoxHiddenText.Text;

            bmp = SteganographyHelperText.embedText(text, bmp);

            pictureBoxMainImg.Image = bmp;

            button1.Enabled = true;

            MessageBox.Show("Your text was hidden in the image successfully!", "Done");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Bitmap Image (.bmp)|*.bmp";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxMainImg.Image.Save(sfd.FileName, ImageFormat.Bmp);
            }
        }
    }
}
