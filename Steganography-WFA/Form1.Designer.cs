namespace Steganography_WFA
{
    partial class Form1
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
            this.buttonHomeHideText = new System.Windows.Forms.Button();
            this.groupBoxHideText = new System.Windows.Forms.GroupBox();
            this.buttonGenerateImage = new System.Windows.Forms.Button();
            this.groupBoxEncryption = new System.Windows.Forms.GroupBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.encryptCheckBox = new System.Windows.Forms.CheckBox();
            this.labelTextToHide = new System.Windows.Forms.Label();
            this.textBoxHiddenText = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.pictureBoxMainImg = new System.Windows.Forms.PictureBox();
            this.groupBoxHideImage = new System.Windows.Forms.GroupBox();
            this.buttonSaveGeneratedImage = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxResultImage = new System.Windows.Forms.PictureBox();
            this.labelSelectHidden = new System.Windows.Forms.Label();
            this.labelSelectMain = new System.Windows.Forms.Label();
            this.buttonBrowseHidden = new System.Windows.Forms.Button();
            this.pictureBoxHiddenImage = new System.Windows.Forms.PictureBox();
            this.buttonGenerateHiddenImage = new System.Windows.Forms.Button();
            this.groupBoxENcryptImage = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonBrowseMain = new System.Windows.Forms.Button();
            this.pictureBoxMainImage = new System.Windows.Forms.PictureBox();
            this.groupBoxHome.SuspendLayout();
            this.groupBoxHideText.SuspendLayout();
            this.groupBoxEncryption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainImg)).BeginInit();
            this.groupBoxHideImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResultImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHiddenImage)).BeginInit();
            this.groupBoxENcryptImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxHome
            // 
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
            this.buttonHomeHideImage.Location = new System.Drawing.Point(149, 436);
            this.buttonHomeHideImage.Name = "buttonHomeHideImage";
            this.buttonHomeHideImage.Size = new System.Drawing.Size(201, 50);
            this.buttonHomeHideImage.TabIndex = 1;
            this.buttonHomeHideImage.Text = "Hide Image";
            this.buttonHomeHideImage.UseVisualStyleBackColor = true;
            // 
            // buttonHomeHideText
            // 
            this.buttonHomeHideText.Location = new System.Drawing.Point(149, 339);
            this.buttonHomeHideText.Name = "buttonHomeHideText";
            this.buttonHomeHideText.Size = new System.Drawing.Size(201, 50);
            this.buttonHomeHideText.TabIndex = 0;
            this.buttonHomeHideText.Text = "Hide Text";
            this.buttonHomeHideText.UseVisualStyleBackColor = true;
            // 
            // groupBoxHideText
            // 
            this.groupBoxHideText.Controls.Add(this.buttonGenerateImage);
            this.groupBoxHideText.Controls.Add(this.groupBoxEncryption);
            this.groupBoxHideText.Controls.Add(this.labelTextToHide);
            this.groupBoxHideText.Controls.Add(this.textBoxHiddenText);
            this.groupBoxHideText.Controls.Add(this.buttonBrowse);
            this.groupBoxHideText.Controls.Add(this.pictureBoxMainImg);
            this.groupBoxHideText.Location = new System.Drawing.Point(529, 12);
            this.groupBoxHideText.Name = "groupBoxHideText";
            this.groupBoxHideText.Size = new System.Drawing.Size(501, 847);
            this.groupBoxHideText.TabIndex = 2;
            this.groupBoxHideText.TabStop = false;
            this.groupBoxHideText.Text = "Hide Text";
            // 
            // buttonGenerateImage
            // 
            this.buttonGenerateImage.Enabled = false;
            this.buttonGenerateImage.Location = new System.Drawing.Point(139, 754);
            this.buttonGenerateImage.Name = "buttonGenerateImage";
            this.buttonGenerateImage.Size = new System.Drawing.Size(201, 50);
            this.buttonGenerateImage.TabIndex = 11;
            this.buttonGenerateImage.Text = "Generate Image";
            this.buttonGenerateImage.UseVisualStyleBackColor = true;
            // 
            // groupBoxEncryption
            // 
            this.groupBoxEncryption.Controls.Add(this.labelPass);
            this.groupBoxEncryption.Controls.Add(this.passwordTextBox);
            this.groupBoxEncryption.Controls.Add(this.encryptCheckBox);
            this.groupBoxEncryption.Location = new System.Drawing.Point(57, 656);
            this.groupBoxEncryption.Name = "groupBoxEncryption";
            this.groupBoxEncryption.Size = new System.Drawing.Size(374, 64);
            this.groupBoxEncryption.TabIndex = 10;
            this.groupBoxEncryption.TabStop = false;
            this.groupBoxEncryption.Text = "Encryption";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.Location = new System.Drawing.Point(111, 30);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(82, 20);
            this.labelPass.TabIndex = 8;
            this.labelPass.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(195, 27);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(173, 26);
            this.passwordTextBox.TabIndex = 7;
            // 
            // encryptCheckBox
            // 
            this.encryptCheckBox.AutoSize = true;
            this.encryptCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptCheckBox.Location = new System.Drawing.Point(7, 29);
            this.encryptCheckBox.Name = "encryptCheckBox";
            this.encryptCheckBox.Size = new System.Drawing.Size(100, 24);
            this.encryptCheckBox.TabIndex = 6;
            this.encryptCheckBox.Text = "Encrypted";
            this.encryptCheckBox.UseVisualStyleBackColor = true;
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
            this.pictureBoxMainImg.TabIndex = 0;
            this.pictureBoxMainImg.TabStop = false;
            // 
            // groupBoxHideImage
            // 
            this.groupBoxHideImage.Controls.Add(this.buttonSaveGeneratedImage);
            this.groupBoxHideImage.Controls.Add(this.label5);
            this.groupBoxHideImage.Controls.Add(this.pictureBoxResultImage);
            this.groupBoxHideImage.Controls.Add(this.labelSelectHidden);
            this.groupBoxHideImage.Controls.Add(this.labelSelectMain);
            this.groupBoxHideImage.Controls.Add(this.buttonBrowseHidden);
            this.groupBoxHideImage.Controls.Add(this.pictureBoxHiddenImage);
            this.groupBoxHideImage.Controls.Add(this.buttonGenerateHiddenImage);
            this.groupBoxHideImage.Controls.Add(this.groupBoxENcryptImage);
            this.groupBoxHideImage.Controls.Add(this.buttonBrowseMain);
            this.groupBoxHideImage.Controls.Add(this.pictureBoxMainImage);
            this.groupBoxHideImage.Location = new System.Drawing.Point(1050, 12);
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
            // groupBoxENcryptImage
            // 
            this.groupBoxENcryptImage.Controls.Add(this.label2);
            this.groupBoxENcryptImage.Controls.Add(this.textBox2);
            this.groupBoxENcryptImage.Controls.Add(this.checkBox1);
            this.groupBoxENcryptImage.Location = new System.Drawing.Point(63, 358);
            this.groupBoxENcryptImage.Name = "groupBoxENcryptImage";
            this.groupBoxENcryptImage.Size = new System.Drawing.Size(379, 64);
            this.groupBoxENcryptImage.TabIndex = 10;
            this.groupBoxENcryptImage.TabStop = false;
            this.groupBoxENcryptImage.Text = "Encryption";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(195, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(173, 26);
            this.textBox2.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(7, 29);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 24);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Encrypted";
            this.checkBox1.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1965, 992);
            this.Controls.Add(this.groupBoxHideImage);
            this.Controls.Add(this.groupBoxHideText);
            this.Controls.Add(this.groupBoxHome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxHome.ResumeLayout(false);
            this.groupBoxHideText.ResumeLayout(false);
            this.groupBoxHideText.PerformLayout();
            this.groupBoxEncryption.ResumeLayout(false);
            this.groupBoxEncryption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainImg)).EndInit();
            this.groupBoxHideImage.ResumeLayout(false);
            this.groupBoxHideImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResultImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHiddenImage)).EndInit();
            this.groupBoxENcryptImage.ResumeLayout(false);
            this.groupBoxENcryptImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxHome;
        private System.Windows.Forms.Button buttonHomeHideImage;
        private System.Windows.Forms.Button buttonHomeHideText;
        private System.Windows.Forms.GroupBox groupBoxHideText;
        private System.Windows.Forms.Button buttonGenerateImage;
        private System.Windows.Forms.GroupBox groupBoxEncryption;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.CheckBox encryptCheckBox;
        private System.Windows.Forms.Label labelTextToHide;
        private System.Windows.Forms.TextBox textBoxHiddenText;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.PictureBox pictureBoxMainImg;
        private System.Windows.Forms.GroupBox groupBoxHideImage;
        private System.Windows.Forms.Button buttonSaveGeneratedImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxResultImage;
        private System.Windows.Forms.Label labelSelectHidden;
        private System.Windows.Forms.Label labelSelectMain;
        private System.Windows.Forms.Button buttonBrowseHidden;
        private System.Windows.Forms.PictureBox pictureBoxHiddenImage;
        private System.Windows.Forms.Button buttonGenerateHiddenImage;
        private System.Windows.Forms.GroupBox groupBoxENcryptImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonBrowseMain;
        private System.Windows.Forms.PictureBox pictureBoxMainImage;
    }
}

