namespace WindowsFormsApplication_ObtainImageFromClipBoard
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
            this.pB_showImg = new System.Windows.Forms.PictureBox();
            this.ShowImgFromClipBoard = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveToRTF = new System.Windows.Forms.Button();
            this.LoadFromRTF = new System.Windows.Forms.Button();
            this.LaunchRTF = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Search = new System.Windows.Forms.Button();
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
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(339, 36);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(539, 568);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "InputContents";
            // 
            // SaveToRTF
            // 
            this.SaveToRTF.Location = new System.Drawing.Point(671, 7);
            this.SaveToRTF.Name = "SaveToRTF";
            this.SaveToRTF.Size = new System.Drawing.Size(75, 23);
            this.SaveToRTF.TabIndex = 4;
            this.SaveToRTF.Text = "SaveToRTF";
            this.SaveToRTF.UseVisualStyleBackColor = true;
            this.SaveToRTF.Click += new System.EventHandler(this.SaveToRTF_Click);
            // 
            // LoadFromRTF
            // 
            this.LoadFromRTF.Location = new System.Drawing.Point(523, 7);
            this.LoadFromRTF.Name = "LoadFromRTF";
            this.LoadFromRTF.Size = new System.Drawing.Size(89, 23);
            this.LoadFromRTF.TabIndex = 5;
            this.LoadFromRTF.Text = "LoadFromRTF";
            this.LoadFromRTF.UseVisualStyleBackColor = true;
            this.LoadFromRTF.Click += new System.EventHandler(this.LoadFromRTF_Click);
            // 
            // LaunchRTF
            // 
            this.LaunchRTF.Location = new System.Drawing.Point(803, 7);
            this.LaunchRTF.Name = "LaunchRTF";
            this.LaunchRTF.Size = new System.Drawing.Size(75, 23);
            this.LaunchRTF.TabIndex = 6;
            this.LaunchRTF.Text = "LaunchRTF";
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
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(913, 52);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 8;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 633);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.LaunchRTF);
            this.Controls.Add(this.LoadFromRTF);
            this.Controls.Add(this.SaveToRTF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ShowImgFromClipBoard);
            this.Controls.Add(this.pB_showImg);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pB_showImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pB_showImg;
        private System.Windows.Forms.Button ShowImgFromClipBoard;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveToRTF;
        private System.Windows.Forms.Button LoadFromRTF;
        private System.Windows.Forms.Button LaunchRTF;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button Search;
    }
}

