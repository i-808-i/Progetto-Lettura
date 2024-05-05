using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace ProgettoLetturaProprieta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            grid_Proprieta.Visible = true;
        }

        private void btn_scegliFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lbl_NomeFile.Text = openFileDialog.FileName;
                lbl_path.Text = openFileDialog.FileName;
                lbl_tipo.Text = new FileInfo(openFileDialog.FileName).Extension;
                lbl_desc.Text = FileVersionInfo.GetVersionInfo(openFileDialog.FileName).FileDescription;
                long dim = new FileInfo(openFileDialog.FileName).Length;
                lbl_dim.Text = dim.ToString() + " byte";
                DateTime dt = new FileInfo(openFileDialog.FileName).CreationTime;
                lbl_datacreaz.Text = dt.ToString();
                DateTime dateTime = new FileInfo(openFileDialog.FileName).LastWriteTime;   
                lbl_ultimamod.Text = dateTime.ToString();

                var Vers = FileVersionInfo.GetVersionInfo(openFileDialog.FileName).FileVersion;
                if (Vers != null)
                {
                    lbl_versione.Text = Vers.ToString();
                }
                else
                {
                    lbl_versione.Text = " ";
                }
                
                lbl_nomeorig.Text = new FileInfo(openFileDialog.FileName).Name;
            }
        }

        private void btn_Salva_Click(object sender, EventArgs e)
        {
            String csv = @"C:\Users\miche\Output.csv";
            String separator = ";";
            StringBuilder output = new StringBuilder();
            String[] headings = {label4.Text, label3.Text, label5.Text, label7.Text, label11.Text, label13.Text, label15.Text, label19.Text };
            output.AppendLine(string.Join(separator, headings));
            String[] newLine = { lbl_path.Text, lbl_tipo.Text, lbl_desc.Text, lbl_dim.Text, lbl_datacreaz.Text, lbl_ultimamod.Text, lbl_versione.Text, lbl_nomeorig.Text };
            output.AppendLine(string.Join(separator, newLine));
            File.WriteAllText(csv, output.ToString());
        }
    }
}
