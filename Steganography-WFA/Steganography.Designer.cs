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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnHideText = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.textBoxHiddenText = new System.Windows.Forms.TextBox();
            this.pictureBoxImg = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExtractText = new System.Windows.Forms.Button();
            this.btnBrowseHiddenText = new System.Windows.Forms.Button();
            this.textBoxExtractedText = new System.Windows.Forms.TextBox();
            this.pictureBoxHiddenText = new System.Windows.Forms.PictureBox();
            this.btnSaveHidden = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.buttonBrowseHidden = new System.Windows.Forms.Button();
            this.btnBrowseOrig = new System.Windows.Forms.Button();
            this.pictureBoxImgHidden = new System.Windows.Forms.PictureBox();
            this.pictureBoxImgOrig = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSaveHiddenImg = new System.Windows.Forms.Button();
            this.btnExtractImg = new System.Windows.Forms.Button();
            this.btnBrowseHiddenImg = new System.Windows.Forms.Button();
            this.pictureBoxExtracted = new System.Windows.Forms.PictureBox();
            this.pictureBoxEncrypted = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHiddenText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgHidden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgOrig)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExtracted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncrypted)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 535);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(240, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(19, 118);
            this.panel3.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkKhaki;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 417);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(233, 118);
            this.button4.TabIndex = 4;
            this.button4.Text = "Extract Image";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkKhaki;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(0, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(233, 118);
            this.button3.TabIndex = 3;
            this.button3.Text = "Extract Text";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkKhaki;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 118);
            this.button2.TabIndex = 2;
            this.button2.Text = "Hide Image";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkKhaki;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 118);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hide Text";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 63);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image Steganography";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Location = new System.Drawing.Point(239, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(19, 116);
            this.panel4.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnHideText);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.textBoxHiddenText);
            this.groupBox1.Controls.Add(this.pictureBoxImg);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(295, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 481);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hide Text";
            this.groupBox1.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(444, 355);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(187, 38);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save Image";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnHideText
            // 
            this.btnHideText.BackColor = System.Drawing.Color.SeaGreen;
            this.btnHideText.Enabled = false;
            this.btnHideText.Location = new System.Drawing.Point(444, 291);
            this.btnHideText.Name = "btnHideText";
            this.btnHideText.Size = new System.Drawing.Size(187, 38);
            this.btnHideText.TabIndex = 3;
            this.btnHideText.Text = "Hide Text";
            this.btnHideText.UseVisualStyleBackColor = false;
            this.btnHideText.Click += new System.EventHandler(this.btnHideText_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.SeaGreen;
            this.btnBrowse.Location = new System.Drawing.Point(119, 291);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(187, 38);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // textBoxHiddenText
            // 
            this.textBoxHiddenText.Location = new System.Drawing.Point(380, 41);
            this.textBoxHiddenText.Multiline = true;
            this.textBoxHiddenText.Name = "textBoxHiddenText";
            this.textBoxHiddenText.Size = new System.Drawing.Size(320, 235);
            this.textBoxHiddenText.TabIndex = 1;
            // 
            // pictureBoxImg
            // 
            this.pictureBoxImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxImg.Location = new System.Drawing.Point(52, 41);
            this.pictureBoxImg.Name = "pictureBoxImg";
            this.pictureBoxImg.Size = new System.Drawing.Size(303, 234);
            this.pictureBoxImg.TabIndex = 0;
            this.pictureBoxImg.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSaveHidden);
            this.groupBox2.Controls.Add(this.btnGenerate);
            this.groupBox2.Controls.Add(this.pictureBoxResult);
            this.groupBox2.Controls.Add(this.buttonBrowseHidden);
            this.groupBox2.Controls.Add(this.btnBrowseOrig);
            this.groupBox2.Controls.Add(this.pictureBoxImgHidden);
            this.groupBox2.Controls.Add(this.pictureBoxImgOrig);
            this.groupBox2.Location = new System.Drawing.Point(289, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(743, 481);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hide Image";
            this.groupBox2.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExtractText);
            this.groupBox3.Controls.Add(this.btnBrowseHiddenText);
            this.groupBox3.Controls.Add(this.textBoxExtractedText);
            this.groupBox3.Controls.Add(this.pictureBoxHiddenText);
            this.groupBox3.Location = new System.Drawing.Point(283, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(743, 481);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Extract Text";
            this.groupBox3.Visible = false;
            // 
            // btnExtractText
            // 
            this.btnExtractText.BackColor = System.Drawing.Color.SeaGreen;
            this.btnExtractText.Enabled = false;
            this.btnExtractText.Location = new System.Drawing.Point(456, 291);
            this.btnExtractText.Name = "btnExtractText";
            this.btnExtractText.Size = new System.Drawing.Size(161, 40);
            this.btnExtractText.TabIndex = 3;
            this.btnExtractText.Text = "ExtractText";
            this.btnExtractText.UseVisualStyleBackColor = false;
            this.btnExtractText.Click += new System.EventHandler(this.btnExtractText_Click);
            // 
            // btnBrowseHiddenText
            // 
            this.btnBrowseHiddenText.BackColor = System.Drawing.Color.SeaGreen;
            this.btnBrowseHiddenText.Location = new System.Drawing.Point(131, 291);
            this.btnBrowseHiddenText.Name = "btnBrowseHiddenText";
            this.btnBrowseHiddenText.Size = new System.Drawing.Size(161, 40);
            this.btnBrowseHiddenText.TabIndex = 2;
            this.btnBrowseHiddenText.Text = "Browse";
            this.btnBrowseHiddenText.UseVisualStyleBackColor = false;
            this.btnBrowseHiddenText.Click += new System.EventHandler(this.btnBrowseHiddenText_Click);
            // 
            // textBoxExtractedText
            // 
            this.textBoxExtractedText.Location = new System.Drawing.Point(380, 45);
            this.textBoxExtractedText.Multiline = true;
            this.textBoxExtractedText.Name = "textBoxExtractedText";
            this.textBoxExtractedText.Size = new System.Drawing.Size(320, 230);
            this.textBoxExtractedText.TabIndex = 1;
            // 
            // pictureBoxHiddenText
            // 
            this.pictureBoxHiddenText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxHiddenText.Location = new System.Drawing.Point(64, 45);
            this.pictureBoxHiddenText.Name = "pictureBoxHiddenText";
            this.pictureBoxHiddenText.Size = new System.Drawing.Size(290, 230);
            this.pictureBoxHiddenText.TabIndex = 0;
            this.pictureBoxHiddenText.TabStop = false;
            // 
            // btnSaveHidden
            // 
            this.btnSaveHidden.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSaveHidden.Enabled = false;
            this.btnSaveHidden.Location = new System.Drawing.Point(362, 367);
            this.btnSaveHidden.Name = "btnSaveHidden";
            this.btnSaveHidden.Size = new System.Drawing.Size(161, 40);
            this.btnSaveHidden.TabIndex = 6;
            this.btnSaveHidden.Text = "Save";
            this.btnSaveHidden.UseVisualStyleBackColor = false;
            this.btnSaveHidden.Click += new System.EventHandler(this.btnSaveHidden_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGenerate.Enabled = false;
            this.btnGenerate.Location = new System.Drawing.Point(362, 310);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(161, 40);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxResult.Location = new System.Drawing.Point(70, 275);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(252, 183);
            this.pictureBoxResult.TabIndex = 4;
            this.pictureBoxResult.TabStop = false;
            // 
            // buttonBrowseHidden
            // 
            this.buttonBrowseHidden.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonBrowseHidden.Enabled = false;
            this.buttonBrowseHidden.Location = new System.Drawing.Point(444, 211);
            this.buttonBrowseHidden.Name = "buttonBrowseHidden";
            this.buttonBrowseHidden.Size = new System.Drawing.Size(161, 40);
            this.buttonBrowseHidden.TabIndex = 3;
            this.buttonBrowseHidden.Text = "Browse";
            this.buttonBrowseHidden.UseVisualStyleBackColor = false;
            this.buttonBrowseHidden.Click += new System.EventHandler(this.buttonBrowseHidden_Click_1);
            // 
            // btnBrowseOrig
            // 
            this.btnBrowseOrig.BackColor = System.Drawing.Color.SeaGreen;
            this.btnBrowseOrig.Location = new System.Drawing.Point(119, 211);
            this.btnBrowseOrig.Name = "btnBrowseOrig";
            this.btnBrowseOrig.Size = new System.Drawing.Size(161, 40);
            this.btnBrowseOrig.TabIndex = 2;
            this.btnBrowseOrig.Text = "Browse";
            this.btnBrowseOrig.UseVisualStyleBackColor = false;
            this.btnBrowseOrig.Click += new System.EventHandler(this.btnBrowseOrig_Click);
            // 
            // pictureBoxImgHidden
            // 
            this.pictureBoxImgHidden.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxImgHidden.Location = new System.Drawing.Point(404, 28);
            this.pictureBoxImgHidden.Name = "pictureBoxImgHidden";
            this.pictureBoxImgHidden.Size = new System.Drawing.Size(257, 178);
            this.pictureBoxImgHidden.TabIndex = 1;
            this.pictureBoxImgHidden.TabStop = false;
            // 
            // pictureBoxImgOrig
            // 
            this.pictureBoxImgOrig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxImgOrig.Location = new System.Drawing.Point(75, 28);
            this.pictureBoxImgOrig.Name = "pictureBoxImgOrig";
            this.pictureBoxImgOrig.Size = new System.Drawing.Size(247, 178);
            this.pictureBoxImgOrig.TabIndex = 0;
            this.pictureBoxImgOrig.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSaveHiddenImg);
            this.groupBox4.Controls.Add(this.btnExtractImg);
            this.groupBox4.Controls.Add(this.btnBrowseHiddenImg);
            this.groupBox4.Controls.Add(this.pictureBoxExtracted);
            this.groupBox4.Controls.Add(this.pictureBoxEncrypted);
            this.groupBox4.Location = new System.Drawing.Point(283, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(743, 481);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Extract Image";
            this.groupBox4.Visible = false;
            // 
            // btnSaveHiddenImg
            // 
            this.btnSaveHiddenImg.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSaveHiddenImg.Enabled = false;
            this.btnSaveHiddenImg.Location = new System.Drawing.Point(456, 376);
            this.btnSaveHiddenImg.Name = "btnSaveHiddenImg";
            this.btnSaveHiddenImg.Size = new System.Drawing.Size(173, 51);
            this.btnSaveHiddenImg.TabIndex = 4;
            this.btnSaveHiddenImg.Text = "Save";
            this.btnSaveHiddenImg.UseVisualStyleBackColor = false;
            this.btnSaveHiddenImg.Click += new System.EventHandler(this.btnSaveHiddenImg_Click);
            // 
            // btnExtractImg
            // 
            this.btnExtractImg.BackColor = System.Drawing.Color.SeaGreen;
            this.btnExtractImg.Enabled = false;
            this.btnExtractImg.Location = new System.Drawing.Point(456, 305);
            this.btnExtractImg.Name = "btnExtractImg";
            this.btnExtractImg.Size = new System.Drawing.Size(173, 51);
            this.btnExtractImg.TabIndex = 3;
            this.btnExtractImg.Text = "Extract Image";
            this.btnExtractImg.UseVisualStyleBackColor = false;
            this.btnExtractImg.Click += new System.EventHandler(this.btnExtractImg_Click);
            // 
            // btnBrowseHiddenImg
            // 
            this.btnBrowseHiddenImg.BackColor = System.Drawing.Color.SeaGreen;
            this.btnBrowseHiddenImg.Location = new System.Drawing.Point(119, 305);
            this.btnBrowseHiddenImg.Name = "btnBrowseHiddenImg";
            this.btnBrowseHiddenImg.Size = new System.Drawing.Size(173, 51);
            this.btnBrowseHiddenImg.TabIndex = 2;
            this.btnBrowseHiddenImg.Text = "Browse";
            this.btnBrowseHiddenImg.UseVisualStyleBackColor = false;
            this.btnBrowseHiddenImg.Click += new System.EventHandler(this.btnBrowseHiddenImg_Click);
            // 
            // pictureBoxExtracted
            // 
            this.pictureBoxExtracted.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxExtracted.Location = new System.Drawing.Point(393, 45);
            this.pictureBoxExtracted.Name = "pictureBoxExtracted";
            this.pictureBoxExtracted.Size = new System.Drawing.Size(295, 246);
            this.pictureBoxExtracted.TabIndex = 1;
            this.pictureBoxExtracted.TabStop = false;
            // 
            // pictureBoxEncrypted
            // 
            this.pictureBoxEncrypted.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxEncrypted.Location = new System.Drawing.Point(52, 45);
            this.pictureBoxEncrypted.Name = "pictureBoxEncrypted";
            this.pictureBoxEncrypted.Size = new System.Drawing.Size(295, 246);
            this.pictureBoxEncrypted.TabIndex = 0;
            this.pictureBoxEncrypted.TabStop = false;
            // 
            // Steganography
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1069, 535);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Gotham", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Steganography";
            this.Text = "Image Steganography - Nikol Paraskova";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHiddenText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgHidden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgOrig)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExtracted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncrypted)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxHiddenText;
        private System.Windows.Forms.PictureBox pictureBoxImg;
        private System.Windows.Forms.Button btnHideText;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonBrowseHidden;
        private System.Windows.Forms.Button btnBrowseOrig;
        private System.Windows.Forms.PictureBox pictureBoxImgHidden;
        private System.Windows.Forms.PictureBox pictureBoxImgOrig;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.Button btnSaveHidden;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExtractText;
        private System.Windows.Forms.Button btnBrowseHiddenText;
        private System.Windows.Forms.TextBox textBoxExtractedText;
        private System.Windows.Forms.PictureBox pictureBoxHiddenText;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBrowseHiddenImg;
        private System.Windows.Forms.PictureBox pictureBoxExtracted;
        private System.Windows.Forms.PictureBox pictureBoxEncrypted;
        private System.Windows.Forms.Button btnSaveHiddenImg;
        private System.Windows.Forms.Button btnExtractImg;
        private System.Windows.Forms.Label label1;
    }
}

