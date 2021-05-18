using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmCitasMedicas : Form
    {
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
    }
}
