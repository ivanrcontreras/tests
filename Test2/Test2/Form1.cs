using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void guardartexto()
        {
            string nombredeltexto = saveFileDialog1.FileName + ".txt";
            StreamWriter texto_guardar = File.CreateText(nombredeltexto);
            texto_guardar.Write(rtbxtexto_ingresado.Text);
            texto_guardar.Flush();
            texto_guardar.Close();
            MessageBox.Show("guardado");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog1.FileName))
                    {
                        guardartexto();
                    }
                    else
                    {
                        guardartexto();
                    }
                   
                }
            }
            catch (Exception) 
            {
                MessageBox.Show("Error al Guardar, corrobore la ruta de guardado");
            }
        }
    }
}
