using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Casa_de_schim_valutar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void conv_btn_Click(object sender, EventArgs e)
        {
            double i = int.Parse(amount_txt.Text);
            if (fromcombo1.SelectedItem.ToString() == "MDL" && tocombo2.SelectedItem.ToString()== "USD")
            {
                double conver = i / 18.17;
                disply_txt.Text = "Suma obtinuta: "+conver+"\t $";
            }
            if (fromcombo1.SelectedItem == "MDL" && tocombo2.SelectedItem == "EUR")
            {
                double conver = i / 20.46;
                disply_txt.Text = "Suma obtinuta: " + conver+"\t euro";
            }
            if (fromcombo1.SelectedItem.ToString() == "EUR" && tocombo2.SelectedItem.ToString() == "MDL")
            {
                double conver = i * 20.46;
                disply_txt.Text = "Suma obtinuta: " + conver + "\t Lei";
            }
            if (fromcombo1.SelectedItem.ToString() == "USD" && tocombo2.SelectedItem.ToString() == "MDL")
            {
                double conver = i * 18.17;
                disply_txt.Text = "Suma obtinuta: " + conver + "\t Lei";
            }
            if (fromcombo1.SelectedItem.ToString() == "EUR" && tocombo2.SelectedItem.ToString() == "USD")
            {
                double conver = i * 1.13;
                disply_txt.Text = "Suma obtinuta: " + conver + "\t USD";
            }
            if (fromcombo1.SelectedItem.ToString() == "USD" && tocombo2.SelectedItem.ToString() == "EUR")
            {
                double conver = i * 0.89;
                disply_txt.Text = "Suma obtinuta: " + conver + "\t EUR";
            }
            if ( fromcombo1.SelectedItem.ToString() == "USD" && tocombo2.SelectedItem.ToString() == "USD")
            {
              
                disply_txt.Text = "EROARE: Ai ales sa Convertesti USD in USD";
            }

            if (fromcombo1.SelectedItem.ToString() == "EUR" && tocombo2.SelectedItem.ToString() == "EUR")
            {

                disply_txt.Text = "EROARE: Ai ales sa Convertesti EUR in EUR";
            }
            if (fromcombo1.SelectedItem.ToString() == "MDL" && tocombo2.SelectedItem.ToString() == "MDL")
            {

                disply_txt.Text = "EROARE: Ai ales sa Convertesti MDL in MDL";
            }
        }

        private void amount_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void fromcombo1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tocombo2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string _embeddedpage = @"
            <html>
                <body>
                    <iframe class='youtube-player' type='text/html' width='640' height='385'
                        src='#' frameborder='0'>
                    </iframe>
                </body>
            <html>";

            webBrowser1.DocumentText = _embeddedpage;
        }
       
    }
}
