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

        LimitantesDeIngreso valid = new LimitantesDeIngreso();

        public frmPacientes()
        {
            InitializeComponent();
            

        }


        private bool validar()
        {

            bool error = true;

            if (cbCedula.SelectedIndex == -1)
            {
                error = false;
                errorProvider1.SetError(cbCedula, "Seleccione el tipo de Cedula del paciente");
            }
            if (txtCiPaciente.Text == "")
            {
                error = false;
                errorProvider1.SetError(txtCiPaciente, "Agrega el CI del paciente");
            }
            if (txtNombre.Text == "")
            {
                error = false;
                errorProvider1.SetError(txtNombre, "Ingresa el nombre del paciente");
            }
            if (cbSexo.SelectedIndex == -1)
            {
                error = false;
                errorProvider1.SetError(cbSexo, "Ingresa el sexo del paciente");
            }
            if (cbEstCivil.SelectedIndex == -1)
            {
                error = false;
                errorProvider1.SetError(cbEstCivil, "Ingresa el estado civil del paciente");
            }
            if (txtLugarNac.Text == "")
            {
                error = false;
                errorProvider1.SetError(txtLugarNac, "ingresa el lugar de nacimiento del paciente");
            }
            if (txtDireccion.Text == "")
            {
                error = false;
                errorProvider1.SetError(txtDireccion, "ingresa la direccion del paciente");
            }
            if (txtTelefono.Text == "")
            {
                error = false;
                errorProvider1.SetError(txtTelefono, "ingresa un teléfono");
            }
            if (txtCorreo.Text == "")
            {
                error = false;
                errorProvider1.SetError(txtCorreo, "ingresa el correo electronico del paciente");
            }
            if (txtOcupacion.Text == "")
            {
                error = false;
                errorProvider1.SetError(txtOcupacion, "ingresa la ocupacion del paciente");
            }
            if (txtOcupacion.Text == "")
            {
                error = false;
                errorProvider1.SetError(txtOcupacion, "ingresa la ocupacion del paciente");
            }
            return error;
        }

        //Cuando se llenen, se retira el error
        private void SinErrores()
        {
            errorProvider1.Clear();
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
            
            this.cbCedula.Enabled = true;
            this.txtCiPaciente.Enabled = true;
            this.txtNombre.Enabled = true;
            this.cbSexo.Enabled = true;
            this.dtNacimiento.Enabled = true;
            this.txtTelefono.Enabled = true;
            this.txtCorreo.Enabled = true;
            this.txtOcupacion.Enabled = true;



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
            if(this.IsNuevo)
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
        }//fin metodo botones


        //Metodo para ocultar columnas
        private void OcultarColumnas()
        {
          // this.dataListado.Columns["TextoBuscar"].Visible = false; //columna TextoBuscar
        }


        //Metodo Mostrar
        private void Mostrar()
        {
            this.dataListado.DataSource = MPacientes.Mostrar(txtBuscar.Text);
            this.OcultarColumnas();
            dataListado.ClearSelection();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataListado.Rows.Count);
            Anulados();
        }


        //Metodo BuscarNombre
        private void BuscarNombre()
        {
            this.dataListado.DataSource = MPacientes.BuscarNombre(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataListado.Rows.Count);
            Anulados();
        }

        //Metodo BuscarCedula
        private void Buscar_Cedula()
        {
            this.dataListado.DataSource = MPacientes.BuscarCedula(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total Registros: " + Convert.ToString(dataListado.Rows.Count);
            Anulados();
            
        }

        private void Buscar()
        {
            if (cbBuscar.SelectedIndex == 1)
            {
                //this.Mostrar(); old
                this.BuscarNombre();
            }
            else if (cbBuscar.SelectedIndex == 0)
            {
                this.Buscar_Cedula();
            }
        }




        private void Guardar()
        {
            try
            {
                string Rpta = "";

                if (this.IsNuevo)
                {
                    
                    Rpta = MPacientes.Insertar(
                        (this.cbCedula.Text + this.txtCiPaciente.Text),
                        this.txtNombre.Text,
                        Convert.ToDateTime(dtNacimiento.Text),
                        this.cbSexo.Text,
                        this.cbEstCivil.Text,
                        this.txtLugarNac.Text,
                        this.txtDireccion.Text,
                        this.txtOcupacion.Text,
                        this.txtTelefono.Text,
                        this.txtCorreo.Text,
                        "V",
                        "ejemplo imagepath",
                        this.txtPeso.Text,
                        this.txtTalla.Text
                        );


                }
                else
                {
                    //Vamos a modificar un Paciente
                    Rpta = MPacientes.Editar(
                        (this.cbCedula.Text + this.txtCiPaciente.Text),
                        this.txtNombre.Text,
                        Convert.ToDateTime(dtNacimiento.Text),
                        this.cbSexo.Text,
                        this.cbEstCivil.Text,
                        this.txtLugarNac.Text,
                        this.txtDireccion.Text,
                        this.txtOcupacion.Text,
                        this.txtTelefono.Text,
                        this.txtCorreo.Text,
                        "V",
                        "ejemplo imagepath",
                        this.txtPeso.Text,
                        this.txtTalla.Text
                        );
                }
                //Si la respuesta fue OK, fue porque se modificó
                //o insertó el Trabajador
                //de forma correcta
                if (Rpta.Equals("Ok"))
                {
                    if (this.IsNuevo)
                    {
                        this.MensajeOk("Se insertó de forma correcta el registro");
                    }
                    else
                    {
                        this.MensajeOk("Se actualizó de forma correcta el registro");
                        
                    }

                }
                else
                {
                    //Mostramos el mensaje de error
                    this.MensajeError(Rpta);
                }
                this.IsNuevo = false;
                this.IsEditar = false;
                this.Botones();
                this.Limpiar();
                this.Mostrar();
                this.Deshabilitar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        private void EliminarItems()
        {

            try
            {
                int NumeroSeleccionado = 0;
                DialogResult Opcion;
                foreach (DataGridViewRow item in this.dataListado.SelectedRows)
                {
                    NumeroSeleccionado++;
                }
                if (NumeroSeleccionado > 1)
                {
                    Opcion = MessageBox.Show("¿Realmente desea eliminar los " + NumeroSeleccionado + " registros de pacientes?", "Sistema Crystal Clear", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                }
                else
                {
                    Opcion = MessageBox.Show("¿Realmente desea eliminar el registro del paciente?", "Sistema Crystal Clear", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                }

                if (Opcion == DialogResult.OK)
                {
                    string Rpta = "";

                    foreach (DataGridViewRow item in this.dataListado.SelectedRows)
                    {
                        Rpta = MPacientes.Eliminar(Convert.ToString(item.Cells["Cedula"].Value));
                    }

                    if (Rpta.Equals("Ok"))
                    {
                        if (NumeroSeleccionado > 1)
                        {
                            this.MensajeOk("Se eliminaron correctamente los registros de pacientes");
                        }
                        else
                        {
                            this.MensajeOk("Se eliminó correctamente el registro del paciente");
                        }
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }

                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void AnularItems()
        {

            try
            {
                int NumeroSeleccionado = 0;
                DialogResult Opcion;
                foreach (DataGridViewRow item in this.dataListado.SelectedRows)
                {
                    NumeroSeleccionado++;
                }
                if (NumeroSeleccionado > 1)
                {
                    Opcion = MessageBox.Show("¿Realmente desea anular los " + NumeroSeleccionado + " registros de pacientes?", "Sistema Crystal Clear", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                }
                else
                {
                    Opcion = MessageBox.Show("¿Realmente desea anular el registro del paciente?", "Sistema Crystal Clear", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                }

                if (Opcion == DialogResult.OK)
                {
                    string Rpta = "";

                    foreach (DataGridViewRow item in this.dataListado.SelectedRows)
                    {
                        Rpta = MPacientes.Anular(Convert.ToString(item.Cells["Cedula"].Value));
                    }

                    if (Rpta.Equals("OK"))
                    {
                        if (NumeroSeleccionado > 1)
                        {
                            this.MensajeOk("Se anularon correctamente los registros de pacientes");
                        }
                        else
                        {
                            this.MensajeOk("Se anuló correctamente el registro del paciente");
                        }
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }

                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        private int CalcularEdad()
        {
            DateTime FechaActual = DateTime.Now.Date;
            //MessageBox.Show("La fecha de hoy es: " + Convert.ToString(FechaActual) + ""); //linea para testear la fecha actual
            DateTime Nacimiento = DateTime.Parse(dtNacimiento.Text);
            int Edad;
            Edad = FechaActual.Year - Nacimiento.Year;

            if (FechaActual.Month < Nacimiento.Month)
            {
                Edad--;
            }
            else if ((FechaActual.Month == Nacimiento.Month)
                       && (FechaActual.Day < Nacimiento.Day))
            {
                Edad--;
            }

            return Edad ;

        }


        private void Anulados()
        {
            string estadotabla;

            for (int fila = 0; fila <= dataListado.Rows.Count - 1; fila++)
            {
                estadotabla = Convert.ToString(this.dataListado.Rows[fila].Cells["EstadoVivoMuerto"].Value);

                if (estadotabla == "M")
                {
                    dataListado.Rows[fila].Cells["Cedula"].Style.ForeColor = Color.Red;
                    dataListado.Rows[fila].Cells["Nombre"].Style.ForeColor = Color.Red;
                    dataListado.Rows[fila].Cells["FechaNac"].Style.ForeColor = Color.Red;
                    dataListado.Rows[fila].Cells["Sexo"].Style.ForeColor = Color.Red;
                    dataListado.Rows[fila].Cells["EstCivil"].Style.ForeColor = Color.Red;
                    dataListado.Rows[fila].Cells["LugarNac"].Style.ForeColor = Color.Red;
                    dataListado.Rows[fila].Cells["Direccion"].Style.ForeColor = Color.Red;
                    dataListado.Rows[fila].Cells["Ocupacion"].Style.ForeColor = Color.Red;
                    dataListado.Rows[fila].Cells["Telefono"].Style.ForeColor = Color.Red;
                    dataListado.Rows[fila].Cells["Correo"].Style.ForeColor = Color.Red;
                    dataListado.Rows[fila].Cells["Peso"].Style.ForeColor = Color.Red;
                    dataListado.Rows[fila].Cells["Talla"].Style.ForeColor = Color.Red;
                    dataListado.Rows[fila].Cells["EstadoVivoMuerto"].Style.ForeColor = Color.Red;
                    dataListado.Rows[fila].Cells["imagepath"].Style.ForeColor = Color.Red;

                    dataListado.Rows[fila].Cells["Cedula"].Style.SelectionBackColor = Color.Brown;
                    dataListado.Rows[fila].Cells["Nombre"].Style.SelectionBackColor = Color.Brown;
                    dataListado.Rows[fila].Cells["FechaNac"].Style.SelectionBackColor = Color.Brown;
                    dataListado.Rows[fila].Cells["Sexo"].Style.SelectionBackColor = Color.Brown;
                    dataListado.Rows[fila].Cells["EstCivil"].Style.SelectionBackColor = Color.Brown;
                    dataListado.Rows[fila].Cells["LugarNac"].Style.SelectionBackColor = Color.Brown;
                    dataListado.Rows[fila].Cells["Direccion"].Style.SelectionBackColor = Color.Brown;
                    dataListado.Rows[fila].Cells["Ocupacion"].Style.SelectionBackColor = Color.Brown;
                    dataListado.Rows[fila].Cells["Telefono"].Style.SelectionBackColor = Color.Brown;
                    dataListado.Rows[fila].Cells["Correo"].Style.SelectionBackColor = Color.Brown;
                    dataListado.Rows[fila].Cells["Peso"].Style.SelectionBackColor = Color.Brown;
                    dataListado.Rows[fila].Cells["Talla"].Style.SelectionBackColor = Color.Brown;
                    dataListado.Rows[fila].Cells["EstadoVivoMuerto"].Style.SelectionBackColor = Color.Brown;
                    dataListado.Rows[fila].Cells["imagepath"].Style.SelectionBackColor = Color.Brown;

                }
            }
        }







        private void frmPacientes_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Deshabilitar();
            this.Botones();
            cbBuscar.SelectedIndex = 1;


            this.OcultarColumnas();



            this.toolTip1.SetToolTip(this.btnAnular, "Anular");
            this.toolTip1.SetToolTip(this.btnEliminar, "Eliminar");
            this.toolTip1.SetToolTip(this.btnCancelar, "Cancelar");
            this.toolTip1.SetToolTip(this.btnGuardar, "Guardar");
            this.toolTip1.SetToolTip(this.btnImprimir, "Imprimir");
            this.toolTip1.SetToolTip(this.btnNuevo, "Nuevo paciente");
            this.toolTip1.SetToolTip(this.dtNacimiento, "Edad: "+ CalcularEdad());




            //todo esto es pa ponerle colorcitos al datagridview

            dataListado.BorderStyle = BorderStyle.None;
            dataListado.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(211, 241, 242); //clarito
            dataListado.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataListado.DefaultCellStyle.SelectionBackColor = Color.FromArgb(87, 189, 186);  //resalto
            dataListado.DefaultCellStyle.SelectionForeColor = Color.White;
            dataListado.BackgroundColor = Color.White;

            dataListado.EnableHeadersVisualStyles = false;
            dataListado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataListado.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 133, 135);  //oscuro
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
            
            //ID = 0;

        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void dataListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Habilitar();

            //cedula
            string Cedula = Convert.ToString(this.dataListado.CurrentRow.Cells["Cedula"].Value);
            this.cbCedula.Text = Cedula.Substring(0, 2);
            this.txtCiPaciente.Text = Cedula.Remove(0, 2);
            this.cbCedula.Enabled = false;
            //

            this.txtNombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Nombre"].Value);
            this.dtNacimiento.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["FechaNac"].Value);
            this.cbSexo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Sexo"].Value);
            this.cbEstCivil.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["EstCivil"].Value);
            this.txtLugarNac.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["LugarNac"].Value);
            this.txtDireccion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Direccion"].Value);
            this.txtOcupacion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Ocupacion"].Value);
            this.txtTelefono.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Telefono"].Value);
            this.txtCorreo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Correo"].Value);
            this.txtPeso.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Peso"].Value);
            this.txtTalla.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Talla"].Value);

            this.IsEditar = true;
            this.IsNuevo = false;
            txtNombre.Focus();
            Botones();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Deshabilitar();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            AnularItems();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarItems();
        }

        private void dtNacimiento_ValueChanged(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(this.dtNacimiento, "Edad: " + CalcularEdad());
        }





        //validaciones
        
        private void txtCiPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(txtCiPaciente, "");
            if (valid.soloNumeros(e))
            {
                errorProvider1.SetError(txtCiPaciente, "En este campo solo se pueden ingresar números");
            }
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(txtNombre, "");
            if (valid.soloLetras(e))
            {
                errorProvider1.SetError(txtNombre, "En este campo solo se pueden ingresar letras");
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(txtTelefono, "");
            if (valid.soloNumeros(e))
            {
                errorProvider1.SetError(txtTelefono, "En este campo solo se pueden ingresar números");
            }
        }
        private void txtIdMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            valid.soloNumeros(e);
        }
        private void txtNroHab_KeyPress(object sender, KeyPressEventArgs e)
        {
            valid.soloNumeros(e);
        }
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbBuscar.Text == "Cedula")
            {
                errorProvider1.SetError(txtBuscar, "");
                if (valid.soloNumeros(e))
                {
                    errorProvider1.SetError(txtBuscar, "En este campo solo se pueden ingresar números");
                }
            }
            if (cbBuscar.Text == "Nombre")
            {
                errorProvider1.SetError(txtBuscar, "");
                if (valid.soloLetras(e))
                {
                    errorProvider1.SetError(txtBuscar, "En este campo solo se pueden ingresar letras");
                }
            }
        }

        private void txtCiPaciente_Leave(object sender, EventArgs e)
        {
            CedulaUnica();
        }

        private void CedulaUnica()
        {
            try
            {
                if (!IsNuevo)
                    return;

                //el siguiente condicional es para ver si hay texto escrito en los campos de cedula antes de verificar
                if ( (this.cbCedula.SelectedIndex != -1) || (this.txtCiPaciente.Text != string.Empty))
                {

                    //este condicional es para verificar que la cedula que se quiere ingresar sea unica. 
                    //Si la datatable tiene almenos un registro significa que ya existe esa cedula en la base de datos
                    if ((MPacientes.BuscarCedula((this.cbCedula.Text + this.txtCiPaciente.Text))).Rows.Count != 0)
                    {
                        MessageBox.Show("Ya el paciente C.I: " + (this.cbCedula.Text + this.txtCiPaciente.Text) + " está ingresado", "Crystal Clear", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtCiPaciente.Text = string.Empty;
                        this.cbCedula.SelectedIndex = -1;
                        this.txtCiPaciente.Focus();
                    }

                    Mostrar();


                }

                
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la conexion de la BD", "Laboratorio Clínico Virgen de Coromoto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbCedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCedula.SelectedIndex != -1)
            {
                if (IsNuevo == true || IsEditar == true)
                {
                    txtCiPaciente.Enabled = true;
                    txtCiPaciente.Focus();
                }
            }
        }

        
    }
}
