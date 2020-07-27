﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApplication_ObtainImageFromClipBoard
{
    public partial class FormMain : Form
    {
        public string RTFpath;

        public FormMain()
        {
            InitializeComponent();

            richTextBox1.AllowDrop = true;

            richTextBox1.DragDrop += RichTextBox1_DragDrop;
            richTextBox1.DragEnter += RichTextBox1_DragEnter;
            richTextBox1.MouseDown += RichTextBox1_MouseDown;

            richTextBox1.Multiline = true;
            richTextBox1.WordWrap = false;


            //setup the file folder under the application
            DirectoryInfo RootFolder = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            RTFpath = RootFolder.Parent.Parent.Parent.FullName + "\\Figures\\temp.rtf"; 
           
            

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
            richTextBox1.AppendText(appendInfo());

            richTextBox1.SaveFile(RTFpath);
            

        }

        private void LoadFromRTF_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(RTFpath);

        }

        private void LaunchRTF_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(RTFpath);
        }


        //add tag in the ending
        private string appendInfo()
        {
            //add date and operation
            string strTime = DateTime.Now.ToString("yyyy-MM-dd / HH:mm:ss");
            string userName = "xMan";

            string space = new string(' ', 10);

            return "\n"+ space+strTime + "  "+userName +AddMark();

        }


        //add mark as starter
        private string AddMark()
        {
            string strSingleMark = "-";
            int nRepeat = 50;
            string strMark = string.Empty;

            for (int i = 0; i < nRepeat; i++)
            {
                strMark += strSingleMark;
            }

            return "\n" + strMark + "\n";

        }

        



        //search specified text
        private void searchTxt(string txtWord)
        {
            //string txtWord = "CatchMe";
            int index = richTextBox1.Text.IndexOf(txtWord);
            //richTextBox1.Cursor = Cursors.

            //MessageBox.Show("I'm at " + index.ToString());

            //clear previous format
            clearFormat();

            List<int> resultIndexList = new List<int>();
            for (int i = 0; i < richTextBox1.TextLength; i++)
            {
                int resultIndex = richTextBox1.Find(txtWord.Trim(), i, RichTextBoxFinds.None);
                if (resultIndex != -1)
                {                    
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.SelectionBackColor = Color.Yellow;

                    if (resultIndexList.Count == 0)
                        resultIndexList.Add(resultIndex);
                    else
                    {
                        if(resultIndex != resultIndexList[resultIndexList.Count-1])
                            resultIndexList.Add(resultIndex);
                    }
                }
            }

            totalResult.Text = resultIndexList.Count.ToString();

            int count = 0;
            char[] splitter = {' ', '\n' };
            string[] strArr = richTextBox1.Text.Split(splitter);
            //int test = richTextBox1.Text.Split(splitter).Length;

            for (int i = 0; i < strArr.Length; i++)
            {
                //string test2 = richTextBox1.Text.Split(' ')[i];

                if (strArr[i].Trim().ToLower() == txtWord.Trim().ToLower())
                {
                    count = count + 1;
                }
            }

            
            //MessageBox.Show(count.ToString());
            // lblCount.Text = count.ToString();

        }


        //clear the format
        private void clearFormat()
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.SelectionBackColor = Color.White;
        }

        //text change function
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "")
            {
                totalResult.Text = "0";
                clearFormat();
            }
            else
            {
               searchTxt(SearchTextBox.Text);

            }
        }

    }
}