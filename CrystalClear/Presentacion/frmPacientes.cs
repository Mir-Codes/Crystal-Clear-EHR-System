using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Metodos;

namespace Presentacion
{
    public partial class frmPacientes : Form
    {
        private bool IsNuevo = false;

        private bool IsEditar = false;

        public frmPacientes()
        {
            InitializeComponent();
            //añadir tool tips
            //añadir simbolitos de error
        }

        //Mostrar mensaje de confirmacion
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Historias Clinicas - Pacientes", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        //Mostrar mensaje de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Historias Clinicas - Pacientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpiar todos los campos
        private void Limpiar()
        {
            this.cbCedula.SelectedIndex = -1;
            this.txtCiPaciente.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.cbSexo.SelectedIndex = -1;
            this.cbEstCivil.SelectedIndex = -1;
            this.dtNacimiento.Text = string.Empty;
            this.txtLugarNac.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtOcupacion.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtCorreo.Text = string.Empty;
            this.txtPeso.Text = string.Empty;
            this.txtTalla.Text = string.Empty;
        }

        //Habilitar los controles del formulario
        private void Habilitar()
        {
            this.txtCiPaciente.Enabled = true;
            this.txtNombre.Enabled = true;
            this.cbSexo.Enabled = true;
            this.dtNacimiento.Enabled = true;
            this.txtTelefono.Enabled = true;
            btnNuevo.Visible = false;
            PanelIngreso.Size = new Size(311, PanelIngreso.Size.Height);
        }

        //Deshabilitar los controles del formulario
        private void Deshabilitar()
        {
            this.txtCiPaciente.Enabled = false;
            this.txtNombre.Enabled = false;
            this.cbSexo.Enabled = false;
            this.dtNacimiento.Enabled = false;
            this.txtTelefono.Enabled = false;
            btnNuevo.Visible = true;
            PanelIngreso.Size = new Size(0, PanelIngreso.Size.Height);
        }

        //Habilitar los botones 
        private void Botones()
        {
            if(this.IsNuevo || this.IsEditar)
            {
                this.Habilitar();
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnCancelar.Enabled = true;

            }
            else
            {
                this.Deshabilitar();
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
            }
        }//fin metodo botones


        //Metodo para ocultar columnas
        //private void OcultarColumnas()
        //{

        //}

        //Metodo Mostrar
        private void Mostrar()
        {
            this.dataListado.DataSource = MPacientes.Mostrar(txtBuscar.Text);
            //this.OcultarColumnas();
            //dataListado.ClearSelection();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataListado.Rows.Count);
        }


        //Metodo BuscarNombre
        private void BuscarNombre()
        {
            this.dataListado.DataSource = MPacientes.BuscarNombre(this.txtBuscar.Text);
            //this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Metodo BuscarCedula
        private void Buscar_Cedula()
        {
            this.dataListado.DataSource = MPacientes.BuscarCedula(this.txtBuscar.Text);
           // this.OcultarColumnas();
            lblTotal.Text = "Total Registros: " + Convert.ToString(dataListado.Rows.Count);
            
        }

        private void Buscar()
        {
            if (cbBuscar.SelectedIndex == 1)
            {
                this.Mostrar();
            }
            else if (cbBuscar.SelectedIndex == 0)
            {
                this.Buscar_Cedula();
            }
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Deshabilitar();
            this.Botones();
            cbBuscar.SelectedIndex = 1;


            // this.OcultarColumnas();


            //todo esto es pa ponerle colorcitos al datagridview

            dataListado.BorderStyle = BorderStyle.None;
            dataListado.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(209, 247, 195);
            dataListado.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataListado.DefaultCellStyle.SelectionBackColor = Color.FromArgb(127, 207, 74);
            dataListado.DefaultCellStyle.SelectionForeColor = Color.White;
            dataListado.BackgroundColor = Color.White;

            dataListado.EnableHeadersVisualStyles = false;
            dataListado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataListado.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(96, 191, 33);  //69, 204, 20
            dataListado.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataListado.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Regular);

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar();
            this.cbCedula.Focus();
            this.txtCiPaciente.Enabled = false;
            //ID = 0;
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
