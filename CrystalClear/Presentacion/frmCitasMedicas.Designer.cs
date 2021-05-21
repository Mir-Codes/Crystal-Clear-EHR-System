namespace Presentacion
{
    partial class frmCitasMedicas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExpandir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBuscar = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.PanelIngreso = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.rbPagoRealizadoNo = new System.Windows.Forms.RadioButton();
            this.rbPagoRealizadoSi = new System.Windows.Forms.RadioButton();
            this.label20 = new System.Windows.Forms.Label();
            this.cbMetodoPago = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.chkbxEvalCardiovascular = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.chkbxECG = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.chkbxEKG = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gp_consulta = new System.Windows.Forms.GroupBox();
            this.chkbxConsulta = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumTurno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnContraer = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCiPaciente = new System.Windows.Forms.TextBox();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbCedula = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.panel4.SuspendLayout();
            this.PanelIngreso.SuspendLayout();
            this.gp_consulta.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataListado.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListado.Location = new System.Drawing.Point(0, 116);
            this.dataListado.Margin = new System.Windows.Forms.Padding(4);
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.RowHeadersVisible = false;
            this.dataListado.RowHeadersWidth = 51;
            this.dataListado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataListado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(677, 939);
            this.dataListado.TabIndex = 40;
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
            this.panel4.Size = new System.Drawing.Size(677, 116);
            this.panel4.TabIndex = 39;
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
            this.btnExpandir.Location = new System.Drawing.Point(640, 44);
            this.btnExpandir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExpandir.Name = "btnExpandir";
            this.btnExpandir.Size = new System.Drawing.Size(33, 31);
            this.btnExpandir.TabIndex = 51;
            this.btnExpandir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExpandir.UseVisualStyleBackColor = false;
            this.btnExpandir.Click += new System.EventHandler(this.btnExpandir_Click);
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
            this.btnNuevo.Location = new System.Drawing.Point(599, 44);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(33, 31);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            // PanelIngreso
            // 
            this.PanelIngreso.AutoScroll = true;
            this.PanelIngreso.BackColor = System.Drawing.Color.White;
            this.PanelIngreso.Controls.Add(this.label22);
            this.PanelIngreso.Controls.Add(this.dateTimePicker1);
            this.PanelIngreso.Controls.Add(this.txtComentarios);
            this.PanelIngreso.Controls.Add(this.label21);
            this.PanelIngreso.Controls.Add(this.rbPagoRealizadoNo);
            this.PanelIngreso.Controls.Add(this.rbPagoRealizadoSi);
            this.PanelIngreso.Controls.Add(this.label20);
            this.PanelIngreso.Controls.Add(this.cbMetodoPago);
            this.PanelIngreso.Controls.Add(this.label19);
            this.PanelIngreso.Controls.Add(this.txtMonto);
            this.PanelIngreso.Controls.Add(this.label18);
            this.PanelIngreso.Controls.Add(this.chkbxEvalCardiovascular);
            this.PanelIngreso.Controls.Add(this.label17);
            this.PanelIngreso.Controls.Add(this.chkbxECG);
            this.PanelIngreso.Controls.Add(this.label16);
            this.PanelIngreso.Controls.Add(this.chkbxEKG);
            this.PanelIngreso.Controls.Add(this.label10);
            this.PanelIngreso.Controls.Add(this.gp_consulta);
            this.PanelIngreso.Controls.Add(this.txtNumTurno);
            this.PanelIngreso.Controls.Add(this.label1);
            this.PanelIngreso.Controls.Add(this.btnContraer);
            this.PanelIngreso.Controls.Add(this.label15);
            this.PanelIngreso.Controls.Add(this.label14);
            this.PanelIngreso.Controls.Add(this.txtCiPaciente);
            this.PanelIngreso.Controls.Add(this.txtTalla);
            this.PanelIngreso.Controls.Add(this.label12);
            this.PanelIngreso.Controls.Add(this.txtPeso);
            this.PanelIngreso.Controls.Add(this.label13);
            this.PanelIngreso.Controls.Add(this.txtCorreo);
            this.PanelIngreso.Controls.Add(this.label11);
            this.PanelIngreso.Controls.Add(this.txtTelefono);
            this.PanelIngreso.Controls.Add(this.label6);
            this.PanelIngreso.Controls.Add(this.dtNacimiento);
            this.PanelIngreso.Controls.Add(this.cbCedula);
            this.PanelIngreso.Controls.Add(this.label2);
            this.PanelIngreso.Controls.Add(this.cbSexo);
            this.PanelIngreso.Controls.Add(this.label5);
            this.PanelIngreso.Controls.Add(this.btnCancelar);
            this.PanelIngreso.Controls.Add(this.btnGuardar);
            this.PanelIngreso.Controls.Add(this.txtNombre);
            this.PanelIngreso.Controls.Add(this.label4);
            this.PanelIngreso.Controls.Add(this.label8);
            this.PanelIngreso.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelIngreso.Location = new System.Drawing.Point(677, 0);
            this.PanelIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.PanelIngreso.Name = "PanelIngreso";
            this.PanelIngreso.Size = new System.Drawing.Size(499, 1055);
            this.PanelIngreso.TabIndex = 38;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.DarkCyan;
            this.label22.Location = new System.Drawing.Point(32, 817);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(185, 32);
            this.label22.TabIndex = 138;
            this.label22.Text = "Hora de entrada:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(37, 852);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 137;
            // 
            // txtComentarios
            // 
            this.txtComentarios.BackColor = System.Drawing.SystemColors.Control;
            this.txtComentarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComentarios.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtComentarios.Location = new System.Drawing.Point(38, 934);
            this.txtComentarios.Margin = new System.Windows.Forms.Padding(4);
            this.txtComentarios.MaxLength = 11;
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(380, 86);
            this.txtComentarios.TabIndex = 135;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.DarkCyan;
            this.label21.Location = new System.Drawing.Point(33, 902);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(147, 32);
            this.label21.TabIndex = 136;
            this.label21.Text = "Comentarios:";
            // 
            // rbPagoRealizadoNo
            // 
            this.rbPagoRealizadoNo.AutoSize = true;
            this.rbPagoRealizadoNo.Location = new System.Drawing.Point(335, 853);
            this.rbPagoRealizadoNo.Name = "rbPagoRealizadoNo";
            this.rbPagoRealizadoNo.Size = new System.Drawing.Size(47, 21);
            this.rbPagoRealizadoNo.TabIndex = 134;
            this.rbPagoRealizadoNo.TabStop = true;
            this.rbPagoRealizadoNo.Text = "No";
            this.rbPagoRealizadoNo.UseVisualStyleBackColor = true;
            // 
            // rbPagoRealizadoSi
            // 
            this.rbPagoRealizadoSi.AutoSize = true;
            this.rbPagoRealizadoSi.Location = new System.Drawing.Point(283, 853);
            this.rbPagoRealizadoSi.Name = "rbPagoRealizadoSi";
            this.rbPagoRealizadoSi.Size = new System.Drawing.Size(41, 21);
            this.rbPagoRealizadoSi.TabIndex = 133;
            this.rbPagoRealizadoSi.TabStop = true;
            this.rbPagoRealizadoSi.Text = "Si";
            this.rbPagoRealizadoSi.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DarkCyan;
            this.label20.Location = new System.Drawing.Point(269, 817);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(168, 32);
            this.label20.TabIndex = 132;
            this.label20.Text = "Pago realizado:";
            // 
            // cbMetodoPago
            // 
            this.cbMetodoPago.BackColor = System.Drawing.SystemColors.Control;
            this.cbMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMetodoPago.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMetodoPago.FormattingEnabled = true;
            this.cbMetodoPago.Items.AddRange(new object[] {
            "Transferencia",
            "Efectivo",
            "Pago Movil"});
            this.cbMetodoPago.Location = new System.Drawing.Point(38, 748);
            this.cbMetodoPago.Margin = new System.Windows.Forms.Padding(4);
            this.cbMetodoPago.Name = "cbMetodoPago";
            this.cbMetodoPago.Size = new System.Drawing.Size(194, 40);
            this.cbMetodoPago.TabIndex = 130;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkCyan;
            this.label19.Location = new System.Drawing.Point(32, 712);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(188, 32);
            this.label19.TabIndex = 131;
            this.label19.Text = "Metodo de pago:";
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.SystemColors.Control;
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMonto.Location = new System.Drawing.Point(247, 748);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonto.MaxLength = 11;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(178, 39);
            this.txtMonto.TabIndex = 128;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DarkCyan;
            this.label18.Location = new System.Drawing.Point(242, 716);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 32);
            this.label18.TabIndex = 129;
            this.label18.Text = "Monto:";
            // 
            // chkbxEvalCardiovascular
            // 
            this.chkbxEvalCardiovascular.AutoSize = true;
            this.chkbxEvalCardiovascular.Location = new System.Drawing.Point(256, 654);
            this.chkbxEvalCardiovascular.Name = "chkbxEvalCardiovascular";
            this.chkbxEvalCardiovascular.Size = new System.Drawing.Size(18, 17);
            this.chkbxEvalCardiovascular.TabIndex = 127;
            this.chkbxEvalCardiovascular.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkCyan;
            this.label17.Location = new System.Drawing.Point(281, 640);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(214, 32);
            this.label17.TabIndex = 126;
            this.label17.Text = "Eval. Cardiovascular";
            // 
            // chkbxECG
            // 
            this.chkbxECG.AutoSize = true;
            this.chkbxECG.Location = new System.Drawing.Point(256, 610);
            this.chkbxECG.Name = "chkbxECG";
            this.chkbxECG.Size = new System.Drawing.Size(18, 17);
            this.chkbxECG.TabIndex = 125;
            this.chkbxECG.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkCyan;
            this.label16.Location = new System.Drawing.Point(278, 596);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 32);
            this.label16.TabIndex = 124;
            this.label16.Text = "ECG";
            // 
            // chkbxEKG
            // 
            this.chkbxEKG.AutoSize = true;
            this.chkbxEKG.Location = new System.Drawing.Point(256, 561);
            this.chkbxEKG.Name = "chkbxEKG";
            this.chkbxEKG.Size = new System.Drawing.Size(18, 17);
            this.chkbxEKG.TabIndex = 123;
            this.chkbxEKG.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkCyan;
            this.label10.Location = new System.Drawing.Point(278, 547);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 32);
            this.label10.TabIndex = 122;
            this.label10.Text = "EKG";
            // 
            // gp_consulta
            // 
            this.gp_consulta.AutoSize = true;
            this.gp_consulta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gp_consulta.Controls.Add(this.chkbxConsulta);
            this.gp_consulta.Controls.Add(this.comboBox1);
            this.gp_consulta.Controls.Add(this.label7);
            this.gp_consulta.Controls.Add(this.label9);
            this.gp_consulta.Location = new System.Drawing.Point(37, 530);
            this.gp_consulta.Name = "gp_consulta";
            this.gp_consulta.Size = new System.Drawing.Size(209, 164);
            this.gp_consulta.TabIndex = 121;
            this.gp_consulta.TabStop = false;
            // 
            // chkbxConsulta
            // 
            this.chkbxConsulta.AutoSize = true;
            this.chkbxConsulta.Location = new System.Drawing.Point(8, 32);
            this.chkbxConsulta.Name = "chkbxConsulta";
            this.chkbxConsulta.Size = new System.Drawing.Size(18, 17);
            this.chkbxConsulta.TabIndex = 121;
            this.chkbxConsulta.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1era vez",
            "Sucesiva"});
            this.comboBox1.Location = new System.Drawing.Point(8, 102);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 40);
            this.comboBox1.TabIndex = 118;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(2, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 32);
            this.label7.TabIndex = 119;
            this.label7.Text = "Tipo Consulta:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(30, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 32);
            this.label9.TabIndex = 120;
            this.label9.Text = "Consulta";
            // 
            // txtNumTurno
            // 
            this.txtNumTurno.BackColor = System.Drawing.SystemColors.Control;
            this.txtNumTurno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumTurno.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumTurno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumTurno.Location = new System.Drawing.Point(247, 63);
            this.txtNumTurno.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumTurno.MaxLength = 50;
            this.txtNumTurno.Name = "txtNumTurno";
            this.txtNumTurno.Size = new System.Drawing.Size(70, 39);
            this.txtNumTurno.TabIndex = 116;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(241, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 32);
            this.label1.TabIndex = 117;
            this.label1.Text = "Turno:";
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
            this.btnContraer.Click += new System.EventHandler(this.btnContraer_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Control;
            this.label15.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label15.Location = new System.Drawing.Point(349, 468);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 32);
            this.label15.TabIndex = 115;
            this.label15.Text = "Mt";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label14.Location = new System.Drawing.Point(166, 468);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 32);
            this.label14.TabIndex = 114;
            this.label14.Text = "Kg";
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
            // txtTalla
            // 
            this.txtTalla.BackColor = System.Drawing.SystemColors.Control;
            this.txtTalla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTalla.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTalla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTalla.Location = new System.Drawing.Point(222, 466);
            this.txtTalla.Margin = new System.Windows.Forms.Padding(4);
            this.txtTalla.MaxLength = 5;
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(178, 39);
            this.txtTalla.TabIndex = 111;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkCyan;
            this.label12.Location = new System.Drawing.Point(217, 434);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 32);
            this.label12.TabIndex = 112;
            this.label12.Text = "Talla:";
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.SystemColors.Control;
            this.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPeso.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPeso.Location = new System.Drawing.Point(36, 466);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeso.MaxLength = 5;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(178, 39);
            this.txtPeso.TabIndex = 109;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkCyan;
            this.label13.Location = new System.Drawing.Point(31, 434);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 32);
            this.label13.TabIndex = 110;
            this.label13.Text = "Peso:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.SystemColors.Control;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCorreo.Location = new System.Drawing.Point(223, 387);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(178, 39);
            this.txtCorreo.TabIndex = 107;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(218, 355);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 32);
            this.label11.TabIndex = 108;
            this.label11.Text = "Correo:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.Control;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefono.Location = new System.Drawing.Point(37, 387);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.MaxLength = 11;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(178, 39);
            this.txtTelefono.TabIndex = 97;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(32, 355);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 32);
            this.label6.TabIndex = 98;
            this.label6.Text = "Teléfono:";
            // 
            // dtNacimiento
            // 
            this.dtNacimiento.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dtNacimiento.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNacimiento.Location = new System.Drawing.Point(110, 298);
            this.dtNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.dtNacimiento.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtNacimiento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtNacimiento.Name = "dtNacimiento";
            this.dtNacimiento.Size = new System.Drawing.Size(169, 39);
            this.dtNacimiento.TabIndex = 96;
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
            this.label2.Size = new System.Drawing.Size(182, 32);
            this.label2.TabIndex = 29;
            this.label2.Text = "Cédula paciente:";
            // 
            // cbSexo
            // 
            this.cbSexo.BackColor = System.Drawing.SystemColors.Control;
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cbSexo.Location = new System.Drawing.Point(30, 297);
            this.cbSexo.Margin = new System.Windows.Forms.Padding(4);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(62, 40);
            this.cbSexo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(117, 265);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 32);
            this.label5.TabIndex = 34;
            this.label5.Text = "Fecha Nac.";
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
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.Location = new System.Drawing.Point(30, 212);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(371, 39);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(25, 265);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 32);
            this.label8.TabIndex = 54;
            this.label8.Text = "Sexo:";
            // 
            // frmCitasMedicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 1055);
            this.Controls.Add(this.dataListado);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.PanelIngreso);
            this.Name = "frmCitasMedicas";
            this.Text = "Cuadernito";
            this.Load += new System.EventHandler(this.Cuadernito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.PanelIngreso.ResumeLayout(false);
            this.PanelIngreso.PerformLayout();
            this.gp_consulta.ResumeLayout(false);
            this.gp_consulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.TextBox txtNumTurno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnContraer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCiPaciente;
        private System.Windows.Forms.TextBox txtTalla;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtNacimiento;
        private System.Windows.Forms.ComboBox cbCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gp_consulta;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkbxConsulta;
        private System.Windows.Forms.CheckBox chkbxECG;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox chkbxEKG;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkbxEvalCardiovascular;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.RadioButton rbPagoRealizadoNo;
        private System.Windows.Forms.RadioButton rbPagoRealizadoSi;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbMetodoPago;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label18;
    }
}