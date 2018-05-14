namespace Steganography_WFA
{
    partial class Steganography
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxHome = new System.Windows.Forms.GroupBox();
            this.buttonHomeHideImage = new System.Windows.Forms.Button();
            this.groupBoxDecryptImg = new System.Windows.Forms.GroupBox();
            this.buttonSaveExtracted = new System.Windows.Forms.Button();
            this.groupBoxHideImage = new System.Windows.Forms.GroupBox();
            this.buttonSaveGeneratedImage = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxResultImage = new System.Windows.Forms.PictureBox();
            this.labelSelectHidden = new System.Windows.Forms.Label();
            this.labelSelectMain = new System.Windows.Forms.Label();
            this.buttonBrowseHidden = new System.Windows.Forms.Button();
            this.pictureBoxHiddenImage = new System.Windows.Forms.PictureBox();
            this.buttonGenerateHiddenImage = new System.Windows.Forms.Button();
            this.buttonBrowseMain = new System.Windows.Forms.Button();
            this.pictureBoxMainImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxExtractedImg = new System.Windows.Forms.PictureBox();
            this.labelSelectDecryptImg = new System.Windows.Forms.Label();
            this.buttonGenerateDecrypted = new System.Windows.Forms.Button();
            this.buttonBrowseDecrypt = new System.Windows.Forms.Button();
            this.pictureDecryptImg = new System.Windows.Forms.PictureBox();
            this.buttonHomeHideText = new System.Windows.Forms.Button();
            this.groupBoxHideText = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonGenerateImage = new System.Windows.Forms.Button();
            this.labelTextToHide = new System.Windows.Forms.Label();
            this.textBoxHiddenText = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.pictureBoxMainImg = new System.Windows.Forms.PictureBox();
            this.groupBoxExtractText = new System.Windows.Forms.GroupBox();
            this.buttonExtractText = new System.Windows.Forms.Button();
            this.labelHiddenText = new System.Windows.Forms.Label();
            this.textBoxExtractedText = new System.Windows.Forms.TextBox();
            this.browseExtractText = new System.Windows.Forms.Button();
            this.pictureBoxExtractTextImg = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBoxHome.SuspendLayout();
            this.groupBoxDecryptImg.SuspendLayout();
            this.groupBoxHideImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResultImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHiddenImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExtractedImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDecryptImg)).BeginInit();
            this.groupBoxHideText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainImg)).BeginInit();
            this.groupBoxExtractText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExtractTextImg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxHome
            // 
            this.groupBoxHome.Controls.Add(this.button3);
            this.groupBoxHome.Controls.Add(this.button2);
            this.groupBoxHome.Controls.Add(this.buttonHomeHideImage);
            this.groupBoxHome.Controls.Add(this.buttonHomeHideText);
            this.groupBoxHome.Location = new System.Drawing.Point(12, 12);
            this.groupBoxHome.Name = "groupBoxHome";
            this.groupBoxHome.Size = new System.Drawing.Size(501, 847);
            this.groupBoxHome.TabIndex = 0;
            this.groupBoxHome.TabStop = false;
            this.groupBoxHome.Text = "Home";
            // 
            // buttonHomeHideImage
            // 
            this.buttonHomeHideImage.Location = new System.Drawing.Point(135, 372);
            this.buttonHomeHideImage.Name = "buttonHomeHideImage";
            this.buttonHomeHideImage.Size = new System.Drawing.Size(201, 50);
            this.buttonHomeHideImage.TabIndex = 1;
            this.buttonHomeHideImage.Text = "Hide Image";
            this.buttonHomeHideImage.UseVisualStyleBackColor = true;
            // 
            // groupBoxDecryptImg
            // 
            this.groupBoxDecryptImg.Controls.Add(this.buttonSaveExtracted);
            this.groupBoxDecryptImg.Controls.Add(this.label1);
            this.groupBoxDecryptImg.Controls.Add(this.pictureBoxExtractedImg);
            this.groupBoxDecryptImg.Controls.Add(this.labelSelectDecryptImg);
            this.groupBoxDecryptImg.Controls.Add(this.buttonGenerateDecrypted);
            this.groupBoxDecryptImg.Controls.Add(this.buttonBrowseDecrypt);
            this.groupBoxDecryptImg.Controls.Add(this.pictureDecryptImg);
            this.groupBoxDecryptImg.Location = new System.Drawing.Point(108, 64);
            this.groupBoxDecryptImg.Name = "groupBoxDecryptImg";
            this.groupBoxDecryptImg.Size = new System.Drawing.Size(501, 847);
            this.groupBoxDecryptImg.TabIndex = 19;
            this.groupBoxDecryptImg.TabStop = false;
            this.groupBoxDecryptImg.Text = "Decrypt Image";
            // 
            // buttonSaveExtracted
            // 
            this.buttonSaveExtracted.Enabled = false;
            this.buttonSaveExtracted.Location = new System.Drawing.Point(149, 754);
            this.buttonSaveExtracted.Name = "buttonSaveExtracted";
            this.buttonSaveExtracted.Size = new System.Drawing.Size(201, 50);
            this.buttonSaveExtracted.TabIndex = 18;
            this.buttonSaveExtracted.Text = "Save new image";
            this.buttonSaveExtracted.UseVisualStyleBackColor = true;
            this.buttonSaveExtracted.Click += new System.EventHandler(this.buttonSaveExtracted_Click);
            // 
            // groupBoxHideImage
            // 
            this.groupBoxHideImage.Controls.Add(this.buttonSaveGeneratedImage);
            this.groupBoxHideImage.Controls.Add(this.groupBoxDecryptImg);
            this.groupBoxHideImage.Controls.Add(this.label5);
            this.groupBoxHideImage.Controls.Add(this.pictureBoxResultImage);
            this.groupBoxHideImage.Controls.Add(this.labelSelectHidden);
            this.groupBoxHideImage.Controls.Add(this.labelSelectMain);
            this.groupBoxHideImage.Controls.Add(this.buttonBrowseHidden);
            this.groupBoxHideImage.Controls.Add(this.pictureBoxHiddenImage);
            this.groupBoxHideImage.Controls.Add(this.buttonGenerateHiddenImage);
            this.groupBoxHideImage.Controls.Add(this.buttonBrowseMain);
            this.groupBoxHideImage.Controls.Add(this.pictureBoxMainImage);
            this.groupBoxHideImage.Location = new System.Drawing.Point(22, 48);
            this.groupBoxHideImage.Name = "groupBoxHideImage";
            this.groupBoxHideImage.Size = new System.Drawing.Size(501, 847);
            this.groupBoxHideImage.TabIndex = 12;
            this.groupBoxHideImage.TabStop = false;
            this.groupBoxHideImage.Text = "Hide Image";
            // 
            // buttonSaveGeneratedImage
            // 
            this.buttonSaveGeneratedImage.Location = new System.Drawing.Point(149, 754);
            this.buttonSaveGeneratedImage.Name = "buttonSaveGeneratedImage";
            this.buttonSaveGeneratedImage.Size = new System.Drawing.Size(201, 50);
            this.buttonSaveGeneratedImage.TabIndex = 18;
            this.buttonSaveGeneratedImage.Text = "Save new image";
            this.buttonSaveGeneratedImage.UseVisualStyleBackColor = true;
            this.buttonSaveGeneratedImage.Click += new System.EventHandler(this.buttonSaveGeneratedImage_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 524);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Result";
            // 
            // pictureBoxResultImage
            // 
            this.pictureBoxResultImage.Location = new System.Drawing.Point(136, 540);
            this.pictureBoxResultImage.Name = "pictureBoxResultImage";
            this.pictureBoxResultImage.Size = new System.Drawing.Size(229, 208);
            this.pictureBoxResultImage.TabIndex = 16;
            this.pictureBoxResultImage.TabStop = false;
            // 
            // labelSelectHidden
            // 
            this.labelSelectHidden.AutoSize = true;
            this.labelSelectHidden.Location = new System.Drawing.Point(294, 48);
            this.labelSelectHidden.Name = "labelSelectHidden";
            this.labelSelectHidden.Size = new System.Drawing.Size(130, 13);
            this.labelSelectHidden.TabIndex = 15;
            this.labelSelectHidden.Text = "Select image to be hidden";
            // 
            // labelSelectMain
            // 
            this.labelSelectMain.AutoSize = true;
            this.labelSelectMain.Location = new System.Drawing.Point(88, 48);
            this.labelSelectMain.Name = "labelSelectMain";
            this.labelSelectMain.Size = new System.Drawing.Size(93, 13);
            this.labelSelectMain.TabIndex = 14;
            this.labelSelectMain.Text = "Select main image";
            // 
            // buttonBrowseHidden
            // 
            this.buttonBrowseHidden.Enabled = false;
            this.buttonBrowseHidden.Location = new System.Drawing.Point(294, 278);
            this.buttonBrowseHidden.Name = "buttonBrowseHidden";
            this.buttonBrowseHidden.Size = new System.Drawing.Size(148, 42);
            this.buttonBrowseHidden.TabIndex = 13;
            this.buttonBrowseHidden.Text = "Browse";
            this.buttonBrowseHidden.UseVisualStyleBackColor = true;
            this.buttonBrowseHidden.Click += new System.EventHandler(this.buttonBrowseHidden_Click);
            // 
            // pictureBoxHiddenImage
            // 
            this.pictureBoxHiddenImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxHiddenImage.Location = new System.Drawing.Point(253, 64);
            this.pictureBoxHiddenImage.Name = "pictureBoxHiddenImage";
            this.pictureBoxHiddenImage.Size = new System.Drawing.Size(227, 208);
            this.pictureBoxHiddenImage.TabIndex = 12;
            this.pictureBoxHiddenImage.TabStop = false;
            // 
            // buttonGenerateHiddenImage
            // 
            this.buttonGenerateHiddenImage.Location = new System.Drawing.Point(149, 436);
            this.buttonGenerateHiddenImage.Name = "buttonGenerateHiddenImage";
            this.buttonGenerateHiddenImage.Size = new System.Drawing.Size(201, 50);
            this.buttonGenerateHiddenImage.TabIndex = 11;
            this.buttonGenerateHiddenImage.Text = "Generate Image";
            this.buttonGenerateHiddenImage.UseVisualStyleBackColor = true;
            this.buttonGenerateHiddenImage.Click += new System.EventHandler(this.buttonGenerateHiddenImage_Click);
            // 
            // buttonBrowseMain
            // 
            this.buttonBrowseMain.Location = new System.Drawing.Point(63, 278);
            this.buttonBrowseMain.Name = "buttonBrowseMain";
            this.buttonBrowseMain.Size = new System.Drawing.Size(148, 39);
            this.buttonBrowseMain.TabIndex = 2;
            this.buttonBrowseMain.Text = "Browse";
            this.buttonBrowseMain.UseVisualStyleBackColor = true;
            this.buttonBrowseMain.Click += new System.EventHandler(this.buttonBrowseMain_Click);
            // 
            // pictureBoxMainImage
            // 
            this.pictureBoxMainImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMainImage.Location = new System.Drawing.Point(18, 64);
            this.pictureBoxMainImage.Name = "pictureBoxMainImage";
            this.pictureBoxMainImage.Size = new System.Drawing.Size(229, 208);
            this.pictureBoxMainImage.TabIndex = 0;
            this.pictureBoxMainImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Result";
            // 
            // pictureBoxExtractedImg
            // 
            this.pictureBoxExtractedImg.Location = new System.Drawing.Point(136, 540);
            this.pictureBoxExtractedImg.Name = "pictureBoxExtractedImg";
            this.pictureBoxExtractedImg.Size = new System.Drawing.Size(229, 208);
            this.pictureBoxExtractedImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExtractedImg.TabIndex = 16;
            this.pictureBoxExtractedImg.TabStop = false;
            // 
            // labelSelectDecryptImg
            // 
            this.labelSelectDecryptImg.AutoSize = true;
            this.labelSelectDecryptImg.Location = new System.Drawing.Point(175, 48);
            this.labelSelectDecryptImg.Name = "labelSelectDecryptImg";
            this.labelSelectDecryptImg.Size = new System.Drawing.Size(145, 13);
            this.labelSelectDecryptImg.TabIndex = 14;
            this.labelSelectDecryptImg.Text = "Select image to be decrypted";
            // 
            // buttonGenerateDecrypted
            // 
            this.buttonGenerateDecrypted.Location = new System.Drawing.Point(149, 436);
            this.buttonGenerateDecrypted.Name = "buttonGenerateDecrypted";
            this.buttonGenerateDecrypted.Size = new System.Drawing.Size(201, 50);
            this.buttonGenerateDecrypted.TabIndex = 11;
            this.buttonGenerateDecrypted.Text = "Generate Image";
            this.buttonGenerateDecrypted.UseVisualStyleBackColor = true;
            this.buttonGenerateDecrypted.Click += new System.EventHandler(this.buttonGenerateDecrypted_Click);
            // 
            // buttonBrowseDecrypt
            // 
            this.buttonBrowseDecrypt.Location = new System.Drawing.Point(178, 278);
            this.buttonBrowseDecrypt.Name = "buttonBrowseDecrypt";
            this.buttonBrowseDecrypt.Size = new System.Drawing.Size(148, 39);
            this.buttonBrowseDecrypt.TabIndex = 2;
            this.buttonBrowseDecrypt.Text = "Browse";
            this.buttonBrowseDecrypt.UseVisualStyleBackColor = true;
            this.buttonBrowseDecrypt.Click += new System.EventHandler(this.buttonBrowseDecrypt_Click);
            // 
            // pictureDecryptImg
            // 
            this.pictureDecryptImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureDecryptImg.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureDecryptImg.Location = new System.Drawing.Point(136, 64);
            this.pictureDecryptImg.Name = "pictureDecryptImg";
            this.pictureDecryptImg.Size = new System.Drawing.Size(229, 208);
            this.pictureDecryptImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDecryptImg.TabIndex = 0;
            this.pictureDecryptImg.TabStop = false;
            // 
            // buttonHomeHideText
            // 
            this.buttonHomeHideText.Location = new System.Drawing.Point(135, 303);
            this.buttonHomeHideText.Name = "buttonHomeHideText";
            this.buttonHomeHideText.Size = new System.Drawing.Size(201, 50);
            this.buttonHomeHideText.TabIndex = 0;
            this.buttonHomeHideText.Text = "Hide Text";
            this.buttonHomeHideText.UseVisualStyleBackColor = true;
            // 
            // groupBoxHideText
            // 
            this.groupBoxHideText.Controls.Add(this.button1);
            this.groupBoxHideText.Controls.Add(this.groupBoxHideImage);
            this.groupBoxHideText.Controls.Add(this.buttonGenerateImage);
            this.groupBoxHideText.Controls.Add(this.labelTextToHide);
            this.groupBoxHideText.Controls.Add(this.textBoxHiddenText);
            this.groupBoxHideText.Controls.Add(this.buttonBrowse);
            this.groupBoxHideText.Controls.Add(this.pictureBoxMainImg);
            this.groupBoxHideText.Location = new System.Drawing.Point(592, 12);
            this.groupBoxHideText.Name = "groupBoxHideText";
            this.groupBoxHideText.Size = new System.Drawing.Size(501, 847);
            this.groupBoxHideText.TabIndex = 2;
            this.groupBoxHideText.TabStop = false;
            this.groupBoxHideText.Text = "Hide Text";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(139, 769);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 50);
            this.button1.TabIndex = 12;
            this.button1.Text = "Save Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonGenerateImage
            // 
            this.buttonGenerateImage.Enabled = false;
            this.buttonGenerateImage.Location = new System.Drawing.Point(139, 653);
            this.buttonGenerateImage.Name = "buttonGenerateImage";
            this.buttonGenerateImage.Size = new System.Drawing.Size(201, 50);
            this.buttonGenerateImage.TabIndex = 11;
            this.buttonGenerateImage.Text = "Generate Image";
            this.buttonGenerateImage.UseVisualStyleBackColor = true;
            this.buttonGenerateImage.Click += new System.EventHandler(this.buttonGenerateImage_Click);
            // 
            // labelTextToHide
            // 
            this.labelTextToHide.AutoSize = true;
            this.labelTextToHide.Location = new System.Drawing.Point(112, 358);
            this.labelTextToHide.Name = "labelTextToHide";
            this.labelTextToHide.Size = new System.Drawing.Size(90, 13);
            this.labelTextToHide.TabIndex = 4;
            this.labelTextToHide.Text = "Enter text to hide:";
            // 
            // textBoxHiddenText
            // 
            this.textBoxHiddenText.Location = new System.Drawing.Point(115, 383);
            this.textBoxHiddenText.Multiline = true;
            this.textBoxHiddenText.Name = "textBoxHiddenText";
            this.textBoxHiddenText.Size = new System.Drawing.Size(255, 237);
            this.textBoxHiddenText.TabIndex = 3;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(139, 288);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(201, 50);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Browse Image";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // pictureBoxMainImg
            // 
            this.pictureBoxMainImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMainImg.Location = new System.Drawing.Point(115, 35);
            this.pictureBoxMainImg.Name = "pictureBoxMainImg";
            this.pictureBoxMainImg.Size = new System.Drawing.Size(255, 237);
            this.pictureBoxMainImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMainImg.TabIndex = 0;
            this.pictureBoxMainImg.TabStop = false;
            // 
            // groupBoxExtractText
            // 
            this.groupBoxExtractText.Controls.Add(this.buttonExtractText);
            this.groupBoxExtractText.Controls.Add(this.labelHiddenText);
            this.groupBoxExtractText.Controls.Add(this.textBoxExtractedText);
            this.groupBoxExtractText.Controls.Add(this.browseExtractText);
            this.groupBoxExtractText.Controls.Add(this.pictureBoxExtractTextImg);
            this.groupBoxExtractText.Location = new System.Drawing.Point(1169, 12);
            this.groupBoxExtractText.Name = "groupBoxExtractText";
            this.groupBoxExtractText.Size = new System.Drawing.Size(501, 847);
            this.groupBoxExtractText.TabIndex = 21;
            this.groupBoxExtractText.TabStop = false;
            this.groupBoxExtractText.Text = "Extract Text";
            // 
            // buttonExtractText
            // 
            this.buttonExtractText.Enabled = false;
            this.buttonExtractText.Location = new System.Drawing.Point(139, 418);
            this.buttonExtractText.Name = "buttonExtractText";
            this.buttonExtractText.Size = new System.Drawing.Size(201, 50);
            this.buttonExtractText.TabIndex = 11;
            this.buttonExtractText.Text = "Extraxt Text";
            this.buttonExtractText.UseVisualStyleBackColor = true;
            this.buttonExtractText.Click += new System.EventHandler(this.buttonExtractText_Click);
            // 
            // labelHiddenText
            // 
            this.labelHiddenText.AutoSize = true;
            this.labelHiddenText.Location = new System.Drawing.Point(60, 487);
            this.labelHiddenText.Name = "labelHiddenText";
            this.labelHiddenText.Size = new System.Drawing.Size(64, 13);
            this.labelHiddenText.TabIndex = 4;
            this.labelHiddenText.Text = "Hidden text:";
            // 
            // textBoxExtractedText
            // 
            this.textBoxExtractedText.Location = new System.Drawing.Point(63, 506);
            this.textBoxExtractedText.Multiline = true;
            this.textBoxExtractedText.Name = "textBoxExtractedText";
            this.textBoxExtractedText.Size = new System.Drawing.Size(366, 298);
            this.textBoxExtractedText.TabIndex = 3;
            // 
            // browseExtractText
            // 
            this.browseExtractText.Location = new System.Drawing.Point(139, 344);
            this.browseExtractText.Name = "browseExtractText";
            this.browseExtractText.Size = new System.Drawing.Size(201, 50);
            this.browseExtractText.TabIndex = 2;
            this.browseExtractText.Text = "Browse Image";
            this.browseExtractText.UseVisualStyleBackColor = true;
            this.browseExtractText.Click += new System.EventHandler(this.browseExtractText_Click);
            // 
            // pictureBoxExtractTextImg
            // 
            this.pictureBoxExtractTextImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxExtractTextImg.Location = new System.Drawing.Point(63, 35);
            this.pictureBoxExtractTextImg.Name = "pictureBoxExtractTextImg";
            this.pictureBoxExtractTextImg.Size = new System.Drawing.Size(366, 303);
            this.pictureBoxExtractTextImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExtractTextImg.TabIndex = 0;
            this.pictureBoxExtractTextImg.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Hide Image";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(135, 506);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "Hide Image";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Steganography
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 992);
            this.Controls.Add(this.groupBoxExtractText);
            this.Controls.Add(this.groupBoxHideText);
            this.Controls.Add(this.groupBoxHome);
            this.Name = "Steganography";
            this.Text = "Form1";
            this.groupBoxHome.ResumeLayout(false);
            this.groupBoxDecryptImg.ResumeLayout(false);
            this.groupBoxDecryptImg.PerformLayout();
            this.groupBoxHideImage.ResumeLayout(false);
            this.groupBoxHideImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResultImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHiddenImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExtractedImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDecryptImg)).EndInit();
            this.groupBoxHideText.ResumeLayout(false);
            this.groupBoxHideText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainImg)).EndInit();
            this.groupBoxExtractText.ResumeLayout(false);
            this.groupBoxExtractText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExtractTextImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxHome;
        private System.Windows.Forms.Button buttonHomeHideImage;
        private System.Windows.Forms.Button buttonHomeHideText;
        private System.Windows.Forms.GroupBox groupBoxHideText;
        private System.Windows.Forms.Button buttonGenerateImage;
        private System.Windows.Forms.Label labelTextToHide;
        private System.Windows.Forms.TextBox textBoxHiddenText;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.PictureBox pictureBoxMainImg;
        private System.Windows.Forms.GroupBox groupBoxDecryptImg;
        private System.Windows.Forms.Button buttonSaveExtracted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxExtractedImg;
        private System.Windows.Forms.Label labelSelectDecryptImg;
        private System.Windows.Forms.Button buttonGenerateDecrypted;
        private System.Windows.Forms.Button buttonBrowseDecrypt;
        private System.Windows.Forms.PictureBox pictureDecryptImg;
        private System.Windows.Forms.PictureBox pictureBoxMainImage;
        private System.Windows.Forms.Button buttonBrowseMain;
        private System.Windows.Forms.Button buttonGenerateHiddenImage;
        private System.Windows.Forms.Label labelSelectMain;
        private System.Windows.Forms.PictureBox pictureBoxResultImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSaveGeneratedImage;
        private System.Windows.Forms.GroupBox groupBoxHideImage;
        private System.Windows.Forms.Label labelSelectHidden;
        private System.Windows.Forms.Button buttonBrowseHidden;
        private System.Windows.Forms.PictureBox pictureBoxHiddenImage;
        private System.Windows.Forms.GroupBox groupBoxExtractText;
        private System.Windows.Forms.Button buttonExtractText;
        private System.Windows.Forms.Label labelHiddenText;
        private System.Windows.Forms.TextBox textBoxExtractedText;
        private System.Windows.Forms.Button browseExtractText;
        private System.Windows.Forms.PictureBox pictureBoxExtractTextImg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

