namespace Presentacion
{
    partial class frmUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnContraer = new System.Windows.Forms.Button();
            this.txtCiPaciente = new System.Windows.Forms.TextBox();
            this.PanelIngreso = new System.Windows.Forms.Panel();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCedula = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLugarNac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExpandir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBuscar = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAnular = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.PanelIngreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnContraer
            // 
            this.btnContraer.BackColor = System.Drawing.Color.Transparent;
            this.btnContraer.BackgroundImage = global::Presentacion.Properties.Resources.arrows_contract;
            this.btnContraer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnContraer.FlatAppearance.BorderSize = 0;
            this.btnContraer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContraer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnContraer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContraer.Location = new System.Drawing.Point(24, 44);
            this.btnContraer.Margin = new System.Windows.Forms.Padding(4);
            this.btnContraer.Name = "btnContraer";
            this.btnContraer.Size = new System.Drawing.Size(33, 31);
            this.btnContraer.TabIndex = 52;
            this.btnContraer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContraer.UseVisualStyleBackColor = false;
            // 
            // txtCiPaciente
            // 
            this.txtCiPaciente.BackColor = System.Drawing.SystemColors.Control;
            this.txtCiPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCiPaciente.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCiPaciente.Location = new System.Drawing.Point(123, 135);
            this.txtCiPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCiPaciente.MaxLength = 50;
            this.txtCiPaciente.Name = "txtCiPaciente";
            this.txtCiPaciente.Size = new System.Drawing.Size(278, 39);
            this.txtCiPaciente.TabIndex = 113;
            // 
            // PanelIngreso
            // 
            this.PanelIngreso.BackColor = System.Drawing.Color.White;
            this.PanelIngreso.Controls.Add(this.label5);
            this.PanelIngreso.Controls.Add(this.comboBox1);
            this.PanelIngreso.Controls.Add(this.label16);
            this.PanelIngreso.Controls.Add(this.btnContraer);
            this.PanelIngreso.Controls.Add(this.txtCiPaciente);
            this.PanelIngreso.Controls.Add(this.txtCorreo);
            this.PanelIngreso.Controls.Add(this.label11);
            this.PanelIngreso.Controls.Add(this.txtDireccion);
            this.PanelIngreso.Controls.Add(this.label10);
            this.PanelIngreso.Controls.Add(this.txtTelefono);
            this.PanelIngreso.Controls.Add(this.label6);
            this.PanelIngreso.Controls.Add(this.cbCedula);
            this.PanelIngreso.Controls.Add(this.label2);
            this.PanelIngreso.Controls.Add(this.btnCancelar);
            this.PanelIngreso.Controls.Add(this.btnGuardar);
            this.PanelIngreso.Controls.Add(this.txtNombre);
            this.PanelIngreso.Controls.Add(this.label4);
            this.PanelIngreso.Controls.Add(this.txtLugarNac);
            this.PanelIngreso.Controls.Add(this.label1);
            this.PanelIngreso.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelIngreso.Location = new System.Drawing.Point(990, 0);
            this.PanelIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.PanelIngreso.Name = "PanelIngreso";
            this.PanelIngreso.Size = new System.Drawing.Size(436, 753);
            this.PanelIngreso.TabIndex = 0;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.SystemColors.Control;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCorreo.Location = new System.Drawing.Point(36, 537);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(365, 39);
            this.txtCorreo.TabIndex = 107;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(31, 505);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 32);
            this.label11.TabIndex = 108;
            this.label11.Text = "Correo:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.SystemColors.Control;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDireccion.Location = new System.Drawing.Point(36, 369);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(365, 39);
            this.txtDireccion.TabIndex = 105;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkCyan;
            this.label10.Location = new System.Drawing.Point(31, 337);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 32);
            this.label10.TabIndex = 106;
            this.label10.Text = "Dirección:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.Control;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefono.Location = new System.Drawing.Point(36, 462);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.MaxLength = 11;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(365, 39);
            this.txtTelefono.TabIndex = 97;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(31, 430);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 32);
            this.label6.TabIndex = 98;
            this.label6.Text = "Teléfono:";
            // 
            // cbCedula
            // 
            this.cbCedula.BackColor = System.Drawing.SystemColors.Control;
            this.cbCedula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCedula.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.cbCedula.FormattingEnabled = true;
            this.cbCedula.Items.AddRange(new object[] {
            "V-",
            "E-"});
            this.cbCedula.Location = new System.Drawing.Point(31, 135);
            this.cbCedula.Margin = new System.Windows.Forms.Padding(4);
            this.cbCedula.Name = "cbCedula";
            this.cbCedula.Size = new System.Drawing.Size(84, 39);
            this.cbCedula.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(26, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 32);
            this.label2.TabIndex = 29;
            this.label2.Text = "Cédula del Usuario:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = global::Presentacion.Properties.Resources.cancelar;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(141, 44);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(33, 31);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BackgroundImage = global::Presentacion.Properties.Resources.disquete;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(82, 44);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(33, 31);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.Location = new System.Drawing.Point(37, 212);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(364, 39);
            this.txtNombre.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(26, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 32);
            this.label4.TabIndex = 32;
            this.label4.Text = "Nombre:";
            // 
            // txtLugarNac
            // 
            this.txtLugarNac.BackColor = System.Drawing.SystemColors.Control;
            this.txtLugarNac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLugarNac.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugarNac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLugarNac.Location = new System.Drawing.Point(36, 287);
            this.txtLugarNac.Margin = new System.Windows.Forms.Padding(4);
            this.txtLugarNac.MaxLength = 50;
            this.txtLugarNac.Name = "txtLugarNac";
            this.txtLugarNac.Size = new System.Drawing.Size(365, 39);
            this.txtLugarNac.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(31, 255);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 32);
            this.label1.TabIndex = 58;
            this.label1.Text = "Contraseña:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBuscar.Location = new System.Drawing.Point(160, 46);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.MaxLength = 50;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(379, 39);
            this.txtBuscar.TabIndex = 44;
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.AllowUserToOrderColumns = true;
            this.dataListado.AllowUserToResizeColumns = false;
            this.dataListado.AllowUserToResizeRows = false;
            this.dataListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListado.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataListado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListado.Location = new System.Drawing.Point(0, 0);
            this.dataListado.Margin = new System.Windows.Forms.Padding(4);
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.RowHeadersVisible = false;
            this.dataListado.RowHeadersWidth = 51;
            this.dataListado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataListado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(990, 637);
            this.dataListado.TabIndex = 37;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.BackgroundImage = global::Presentacion.Properties.Resources.impresora;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(729, 44);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(33, 31);
            this.btnImprimir.TabIndex = 41;
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.PanelIngreso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1426, 753);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(990, 753);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataListado);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 116);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(990, 637);
            this.panel5.TabIndex = 38;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btnExpandir);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.cbBuscar);
            this.panel4.Controls.Add(this.btnEliminar);
            this.panel4.Controls.Add(this.btnNuevo);
            this.panel4.Controls.Add(this.lblTotal);
            this.panel4.Controls.Add(this.btnAnular);
            this.panel4.Controls.Add(this.btnImprimir);
            this.panel4.Controls.Add(this.txtBuscar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(990, 116);
            this.panel4.TabIndex = 37;
            // 
            // btnExpandir
            // 
            this.btnExpandir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpandir.BackColor = System.Drawing.Color.Transparent;
            this.btnExpandir.BackgroundImage = global::Presentacion.Properties.Resources.arrows_expand;
            this.btnExpandir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExpandir.FlatAppearance.BorderSize = 0;
            this.btnExpandir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpandir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExpandir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpandir.Location = new System.Drawing.Point(953, 44);
            this.btnExpandir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExpandir.Name = "btnExpandir";
            this.btnExpandir.Size = new System.Drawing.Size(33, 31);
            this.btnExpandir.TabIndex = 51;
            this.btnExpandir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExpandir.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(17, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 32);
            this.label3.TabIndex = 49;
            this.label3.Text = "Buscar por:";
            // 
            // cbBuscar
            // 
            this.cbBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.cbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuscar.Font = new System.Drawing.Font("Segoe UI Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscar.FormattingEnabled = true;
            this.cbBuscar.Items.AddRange(new object[] {
            "Cedula",
            "Nombre"});
            this.cbBuscar.Location = new System.Drawing.Point(23, 47);
            this.cbBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.cbBuscar.Name = "cbBuscar";
            this.cbBuscar.Size = new System.Drawing.Size(116, 38);
            this.cbBuscar.TabIndex = 48;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackgroundImage = global::Presentacion.Properties.Resources.basura;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(596, 44);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(133, 123, 133, 123);
            this.btnEliminar.Size = new System.Drawing.Size(33, 31);
            this.btnEliminar.TabIndex = 47;
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.BackgroundImage = global::Presentacion.Properties.Resources.anadir;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(912, 44);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(33, 31);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Teal;
            this.lblTotal.Location = new System.Drawing.Point(156, 89);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 23);
            this.lblTotal.TabIndex = 45;
            this.lblTotal.Text = "label5";
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.Color.Transparent;
            this.btnAnular.BackgroundImage = global::Presentacion.Properties.Resources.discapacitado;
            this.btnAnular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnular.FlatAppearance.BorderSize = 0;
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnular.Location = new System.Drawing.Point(663, 46);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(33, 31);
            this.btnAnular.TabIndex = 43;
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnular.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkCyan;
            this.label16.Location = new System.Drawing.Point(231, 38);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(161, 32);
            this.label16.TabIndex = 116;
            this.label16.Text = "ID del Usuario:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Activo",
            "Anulado"});
            this.comboBox1.Location = new System.Drawing.Point(37, 622);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(364, 39);
            this.comboBox1.TabIndex = 117;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(31, 586);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 32);
            this.label5.TabIndex = 118;
            this.label5.Text = "Nivel de Acceso:";
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 753);
            this.Controls.Add(this.panel1);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.PanelIngreso.ResumeLayout(false);
            this.PanelIngreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnExpandir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel PanelIngreso;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnContraer;
        private System.Windows.Forms.TextBox txtCiPaciente;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLugarNac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}