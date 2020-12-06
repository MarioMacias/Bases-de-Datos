namespace Archivos
{
    partial class FormEntidad
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntidad));
            this.dgv_Entidad = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secuencialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secuencialIndexadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hashEstaticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secundarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.árbolBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indicePrimarioBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indiceSecundarioBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indicePriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Cabecera = new System.Windows.Forms.Label();
            this.btn_CrearEntidad = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.tb_entidad = new System.Windows.Forms.TextBox();
            this.btn_Atributo = new System.Windows.Forms.Button();
            this.lb_atributo = new System.Windows.Forms.Label();
            this.tb_modificar = new System.Windows.Forms.TextBox();
            this.lbTablas = new System.Windows.Forms.Label();
            this.groupBoxEntidades = new System.Windows.Forms.GroupBox();
            this.lbBasedeDatos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Entidad)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBoxEntidades.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Entidad
            // 
            this.dgv_Entidad.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgv_Entidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Entidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Entidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Entidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Entidad.Location = new System.Drawing.Point(315, 93);
            this.dgv_Entidad.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Entidad.Name = "dgv_Entidad";
            this.dgv_Entidad.ReadOnly = true;
            this.dgv_Entidad.RowHeadersWidth = 51;
            this.dgv_Entidad.Size = new System.Drawing.Size(504, 402);
            this.dgv_Entidad.TabIndex = 0;
            this.dgv_Entidad.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Entidad_CellMouseDown);
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle1;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoArchivoToolStripMenuItem,
            this.abrirArchivoToolStripMenuItem,
            this.cerrarArchivoToolStripMenuItem,
            this.nuevoRegistroToolStripMenuItem,
            this.indiceToolStripMenuItem,
            this.árbolBToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.ejecutarSQLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(856, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoArchivoToolStripMenuItem
            // 
            this.nuevoArchivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nuevoArchivoToolStripMenuItem.Name = "nuevoArchivoToolStripMenuItem";
            this.nuevoArchivoToolStripMenuItem.Size = new System.Drawing.Size(89, 26);
            this.nuevoArchivoToolStripMenuItem.Text = "Nueva BD";
            this.nuevoArchivoToolStripMenuItem.Click += new System.EventHandler(this.nuevoArchivoToolStripMenuItem_Click);
            // 
            // abrirArchivoToolStripMenuItem
            // 
            this.abrirArchivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.abrirArchivoToolStripMenuItem.Name = "abrirArchivoToolStripMenuItem";
            this.abrirArchivoToolStripMenuItem.Size = new System.Drawing.Size(80, 26);
            this.abrirArchivoToolStripMenuItem.Text = "Abrir BD";
            this.abrirArchivoToolStripMenuItem.Click += new System.EventHandler(this.abrirArchivoToolStripMenuItem_Click);
            // 
            // cerrarArchivoToolStripMenuItem
            // 
            this.cerrarArchivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cerrarArchivoToolStripMenuItem.Name = "cerrarArchivoToolStripMenuItem";
            this.cerrarArchivoToolStripMenuItem.Size = new System.Drawing.Size(87, 26);
            this.cerrarArchivoToolStripMenuItem.Text = "Cerrar BD";
            this.cerrarArchivoToolStripMenuItem.Click += new System.EventHandler(this.cerrarArchivoToolStripMenuItem_Click);
            // 
            // nuevoRegistroToolStripMenuItem
            // 
            this.nuevoRegistroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secuencialToolStripMenuItem,
            this.secuencialIndexadoToolStripMenuItem,
            this.hashEstaticoToolStripMenuItem});
            this.nuevoRegistroToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nuevoRegistroToolStripMenuItem.Name = "nuevoRegistroToolStripMenuItem";
            this.nuevoRegistroToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.nuevoRegistroToolStripMenuItem.Text = "Datos";
            // 
            // secuencialToolStripMenuItem
            // 
            this.secuencialToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.secuencialToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.secuencialToolStripMenuItem.Name = "secuencialToolStripMenuItem";
            this.secuencialToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.secuencialToolStripMenuItem.Text = "Secuencial";
            this.secuencialToolStripMenuItem.Click += new System.EventHandler(this.secuencialToolStripMenuItem_Click_1);
            // 
            // secuencialIndexadoToolStripMenuItem
            // 
            this.secuencialIndexadoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.secuencialIndexadoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.secuencialIndexadoToolStripMenuItem.Name = "secuencialIndexadoToolStripMenuItem";
            this.secuencialIndexadoToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.secuencialIndexadoToolStripMenuItem.Text = "Secuencial Indexado";
            this.secuencialIndexadoToolStripMenuItem.Visible = false;
            this.secuencialIndexadoToolStripMenuItem.Click += new System.EventHandler(this.secuencialIndexadoToolStripMenuItem_Click);
            // 
            // hashEstaticoToolStripMenuItem
            // 
            this.hashEstaticoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hashEstaticoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hashEstaticoToolStripMenuItem.Name = "hashEstaticoToolStripMenuItem";
            this.hashEstaticoToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.hashEstaticoToolStripMenuItem.Text = "Hash Estatico";
            this.hashEstaticoToolStripMenuItem.Visible = false;
            this.hashEstaticoToolStripMenuItem.Click += new System.EventHandler(this.hashEstaticoToolStripMenuItem_Click);
            // 
            // indiceToolStripMenuItem
            // 
            this.indiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.primarioToolStripMenuItem,
            this.secundarioToolStripMenuItem,
            this.hashToolStripMenuItem});
            this.indiceToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.indiceToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Gray;
            this.indiceToolStripMenuItem.Name = "indiceToolStripMenuItem";
            this.indiceToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.indiceToolStripMenuItem.Text = "Indice";
            this.indiceToolStripMenuItem.Visible = false;
            // 
            // primarioToolStripMenuItem
            // 
            this.primarioToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.primarioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.primarioToolStripMenuItem.Name = "primarioToolStripMenuItem";
            this.primarioToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.primarioToolStripMenuItem.Text = "Primario";
            this.primarioToolStripMenuItem.Click += new System.EventHandler(this.primarioToolStripMenuItem_Click);
            // 
            // secundarioToolStripMenuItem
            // 
            this.secundarioToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.secundarioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.secundarioToolStripMenuItem.Name = "secundarioToolStripMenuItem";
            this.secundarioToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.secundarioToolStripMenuItem.Text = "Secundario";
            this.secundarioToolStripMenuItem.Click += new System.EventHandler(this.secundarioToolStripMenuItem_Click);
            // 
            // hashToolStripMenuItem
            // 
            this.hashToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.hashToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hashToolStripMenuItem.Name = "hashToolStripMenuItem";
            this.hashToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.hashToolStripMenuItem.Text = "Hash";
            this.hashToolStripMenuItem.Visible = false;
            this.hashToolStripMenuItem.Click += new System.EventHandler(this.hashToolStripMenuItem_Click);
            // 
            // árbolBToolStripMenuItem
            // 
            this.árbolBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.indicePrimarioBToolStripMenuItem,
            this.indiceSecundarioBToolStripMenuItem});
            this.árbolBToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.árbolBToolStripMenuItem.Name = "árbolBToolStripMenuItem";
            this.árbolBToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.árbolBToolStripMenuItem.Text = "Árbol B+";
            this.árbolBToolStripMenuItem.Visible = false;
            // 
            // indicePrimarioBToolStripMenuItem
            // 
            this.indicePrimarioBToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.indicePrimarioBToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.indicePrimarioBToolStripMenuItem.Name = "indicePrimarioBToolStripMenuItem";
            this.indicePrimarioBToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.indicePrimarioBToolStripMenuItem.Text = "Primario B+";
            this.indicePrimarioBToolStripMenuItem.Click += new System.EventHandler(this.indicePrimarioBToolStripMenuItem_Click);
            // 
            // indiceSecundarioBToolStripMenuItem
            // 
            this.indiceSecundarioBToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.indiceSecundarioBToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.indiceSecundarioBToolStripMenuItem.Name = "indiceSecundarioBToolStripMenuItem";
            this.indiceSecundarioBToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.indiceSecundarioBToolStripMenuItem.Text = "Secundario B+";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosToolStripMenuItem,
            this.registrosToolStripMenuItem,
            this.indicePriToolStripMenuItem});
            this.consultaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Visible = false;
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click_1);
            // 
            // datosToolStripMenuItem
            // 
            this.datosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.datosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.datosToolStripMenuItem.Name = "datosToolStripMenuItem";
            this.datosToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.datosToolStripMenuItem.Text = "Datos";
            this.datosToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.registrosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.registrosToolStripMenuItem.Text = "Registros";
            this.registrosToolStripMenuItem.Click += new System.EventHandler(this.registrosToolStripMenuItem_Click);
            // 
            // indicePriToolStripMenuItem
            // 
            this.indicePriToolStripMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.indicePriToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.indicePriToolStripMenuItem.Name = "indicePriToolStripMenuItem";
            this.indicePriToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.indicePriToolStripMenuItem.Text = "Indices";
            this.indicePriToolStripMenuItem.Click += new System.EventHandler(this.indicePrimarioToolStripMenuItem_Click);
            // 
            // ejecutarSQLToolStripMenuItem
            // 
            this.ejecutarSQLToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ejecutarSQLToolStripMenuItem.Name = "ejecutarSQLToolStripMenuItem";
            this.ejecutarSQLToolStripMenuItem.Size = new System.Drawing.Size(106, 26);
            this.ejecutarSQLToolStripMenuItem.Text = "Ejecutar SQL";
            this.ejecutarSQLToolStripMenuItem.Click += new System.EventHandler(this.ejecutarSQLToolStripMenuItem_Click);
            // 
            // lbl_Cabecera
            // 
            this.lbl_Cabecera.AutoSize = true;
            this.lbl_Cabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cabecera.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Cabecera.Location = new System.Drawing.Point(724, 53);
            this.lbl_Cabecera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Cabecera.Name = "lbl_Cabecera";
            this.lbl_Cabecera.Size = new System.Drawing.Size(119, 25);
            this.lbl_Cabecera.TabIndex = 2;
            this.lbl_Cabecera.Text = "Cabecera: ";
            this.lbl_Cabecera.Visible = false;
            // 
            // btn_CrearEntidad
            // 
            this.btn_CrearEntidad.BackColor = System.Drawing.Color.Black;
            this.btn_CrearEntidad.FlatAppearance.BorderSize = 0;
            this.btn_CrearEntidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CrearEntidad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_CrearEntidad.Location = new System.Drawing.Point(76, 94);
            this.btn_CrearEntidad.Margin = new System.Windows.Forms.Padding(1);
            this.btn_CrearEntidad.Name = "btn_CrearEntidad";
            this.btn_CrearEntidad.Size = new System.Drawing.Size(123, 28);
            this.btn_CrearEntidad.TabIndex = 3;
            this.btn_CrearEntidad.Text = "Nueva tabla";
            this.btn_CrearEntidad.UseVisualStyleBackColor = false;
            this.btn_CrearEntidad.Click += new System.EventHandler(this.btn_CrearEntidad_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.Black;
            this.btn_Modificar.FlatAppearance.BorderSize = 0;
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modificar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Modificar.Location = new System.Drawing.Point(76, 187);
            this.btn_Modificar.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(123, 28);
            this.btn_Modificar.TabIndex = 4;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.BackColor = System.Drawing.Color.Black;
            this.btn_Borrar.FlatAppearance.BorderSize = 0;
            this.btn_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Borrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Borrar.Location = new System.Drawing.Point(76, 265);
            this.btn_Borrar.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(123, 28);
            this.btn_Borrar.TabIndex = 5;
            this.btn_Borrar.Text = "Borrar";
            this.btn_Borrar.UseVisualStyleBackColor = false;
            this.btn_Borrar.Click += new System.EventHandler(this.btn_Borrar_Click);
            // 
            // tb_entidad
            // 
            this.tb_entidad.BackColor = System.Drawing.Color.Gray;
            this.tb_entidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_entidad.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.tb_entidad.Location = new System.Drawing.Point(16, 42);
            this.tb_entidad.Margin = new System.Windows.Forms.Padding(4);
            this.tb_entidad.Name = "tb_entidad";
            this.tb_entidad.Size = new System.Drawing.Size(245, 29);
            this.tb_entidad.TabIndex = 6;
            // 
            // btn_Atributo
            // 
            this.btn_Atributo.AutoSize = true;
            this.btn_Atributo.BackColor = System.Drawing.Color.Black;
            this.btn_Atributo.FlatAppearance.BorderSize = 0;
            this.btn_Atributo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Atributo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Atributo.Location = new System.Drawing.Point(85, 467);
            this.btn_Atributo.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Atributo.Name = "btn_Atributo";
            this.btn_Atributo.Size = new System.Drawing.Size(169, 28);
            this.btn_Atributo.TabIndex = 7;
            this.btn_Atributo.Text = "Tabla de atributos  ";
            this.btn_Atributo.UseVisualStyleBackColor = false;
            this.btn_Atributo.Click += new System.EventHandler(this.btn_Atributo_Click);
            // 
            // lb_atributo
            // 
            this.lb_atributo.AutoSize = true;
            this.lb_atributo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_atributo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_atributo.Location = new System.Drawing.Point(61, 426);
            this.lb_atributo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_atributo.Name = "lb_atributo";
            this.lb_atributo.Size = new System.Drawing.Size(23, 20);
            this.lb_atributo.TabIndex = 8;
            this.lb_atributo.Text = "\"\"";
            // 
            // tb_modificar
            // 
            this.tb_modificar.BackColor = System.Drawing.Color.Gray;
            this.tb_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_modificar.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.tb_modificar.Location = new System.Drawing.Point(16, 143);
            this.tb_modificar.Margin = new System.Windows.Forms.Padding(4);
            this.tb_modificar.Name = "tb_modificar";
            this.tb_modificar.Size = new System.Drawing.Size(245, 29);
            this.tb_modificar.TabIndex = 9;
            // 
            // lbTablas
            // 
            this.lbTablas.AutoSize = true;
            this.lbTablas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTablas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTablas.Location = new System.Drawing.Point(514, 53);
            this.lbTablas.Name = "lbTablas";
            this.lbTablas.Size = new System.Drawing.Size(97, 25);
            this.lbTablas.TabIndex = 10;
            this.lbTablas.Text = "TABLAS";
            // 
            // groupBoxEntidades
            // 
            this.groupBoxEntidades.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBoxEntidades.Controls.Add(this.tb_entidad);
            this.groupBoxEntidades.Controls.Add(this.tb_modificar);
            this.groupBoxEntidades.Controls.Add(this.btn_CrearEntidad);
            this.groupBoxEntidades.Controls.Add(this.btn_Modificar);
            this.groupBoxEntidades.Controls.Add(this.btn_Borrar);
            this.groupBoxEntidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEntidades.Location = new System.Drawing.Point(27, 93);
            this.groupBoxEntidades.Name = "groupBoxEntidades";
            this.groupBoxEntidades.Size = new System.Drawing.Size(268, 312);
            this.groupBoxEntidades.TabIndex = 11;
            this.groupBoxEntidades.TabStop = false;
            this.groupBoxEntidades.Text = "TABLA";
            this.groupBoxEntidades.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbBasedeDatos
            // 
            this.lbBasedeDatos.AutoSize = true;
            this.lbBasedeDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBasedeDatos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbBasedeDatos.Location = new System.Drawing.Point(22, 53);
            this.lbBasedeDatos.Name = "lbBasedeDatos";
            this.lbBasedeDatos.Size = new System.Drawing.Size(59, 20);
            this.lbBasedeDatos.TabIndex = 12;
            this.lbBasedeDatos.Text = "label1";
            this.lbBasedeDatos.Visible = false;
            // 
            // FormEntidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(856, 523);
            this.Controls.Add(this.lbBasedeDatos);
            this.Controls.Add(this.groupBoxEntidades);
            this.Controls.Add(this.lbTablas);
            this.Controls.Add(this.lb_atributo);
            this.Controls.Add(this.btn_Atributo);
            this.Controls.Add(this.lbl_Cabecera);
            this.Controls.Add(this.dgv_Entidad);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormEntidad";
            this.Text = "Manejador de Base de Datos";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.FormEntidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Entidad)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxEntidades.ResumeLayout(false);
            this.groupBoxEntidades.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Entidad;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarArchivoToolStripMenuItem;
        private System.Windows.Forms.Label lbl_Cabecera;
        private System.Windows.Forms.Button btn_CrearEntidad;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Borrar;
        private System.Windows.Forms.TextBox tb_entidad;
        private System.Windows.Forms.Button btn_Atributo;
        private System.Windows.Forms.Label lb_atributo;
        private System.Windows.Forms.TextBox tb_modificar;
        private System.Windows.Forms.ToolStripMenuItem nuevoRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secundarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem árbolBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indicePrimarioBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indiceSecundarioBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secuencialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secuencialIndexadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hashEstaticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indicePriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejecutarSQLToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Label lbTablas;
        private System.Windows.Forms.GroupBox groupBoxEntidades;
        private System.Windows.Forms.Label lbBasedeDatos;
    }
}

