namespace WindowsFormsApplication_ObtainImageFromClipBoard
{
    partial class FormMain
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
            this.pB_showImg = new System.Windows.Forms.PictureBox();
            this.ShowImgFromClipBoard = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SaveToRTF = new System.Windows.Forms.Button();
            this.LoadFromRTF = new System.Windows.Forms.Button();
            this.LaunchRTF = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.totalResult = new System.Windows.Forms.Label();
            this.Results = new System.Windows.Forms.Label();
            this.RestoreFormat = new System.Windows.Forms.Button();
            this.InsertImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pB_showImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pB_showImg
            // 
            this.pB_showImg.Location = new System.Drawing.Point(12, 12);
            this.pB_showImg.Name = "pB_showImg";
            this.pB_showImg.Size = new System.Drawing.Size(290, 228);
            this.pB_showImg.TabIndex = 0;
            this.pB_showImg.TabStop = false;
            // 
            // ShowImgFromClipBoard
            // 
            this.ShowImgFromClipBoard.Location = new System.Drawing.Point(23, 271);
            this.ShowImgFromClipBoard.Name = "ShowImgFromClipBoard";
            this.ShowImgFromClipBoard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowImgFromClipBoard.Size = new System.Drawing.Size(147, 49);
            this.ShowImgFromClipBoard.TabIndex = 1;
            this.ShowImgFromClipBoard.Text = "ShowImgFromClipBoard";
            this.ShowImgFromClipBoard.UseVisualStyleBackColor = true;
            this.ShowImgFromClipBoard.Click += new System.EventHandler(this.ShowImgFromClipBoard_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(339, 48);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(695, 749);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // SaveToRTF
            // 
            this.SaveToRTF.Location = new System.Drawing.Point(619, 19);
            this.SaveToRTF.Name = "SaveToRTF";
            this.SaveToRTF.Size = new System.Drawing.Size(75, 23);
            this.SaveToRTF.TabIndex = 4;
            this.SaveToRTF.Text = "SaveToRTF";
            this.SaveToRTF.UseVisualStyleBackColor = true;
            this.SaveToRTF.Click += new System.EventHandler(this.SaveToRTF_Click);
            // 
            // LoadFromRTF
            // 
            this.LoadFromRTF.Location = new System.Drawing.Point(406, 19);
            this.LoadFromRTF.Name = "LoadFromRTF";
            this.LoadFromRTF.Size = new System.Drawing.Size(89, 23);
            this.LoadFromRTF.TabIndex = 5;
            this.LoadFromRTF.Text = "LoadFromRTF";
            this.LoadFromRTF.UseVisualStyleBackColor = true;
            this.LoadFromRTF.Click += new System.EventHandler(this.LoadFromRTF_Click);
            // 
            // LaunchRTF
            // 
            this.LaunchRTF.Location = new System.Drawing.Point(887, 4);
            this.LaunchRTF.Name = "LaunchRTF";
            this.LaunchRTF.Size = new System.Drawing.Size(82, 38);
            this.LaunchRTF.TabIndex = 6;
            this.LaunchRTF.Text = "LaunchRTFWithWordPad";
            this.LaunchRTF.UseVisualStyleBackColor = true;
            this.LaunchRTF.Click += new System.EventHandler(this.LaunchRTF_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(23, 354);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(250, 250);
            this.webBrowser1.TabIndex = 7;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(1063, 50);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(132, 20);
            this.SearchTextBox.TabIndex = 9;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1059, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "search";
            // 
            // totalResult
            // 
            this.totalResult.AutoSize = true;
            this.totalResult.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalResult.Location = new System.Drawing.Point(1147, 78);
            this.totalResult.Name = "totalResult";
            this.totalResult.Size = new System.Drawing.Size(0, 19);
            this.totalResult.TabIndex = 12;
            // 
            // Results
            // 
            this.Results.AutoSize = true;
            this.Results.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Results.Location = new System.Drawing.Point(1186, 78);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(52, 19);
            this.Results.TabIndex = 13;
            this.Results.Text = "Results";
            // 
            // RestoreFormat
            // 
            this.RestoreFormat.Location = new System.Drawing.Point(1053, 616);
            this.RestoreFormat.Name = "RestoreFormat";
            this.RestoreFormat.Size = new System.Drawing.Size(91, 23);
            this.RestoreFormat.TabIndex = 14;
            this.RestoreFormat.Text = "RestoreFormat";
            this.RestoreFormat.UseVisualStyleBackColor = true;
            this.RestoreFormat.Click += new System.EventHandler(this.RestoreFormat_Click);
            // 
            // InsertImage
            // 
            this.InsertImage.Location = new System.Drawing.Point(1063, 141);
            this.InsertImage.Name = "InsertImage";
            this.InsertImage.Size = new System.Drawing.Size(75, 23);
            this.InsertImage.TabIndex = 15;
            this.InsertImage.Text = "InsertImage";
            this.InsertImage.UseVisualStyleBackColor = true;
            this.InsertImage.Click += new System.EventHandler(this.InsertImage_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 809);
            this.Controls.Add(this.InsertImage);
            this.Controls.Add(this.RestoreFormat);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.totalResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.LaunchRTF);
            this.Controls.Add(this.LoadFromRTF);
            this.Controls.Add(this.SaveToRTF);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ShowImgFromClipBoard);
            this.Controls.Add(this.pB_showImg);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pB_showImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pB_showImg;
        private System.Windows.Forms.Button ShowImgFromClipBoard;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button SaveToRTF;
        private System.Windows.Forms.Button LoadFromRTF;
        private System.Windows.Forms.Button LaunchRTF;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalResult;
        private System.Windows.Forms.Label Results;
        private System.Windows.Forms.Button RestoreFormat;
        private System.Windows.Forms.Button InsertImage;
    }
}

