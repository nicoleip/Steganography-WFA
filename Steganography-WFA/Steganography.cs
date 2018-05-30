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

            panel4.Height = button1.Height;
            panel4.Top = button1.Top;

            groupBox1.Visible = true;            
        }        

      
        /// HIDE TEXT ///

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif |JPEG Image (.jpeg)|*.jpeg |JPG Image (.jpg)|*.jpg |Png Image (.png)|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImg.ImageLocation = ofd.FileName;
                btnHideText.Enabled = true;
            }
        }

        private void btnHideText_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBoxImg.Image;
            string text = textBoxHiddenText.Text;

            bmp = SteganographyHelperText.embedText(text, bmp);

            pictureBoxImg.Image = bmp;

            btnSave.Enabled = true;

            MessageBox.Show("Your text was hidden in the image successfully!", "Done");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Bitmap Image (.bmp)|*.bmp";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImg.Image.Save(sfd.FileName, ImageFormat.Bmp);
            }
        }



        /// HIDE IMAGE ///

        private void btnBrowseOrig_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif |JPEG Image (.jpeg)|*.jpeg |JPG Image (.jpg)|*.jpg |Png Image (.png)|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImgOrig.ImageLocation = ofd.FileName;
                buttonBrowseHidden.Enabled = true;
            }
        }

        private void buttonBrowseHidden_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif |JPEG Image (.jpeg)|*.jpeg |JPG Image (.jpg)|*.jpg |Png Image (.png)|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap img = new Bitmap(ofd.FileName);
                pictureBoxImgHidden.Image = SteganographyHelperImage.toGrayscale(img);
            }

            btnGenerate.Enabled = true;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Bitmap mainImage = new Bitmap(pictureBoxImgOrig.Image);
            Bitmap hiddenImage = new Bitmap(pictureBoxImgHidden.Image);

            mainImage = SteganographyHelperImage.encryptImage(mainImage, hiddenImage);

            pictureBoxResult.Image = mainImage;

            btnSaveHidden.Enabled = true;
        }

        private void btnSaveHidden_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Bitmap Image (.bmp)|*.bmp";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxResult.Image.Save(sfd.FileName);
            }
        }

        /// EXTRACT TEXT
        

        private void btnBrowseHiddenText_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif |JPEG Image (.jpeg)|*.jpeg |JPG Image (.jpg)|*.jpg |Png Image (.png)|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxHiddenText.ImageLocation = ofd.FileName;
                btnExtractText.Enabled = true;
            }
        }

        private void btnExtractText_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBoxHiddenText.Image;

            string extractedText = SteganographyHelperText.extractText(bmp);

            textBoxExtractedText.Text = extractedText;
        }


        
        ///EXTRACT IMAGE
       
        private void btnBrowseHiddenImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|JPG Image (.jpg)|*.jpg|Png Image (.png)|*.png ";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxEncrypted.ImageLocation = ofd.FileName;
            }

            btnExtractImg.Enabled = true;
        }

        private void btnExtractImg_Click(object sender, EventArgs e)
        {
            Bitmap EncryptedImage = (Bitmap)pictureBoxEncrypted.Image;
            Bitmap hiddenImage = new Bitmap(EncryptedImage.Width, EncryptedImage.Height);

            hiddenImage = SteganographyHelperImage.decryptImage(EncryptedImage, hiddenImage);

            pictureBoxExtracted.Image = hiddenImage;
            btnSaveHiddenImg.Enabled = true;
        }

        private void btnSaveHiddenImg_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png ";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxExtracted.Image.Save(sfd.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Top = button2.Top;

            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Top = button1.Top;

            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Top = button3.Top;

            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Top = button4.Top;

            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = true;
        }
    }
}
