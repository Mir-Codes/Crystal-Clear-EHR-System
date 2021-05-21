using System;
using System.Drawing;
using System.Windows.Forms;
using Metodos;
using Datos;

namespace Presentacion
{
    public partial class frmCitasMedicas : Form
    {

        private bool IsNuevo = false;

        private bool IsEditar = false;

        private LimitantesDeIngreso validador = new LimitantesDeIngreso();

        private MCitaMedica mCitaMedica = new MCitaMedica();

        public frmCitasMedicas()
        {
            InitializeComponent();
        }





        //Habilitar los controles del formulario
        private void Habilitar()
        {

            this.cbCedula.Enabled = true;
            this.txtCiPaciente.Enabled = true;
            this.txtNombre.Enabled = true;
            this.cbSexo.Enabled = true;
            this.dtNacimiento.Enabled = true;
            this.txtTelefono.Enabled = true;
            this.txtCorreo.Enabled = true;
            this.txtNumTurno.Enabled = true;
            //todos los controles menos txtTipoConsulta



            btnNuevo.Visible = false;
            Expandir();
        }



        //Deshabilitar los controles del formulario
        private void Deshabilitar()
        {
            this.txtCiPaciente.Enabled = false;
            this.txtNombre.Enabled = false;
            this.cbSexo.Enabled = false;
            this.dtNacimiento.Enabled = false;
            this.txtTelefono.Enabled = false;
            //todos los controles menos txtTipoConsulta

            btnNuevo.Visible = true;
            Contraer();
        }


        private void Expandir()
        {
            PanelIngreso.Size = new Size(380, PanelIngreso.Size.Height);
        }

        private void Contraer()
        {
            PanelIngreso.Size = new Size(0, PanelIngreso.Size.Height);
        }


        //Habilitar los botones 
        private void Botones()
        {
            if (this.IsNuevo)
            {
                this.Habilitar();
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnCancelar.Enabled = true;

            }
            else if (this.IsEditar)
            {
                this.Habilitar();
                this.cbCedula.Enabled = false;
                this.txtCiPaciente.Enabled = false;
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
        }

        //Limpiar todos los campos
        private void Limpiar()
        {
            this.cbCedula.SelectedIndex = -1;
            this.txtCiPaciente.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.cbSexo.SelectedIndex = -1;
            this.dtNacimiento.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtCorreo.Text = string.Empty;
            this.txtPeso.Text = string.Empty;
            this.txtTalla.Text = string.Empty;
        }

        private void SinErrores()
        {
            //todo add this component
            //errorProvider1.Clear();
        }

        private bool validar()
        {

            bool error = true;

            if (cbCedula.SelectedIndex == -1)
            {
                error = false;
                //todo add validations
                //errorProvider1.SetError(cbCedula, "Seleccione el tipo de Cedula del paciente");
            }

            return error;
        }

        //Mostrar mensaje de confirmacion
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Historias Clinicas - Pacientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mostrar mensaje de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Historias Clinicas - Pacientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Guardar() 
        {
            DAOCitaMedica.CitaMedica citaMedica = new DAOCitaMedica.CitaMedica();
            DAOCitaMedica.Paciente paciente = new DAOCitaMedica.Paciente();
            paciente.Cedula = this.cbCedula.Text + this.txtCiPaciente.Text;
            paciente.Nombre = this.txtNombre.Text;
            paciente.Sexo = this.cbSexo.Text;
            paciente.FechaDeNacimiento = Convert.ToDateTime(dtNacimiento.Text);
            paciente.Telefono = this.txtTelefono.Text;
            paciente.Email = this.txtCorreo.Text;
            paciente.Peso = this.txtPeso.Text;
            paciente.Estatura = this.txtTalla.Text;

            citaMedica.Paciente = paciente;
            System.Data.DataTable pacientesExistentes = MPacientes.BuscarCedula(paciente.Cedula);
            if (pacientesExistentes.Rows.Count == 0)
            {
                mCitaMedica.Insert(citaMedica);
            }
            else 
            {
                paciente.Id = pacientesExistentes.Rows[0]["id"].ToString();
                //todo
            }

        }

        private void Cuadernito_Load(object sender, EventArgs e)
        {
            this.Deshabilitar();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            this.Habilitar();
        }

        private void btnExpandir_Click(object sender, EventArgs e)
        {
            Expandir();
        }

        private void btnContraer_Click(object sender, EventArgs e)
        {
            Contraer();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SinErrores();
            if (!validar())
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
            }
            else
            {
                Guardar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Deshabilitar();
        }
    }
}
