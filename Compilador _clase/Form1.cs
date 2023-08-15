using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compilador__clase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dialogResultTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dialogResultLabel_Click(object sender, EventArgs e)
        {

        }

        private void textLabel_Click(object sender, EventArgs e)
        {

        }

        private void textTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textLabel1_Click(object sender, EventArgs e)
        {
     
        }

        private void textLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void textLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsumar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnresult_Click(object sender, EventArgs e)
        { 
        
        }

        private void cbl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void cboxloadfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxloadfile.Text.Equals("Ingreso manual"))
            {
                //habilito la ventana
                rtbconsole.Enabled = Enabled;
                rtbconsole.Visible = Enabled;
                lblconsole.Visible = Enabled;
                lblconsole.Text = "Consola";

                //habilitar el boton
                btnload.Visible = Enabled;
                btnload.Enabled = Enabled;

                //quito el boton de cargar
                btnloadfile.Enabled = false;
                btnloadfile.Visible = false;

                //quito la barra del path
                tboxpath.Enabled = false;
                tboxpath.Visible = false;
            }
            else if(cboxloadfile.Text.Equals("Carga desde archivo"))
            {
                //quito la ventana
                rtbconsole.Enabled = false;
                rtbconsole.Visible = false;
                //quito el boton
                btnload.Visible = false;
                btnload.Enabled = false;

                //cambio la etiqueta
                lblconsole.Text = "Direccion del archivo";

                //mostrar la caja de texto
                tboxpath.Enabled = true;
                tboxpath.Visible = true;

                //habilito el boton
                btnloadfile.Enabled = Enabled;
                btnloadfile.Visible = Enabled;

                
            }
            else
            {
                //deshabilito todo
                rtbconsole.Enabled = false;
                rtbconsole.Visible = false;
                lblconsole.Visible = false;
                btnloadfile.Enabled = false;
                btnloadfile.Visible = false;
                btnload.Visible = false;
                btnload.Enabled = false;
                tboxpath.Enabled = false;
                tboxpath.Visible = false;
            }
        }

        private void btnloadfile_Click(object sender, EventArgs e)
        {
            String path = tboxpath.Text;
            StreamReader sr = new StreamReader(path);
            try
            {
                rtbout.Text = sr.ReadToEnd();
                sr.Close();
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        

        private void btnload_Click(object sender, EventArgs e)
        {
            string path = "D:/data/";
            string file = "text.txt";
            FileStream fs;
            
            try
            {
                if (File.Exists(path)){
                    fs = File.Create(path + file);
                    fs.Close();
                    StreamWriter writer = new StreamWriter("D:/data/text.txt");
                    writer.Write(rtbconsole.Text);
                    rtbout.Text = rtbconsole.Text;
                    writer.Close();
                }
                else
                {
                    Directory.CreateDirectory(path);
                    fs = File.Create(path +file);
                    fs.Close();
                    StreamWriter writer = new StreamWriter("D:/data/text.txt");
                    writer.Write(rtbconsole.Text);
                    rtbout.Text = rtbconsole.Text;
                    writer.Close();

                }
                
            }catch (Exception ex) 
            {
                throw ex;
            }
        }
    }
}
