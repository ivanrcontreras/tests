using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test3
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
    

        private void verificacionescajas() 
        {
            //pregunto si mis cajas están vacias
            if (txtname.Text == "")
            {
                errorProvider1.SetError(txtname, "Debe ingresar el nombre de la persona");
                txtname.Focus();
                return;
            }
            errorProvider1.SetError(txtname, "");
            if (txtsurname.Text == "")
            {
                errorProvider1.SetError(txtsurname, "Debe ingresar el nombre de la persona");
                txtsurname.Focus();
                return;
            }
            errorProvider1.SetError(txtsurname, "");
            if (txtdirec.Text == "")
            {
                errorProvider1.SetError(txtdirec, "Debe ingresar el nombre de la persona");
                txtdirec.Focus();
                return;
            }
            errorProvider1.SetError(txtdirec, "");
            if (txttel.Text == "")
            {
                errorProvider1.SetError(txttel, "Debe ingresar el nombre de la persona");
                txttel.Focus();
                return;
            }
            errorProvider1.SetError(txttel, "");
        }

        //creo el arreglo para mostrar las personas que se va agregando a mi data grid
        ArrayList lista_personas = new ArrayList();
        private void btnnewpersons_Click(object sender, EventArgs e)
        {
 
            verificacionescajas();
           

            //genero una instancia de la clase persona

            Personas mispersonas = new Personas();
            mispersonas.Nombre = txtname.Text;
            mispersonas.Apellido = txtsurname.Text;
            mispersonas.Direccion = txtdirec.Text;
            mispersonas.fecha_nacimiento = dtpfecha_nacimiento.Value;
            mispersonas.telefono = txttel.Text;

            //agrego la informacion al arraylist

            lista_personas.Add(mispersonas);

            //agrego la informacion al datagrid
            dgvPersonas.DataSource = lista_personas;

        }
    }
}
