﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L91
{
    public partial class MainWin : Form
    {
        public MainWin()
        {
            InitializeComponent(); 
        }
        private string url = "";
        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser2.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser2.GoForward();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = webBrowser2.Url.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate("ftp.chantpouryehoshoua.com","");
        }

        private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
        {
            //Prevent ftp site openning in new window.

            /*if (url.StartsWith("ftp://"))

            {

                e.Cancel = true;

                this.webBrowser1.Navigate(url);

            }
            */
        }
    }
}