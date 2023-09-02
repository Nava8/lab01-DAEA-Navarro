namespace Lab01_02_Sebastian
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtFecha = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.Label();
            this.TBTelefono = new System.Windows.Forms.TextBox();
            this.TBDireccion = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.Label();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.Label();
            this.TBDNI = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFotografia = new System.Windows.Forms.Label();
            this.CBCargo = new System.Windows.Forms.ComboBox();
            this.txtCargo = new System.Windows.Forms.Label();
            this.CBDepartamento = new System.Windows.Forms.ComboBox();
            this.txtDepartamento = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Highlight;
            this.label12.Enabled = false;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(-2, 0);
            this.label12.MinimumSize = new System.Drawing.Size(960, 60);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.label12.Size = new System.Drawing.Size(960, 60);
            this.label12.TabIndex = 9;
            this.label12.Text = "Mantenimiento de Usuarios";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.TBEmail);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.TBTelefono);
            this.groupBox1.Controls.Add(this.TBDireccion);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.TBApellido);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.TBDNI);
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.TBNombre);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Location = new System.Drawing.Point(4, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 227);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(523, 196);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Activo";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(60, 193);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Value = new System.DateTime(2000, 1, 8, 15, 8, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtFecha
            // 
            this.txtFecha.AutoSize = true;
            this.txtFecha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(13, 197);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(42, 15);
            this.txtFecha.TabIndex = 14;
            this.txtFecha.Text = "Fecha:";
            this.txtFecha.Click += new System.EventHandler(this.txtFecha_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(18, 167);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(37, 15);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.Text = "Email:";
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // TBEmail
            // 
            this.TBEmail.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TBEmail.Location = new System.Drawing.Point(58, 165);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(604, 20);
            this.TBEmail.TabIndex = 12;
            this.TBEmail.Text = "sebastian.navarro@tecsup.edu.pe";
            this.TBEmail.TextChanged += new System.EventHandler(this.TBEmail_TextChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.AutoSize = true;
            this.txtTelefono.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(1, 141);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(54, 15);
            this.txtTelefono.TabIndex = 11;
            this.txtTelefono.Text = "Telefono:";
            this.txtTelefono.Click += new System.EventHandler(this.txtTelefono_Click);
            // 
            // TBTelefono
            // 
            this.TBTelefono.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TBTelefono.Location = new System.Drawing.Point(58, 138);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(98, 20);
            this.TBTelefono.TabIndex = 10;
            this.TBTelefono.Text = "992292682";
            this.TBTelefono.TextChanged += new System.EventHandler(this.TBTelefono_TextChanged);
            // 
            // TBDireccion
            // 
            this.TBDireccion.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TBDireccion.Location = new System.Drawing.Point(59, 112);
            this.TBDireccion.Name = "TBDireccion";
            this.TBDireccion.Size = new System.Drawing.Size(603, 20);
            this.TBDireccion.TabIndex = 9;
            this.TBDireccion.Text = "Alto de la luna I-18  segunda etapa José luis Bustamante y Rivero";
            this.TBDireccion.TextChanged += new System.EventHandler(this.TBDireccion_TextChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.AutoSize = true;
            this.txtDireccion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(-2, 115);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(57, 15);
            this.txtDireccion.TabIndex = 8;
            this.txtDireccion.Text = "Direccion:";
            this.txtDireccion.Click += new System.EventHandler(this.txtDireccion_Click);
            // 
            // TBApellido
            // 
            this.TBApellido.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TBApellido.Location = new System.Drawing.Point(59, 85);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(603, 20);
            this.TBApellido.TabIndex = 7;
            this.TBApellido.Text = "Navarro Sacramento ";
            this.TBApellido.TextChanged += new System.EventHandler(this.TBApellido_TextChanged);
            // 
            // txtApellidos
            // 
            this.txtApellidos.AutoSize = true;
            this.txtApellidos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidos.Enabled = false;
            this.txtApellidos.Location = new System.Drawing.Point(1, 88);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(54, 15);
            this.txtApellidos.TabIndex = 6;
            this.txtApellidos.Text = "Apellidos:";
            this.txtApellidos.Click += new System.EventHandler(this.txtApellidos_Click);
            // 
            // TBDNI
            // 
            this.TBDNI.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TBDNI.Location = new System.Drawing.Point(606, 56);
            this.TBDNI.Name = "TBDNI";
            this.TBDNI.Size = new System.Drawing.Size(56, 20);
            this.TBDNI.TabIndex = 5;
            this.TBDNI.Text = "76196645";
            // 
            // txtDNI
            // 
            this.txtDNI.AutoSize = true;
            this.txtDNI.Location = new System.Drawing.Point(571, 59);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(29, 13);
            this.txtDNI.TabIndex = 4;
            this.txtDNI.Text = "DNI:";
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(6, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(49, 15);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Text = "Nombre:";
            this.txtNombre.Click += new System.EventHandler(this.txtNombre_Click);
            // 
            // TBNombre
            // 
            this.TBNombre.BackColor = System.Drawing.SystemColors.Window;
            this.TBNombre.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TBNombre.Location = new System.Drawing.Point(59, 56);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(506, 20);
            this.TBNombre.TabIndex = 3;
            this.TBNombre.Text = "Sebastian Estefano";
            this.TBNombre.TextChanged += new System.EventHandler(this.TBNombre_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.AutoSize = true;
            this.txtCodigo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(6, 37);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(45, 15);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Text = "Codigo:";
            this.txtCodigo.Click += new System.EventHandler(this.txtCodigo_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(55, 37);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(45, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "U10023";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.txtFotografia);
            this.groupBox2.Controls.Add(this.CBCargo);
            this.groupBox2.Controls.Add(this.txtCargo);
            this.groupBox2.Controls.Add(this.CBDepartamento);
            this.groupBox2.Controls.Add(this.txtDepartamento);
            this.groupBox2.Location = new System.Drawing.Point(682, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 227);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion adicional";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(90, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 114);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtFotografia
            // 
            this.txtFotografia.AutoSize = true;
            this.txtFotografia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtFotografia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFotografia.Enabled = false;
            this.txtFotografia.Location = new System.Drawing.Point(23, 111);
            this.txtFotografia.Name = "txtFotografia";
            this.txtFotografia.Size = new System.Drawing.Size(62, 15);
            this.txtFotografia.TabIndex = 4;
            this.txtFotografia.Text = "Fotrografia:";
            this.txtFotografia.Click += new System.EventHandler(this.txtFotografia_Click);
            // 
            // CBCargo
            // 
            this.CBCargo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CBCargo.FormattingEnabled = true;
            this.CBCargo.Location = new System.Drawing.Point(89, 84);
            this.CBCargo.Name = "CBCargo";
            this.CBCargo.Size = new System.Drawing.Size(181, 21);
            this.CBCargo.TabIndex = 3;
            this.CBCargo.Text = "Estudiante";
            this.CBCargo.SelectedIndexChanged += new System.EventHandler(this.CBCargo_SelectedIndexChanged);
            // 
            // txtCargo
            // 
            this.txtCargo.AutoSize = true;
            this.txtCargo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCargo.Enabled = false;
            this.txtCargo.Location = new System.Drawing.Point(45, 84);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(40, 15);
            this.txtCargo.TabIndex = 2;
            this.txtCargo.Text = "Cargo:";
            this.txtCargo.Click += new System.EventHandler(this.txtCargo_Click);
            // 
            // CBDepartamento
            // 
            this.CBDepartamento.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CBDepartamento.FormattingEnabled = true;
            this.CBDepartamento.Location = new System.Drawing.Point(89, 55);
            this.CBDepartamento.Name = "CBDepartamento";
            this.CBDepartamento.Size = new System.Drawing.Size(181, 21);
            this.CBDepartamento.TabIndex = 1;
            this.CBDepartamento.Text = "Arequipa";
            this.CBDepartamento.SelectedIndexChanged += new System.EventHandler(this.CBDepartamento_SelectedIndexChanged);
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.AutoSize = true;
            this.txtDepartamento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartamento.Enabled = false;
            this.txtDepartamento.Location = new System.Drawing.Point(6, 58);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(79, 15);
            this.txtDepartamento.TabIndex = 0;
            this.txtDepartamento.Text = "Departamento:";
            this.txtDepartamento.Click += new System.EventHandler(this.txtDepartamento_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AccessibleName = "";
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Location = new System.Drawing.Point(471, 296);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(122, 44);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModificar.Location = new System.Drawing.Point(599, 296);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(122, 44);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminar.Location = new System.Drawing.Point(727, 295);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 44);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Location = new System.Drawing.Point(857, 295);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 44);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.DNI,
            this.Nombre,
            this.Apellidos,
            this.Direccion,
            this.Telefono,
            this.Email,
            this.Fecha,
            this.Departamento});
            this.dgvUsuarios.Enabled = false;
            this.dgvUsuarios.Location = new System.Drawing.Point(5, 345);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(944, 369);
            this.dgvUsuarios.TabIndex = 19;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fec/Nac";
            this.Fecha.Name = "Fecha";
            // 
            // Departamento
            // 
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 734);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label txtFecha;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.Label txtTelefono;
        private System.Windows.Forms.TextBox TBTelefono;
        private System.Windows.Forms.TextBox TBDireccion;
        private System.Windows.Forms.Label txtDireccion;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.Label txtApellidos;
        private System.Windows.Forms.TextBox TBDNI;
        private System.Windows.Forms.Label txtDNI;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Label txtCodigo;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtFotografia;
        private System.Windows.Forms.ComboBox CBCargo;
        private System.Windows.Forms.Label txtCargo;
        private System.Windows.Forms.ComboBox CBDepartamento;
        private System.Windows.Forms.Label txtDepartamento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
    }
}

