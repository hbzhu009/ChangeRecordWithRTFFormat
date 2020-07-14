using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication_ObtainImageFromClipBoard
{
    public partial class Form1 : Form
    {
        public string RTFpath = @"C:\Work\Programming\C#\WindowsFormsApplication_ObtainImageFromClipBoard_RTF\Figures\temp.rtf";
        public Form1()
        {
            InitializeComponent();

            richTextBox1.AllowDrop = true;
            richTextBox1.DragDrop += RichTextBox1_DragDrop;
            richTextBox1.DragEnter += RichTextBox1_DragEnter;
            richTextBox1.MouseDown += RichTextBox1_MouseDown;

            richTextBox1.Multiline = true;
            richTextBox1.WordWrap = false;
            

        }

        private void ShowImgFromClipBoard_Click(object sender, EventArgs e)
        {
            System.Drawing.Image returnImage = null;
            if (Clipboard.ContainsImage())
            {
                returnImage = Clipboard.GetImage();
                Clipboard.Clear();

                pB_showImg.Image = returnImage;
                //pB_showImg.
            }
        }

        //drag the object to the target "richTextBox"
        private void RichTextBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


        //release mouse to complete this operation
        private void RichTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            //richTextBox1.LoadFile(path, RichTextBoxStreamType.PlainText);
            Bitmap bmp = new Bitmap(path);

            Clipboard.SetDataObject(bmp);
            DataFormats.Format dataFormat =
            DataFormats.GetFormat(DataFormats.Bitmap);
            if (richTextBox1.CanPaste(dataFormat))
                richTextBox1.Paste(dataFormat);
        }

        //release mouse to complete this operation
        private void RichTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (Clipboard.ContainsImage())
                {
                    var confirmRes = MessageBox.Show("Sure to paste?", "Confirm paste!", MessageBoxButtons.YesNo);
                    if (confirmRes == DialogResult.Yes)
                    {
                        DataFormats.Format dataFormat = DataFormats.GetFormat(DataFormats.Bitmap);
                        if (richTextBox1.CanPaste(dataFormat))
                            richTextBox1.Paste(dataFormat);

                        //clear the clip board after paste
                        Clipboard.Clear();
                    }
                    else
                    {
                        //do nothing
                    }
                   
                }
                else
                    MessageBox.Show("No image on the clip board!");

            }
        }



        private void SaveToRTF_Click(object sender, EventArgs e)
        {
            //string RTFpath = @"C:\Work\Programming\C#\WindowsFormsApplication_ObtainImageFromClipBoard\Figures\temp.rtf";
            richTextBox1.SaveFile(RTFpath);
        }

        private void LoadFromRTF_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(RTFpath);
            richTextBox1.AppendText(appendInfo());
            
        }

        private void LaunchRTF_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(RTFpath);

        }


        //add tag by default.
        private string appendInfo()
        {
            
            string strTime = DateTime.Now.ToString("yyyy-MM-dd / HH:mm:ss");
            string userName = "xMan";

            return "\n"+strTime + "  "+userName;

        }

        private void Search_Click(object sender, EventArgs e)
        {
            int index = richTextBox1.Text.IndexOf("CatchMe");
            //richTextBox1.Cursor = Cursors.

            MessageBox.Show("I'm at " +index.ToString());
        }
    }
}
