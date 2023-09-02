using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_02_Sebastian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCodigo_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtNombre_Click(object sender, EventArgs e)
        {

        }

        private void txtApellidos_Click(object sender, EventArgs e)
        {

        }

        private void txtDireccion_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtFecha_Click(object sender, EventArgs e)
        {

        }

        private void TBNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CBDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDepartamento_Click(object sender, EventArgs e)
        {

        }

        private void txtCargo_Click(object sender, EventArgs e)
        {

        }

        private void CBCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFotografia_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string dni = TBDNI.Text;
            string nombre = TBNombre.Text;
            string apellido = TBApellido.Text;
            string direccion = TBDireccion.Text;
            string telefono = TBTelefono.Text;
            string email = TBEmail.Text;
            string fec = dateTimePicker1.Text;
            string departamento = CBDepartamento.Text;
            dgvUsuarios.Rows.Add("", dni, nombre, apellido, direccion, telefono, email, fec, departamento);
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
