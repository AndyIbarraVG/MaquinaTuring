namespace MAQUINATURING
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grpAcciones = new System.Windows.Forms.GroupBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.grpMovimientos = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtCaracterReemplazar = new System.Windows.Forms.TextBox();
            this.btnAgregarAccion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCaracterAuxiliar = new System.Windows.Forms.TextBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnEncenderMaquina = new System.Windows.Forms.Button();
            this.alfabetoEnCeldas = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGuardarCadenaEntrada = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCadenaEntrada = new System.Windows.Forms.TextBox();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipsePanel3 = new Guna.UI.WinForms.GunaElipsePanel();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPosCabezal = new System.Windows.Forms.TextBox();
            this.btnGuardarCabezal = new Guna.UI.WinForms.GunaElipsePanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAlfabeto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCaracterAlfabeto = new System.Windows.Forms.TextBox();
            this.btnAgregarCaracterAlfabeto = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.grpAcciones.SuspendLayout();
            this.grpMovimientos.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gunaElipsePanel3.SuspendLayout();
            this.btnGuardarCabezal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grpAcciones);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.grpMovimientos);
            this.groupBox4.Controls.Add(this.txtCaracterReemplazar);
            this.groupBox4.Controls.Add(this.btnAgregarAccion);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtCaracterAuxiliar);
            this.groupBox4.Location = new System.Drawing.Point(14, 18);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(526, 184);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Operaciones";
            // 
            // grpAcciones
            // 
            this.grpAcciones.Controls.Add(this.radioButton8);
            this.grpAcciones.Controls.Add(this.radioButton7);
            this.grpAcciones.Controls.Add(this.radioButton6);
            this.grpAcciones.Location = new System.Drawing.Point(188, 21);
            this.grpAcciones.Name = "grpAcciones";
            this.grpAcciones.Size = new System.Drawing.Size(200, 96);
            this.grpAcciones.TabIndex = 9;
            this.grpAcciones.TabStop = false;
            this.grpAcciones.Text = "Acciones";
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(6, 25);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(149, 17);
            this.radioButton8.TabIndex = 2;
            this.radioButton8.Text = "Reemplazar por un blanco";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(6, 48);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(159, 17);
            this.radioButton7.TabIndex = 1;
            this.radioButton7.Text = "Reemplazar por un caracter ";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 71);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(86, 17);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Sobreescribir";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 157);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Caracter a reemplazar:";
            // 
            // grpMovimientos
            // 
            this.grpMovimientos.Controls.Add(this.radioButton5);
            this.grpMovimientos.Controls.Add(this.radioButton4);
            this.grpMovimientos.Controls.Add(this.radioButton3);
            this.grpMovimientos.Controls.Add(this.radioButton2);
            this.grpMovimientos.Controls.Add(this.radioButton1);
            this.grpMovimientos.Location = new System.Drawing.Point(10, 21);
            this.grpMovimientos.Name = "grpMovimientos";
            this.grpMovimientos.Size = new System.Drawing.Size(170, 149);
            this.grpMovimientos.TabIndex = 8;
            this.grpMovimientos.TabStop = false;
            this.grpMovimientos.Text = "Movimientos";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(12, 25);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(81, 17);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.Text = "Mantenerse";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(12, 48);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(152, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.Text = "Moverse uno a la izquierda";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(12, 72);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(149, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Moverse uno a la derecha";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 95);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(131, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Moverse a la izquierda";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 119);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(128, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Moverse a la derecha";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtCaracterReemplazar
            // 
            this.txtCaracterReemplazar.Location = new System.Drawing.Point(302, 154);
            this.txtCaracterReemplazar.Margin = new System.Windows.Forms.Padding(2);
            this.txtCaracterReemplazar.MaxLength = 1;
            this.txtCaracterReemplazar.Name = "txtCaracterReemplazar";
            this.txtCaracterReemplazar.Size = new System.Drawing.Size(41, 20);
            this.txtCaracterReemplazar.TabIndex = 17;
            this.txtCaracterReemplazar.TextChanged += new System.EventHandler(this.txtCaracterReemplazar_TextChanged);
            this.txtCaracterReemplazar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracterReemplazar_KeyPress);
            // 
            // btnAgregarAccion
            // 
            this.btnAgregarAccion.Location = new System.Drawing.Point(393, 26);
            this.btnAgregarAccion.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarAccion.Name = "btnAgregarAccion";
            this.btnAgregarAccion.Size = new System.Drawing.Size(122, 54);
            this.btnAgregarAccion.TabIndex = 13;
            this.btnAgregarAccion.Text = "Agregar Movimiento";
            this.btnAgregarAccion.UseVisualStyleBackColor = true;
            this.btnAgregarAccion.Click += new System.EventHandler(this.btnAgregarAccion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Caracter a encontrar:";
            // 
            // txtCaracterAuxiliar
            // 
            this.txtCaracterAuxiliar.Location = new System.Drawing.Point(302, 126);
            this.txtCaracterAuxiliar.Margin = new System.Windows.Forms.Padding(2);
            this.txtCaracterAuxiliar.MaxLength = 1;
            this.txtCaracterAuxiliar.Name = "txtCaracterAuxiliar";
            this.txtCaracterAuxiliar.Size = new System.Drawing.Size(41, 20);
            this.txtCaracterAuxiliar.TabIndex = 5;
            this.txtCaracterAuxiliar.TextChanged += new System.EventHandler(this.txtCaracterAuxiliar_TextChanged);
            this.txtCaracterAuxiliar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracterAuxiliar_KeyPress);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(662, 13);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(70, 25);
            this.btnReiniciar.TabIndex = 19;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnEncenderMaquina
            // 
            this.btnEncenderMaquina.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEncenderMaquina.Location = new System.Drawing.Point(737, 13);
            this.btnEncenderMaquina.Margin = new System.Windows.Forms.Padding(2);
            this.btnEncenderMaquina.Name = "btnEncenderMaquina";
            this.btnEncenderMaquina.Size = new System.Drawing.Size(163, 25);
            this.btnEncenderMaquina.TabIndex = 3;
            this.btnEncenderMaquina.Text = "Iniciar Maquina";
            this.btnEncenderMaquina.UseVisualStyleBackColor = false;
            this.btnEncenderMaquina.Click += new System.EventHandler(this.btnEncenderMaquina_Click);
            // 
            // alfabetoEnCeldas
            // 
            this.alfabetoEnCeldas.HideSelection = false;
            this.alfabetoEnCeldas.Location = new System.Drawing.Point(11, 100);
            this.alfabetoEnCeldas.Margin = new System.Windows.Forms.Padding(2);
            this.alfabetoEnCeldas.MultiSelect = false;
            this.alfabetoEnCeldas.Name = "alfabetoEnCeldas";
            this.alfabetoEnCeldas.OwnerDraw = true;
            this.alfabetoEnCeldas.Size = new System.Drawing.Size(921, 103);
            this.alfabetoEnCeldas.TabIndex = 7;
            this.alfabetoEnCeldas.TileSize = new System.Drawing.Size(50, 20);
            this.alfabetoEnCeldas.UseCompatibleStateImageBehavior = false;
            this.alfabetoEnCeldas.View = System.Windows.Forms.View.Tile;
            this.alfabetoEnCeldas.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.alfabetoEnCeldas_DrawItem);
            this.alfabetoEnCeldas.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.alfabetoEnCeldas_ItemSelectionChanged);
            this.alfabetoEnCeldas.Click += new System.EventHandler(this.alfabetoEnCeldas_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnReiniciar);
            this.groupBox3.Controls.Add(this.btnEncenderMaquina);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnGuardarCadenaEntrada);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtCadenaEntrada);
            this.groupBox3.Location = new System.Drawing.Point(11, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(921, 54);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cadena de entrada";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Δ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuardarCadenaEntrada
            // 
            this.btnGuardarCadenaEntrada.Location = new System.Drawing.Point(550, 13);
            this.btnGuardarCadenaEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarCadenaEntrada.Name = "btnGuardarCadenaEntrada";
            this.btnGuardarCadenaEntrada.Size = new System.Drawing.Size(107, 25);
            this.btnGuardarCadenaEntrada.TabIndex = 6;
            this.btnGuardarCadenaEntrada.Text = "Guardar";
            this.btnGuardarCadenaEntrada.UseVisualStyleBackColor = true;
            this.btnGuardarCadenaEntrada.Click += new System.EventHandler(this.btnGuardarCadenaEntrada_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingresa la cadena de entrada:";
            // 
            // txtCadenaEntrada
            // 
            this.txtCadenaEntrada.Location = new System.Drawing.Point(171, 15);
            this.txtCadenaEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.txtCadenaEntrada.Name = "txtCadenaEntrada";
            this.txtCadenaEntrada.Size = new System.Drawing.Size(326, 20);
            this.txtCadenaEntrada.TabIndex = 4;
            this.txtCadenaEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCadenaEntrada_KeyPress);
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.MediumPurple;
            this.gunaElipsePanel1.Controls.Add(this.pictureBox1);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(971, 34);
            this.gunaElipsePanel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(934, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaElipsePanel3
            // 
            this.gunaElipsePanel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel3.BaseColor = System.Drawing.Color.Plum;
            this.gunaElipsePanel3.Controls.Add(this.label5);
            this.gunaElipsePanel3.Controls.Add(this.button2);
            this.gunaElipsePanel3.Controls.Add(this.txtPosCabezal);
            this.gunaElipsePanel3.Controls.Add(this.groupBox3);
            this.gunaElipsePanel3.Controls.Add(this.alfabetoEnCeldas);
            this.gunaElipsePanel3.Location = new System.Drawing.Point(12, 40);
            this.gunaElipsePanel3.Name = "gunaElipsePanel3";
            this.gunaElipsePanel3.Radius = 20;
            this.gunaElipsePanel3.Size = new System.Drawing.Size(949, 212);
            this.gunaElipsePanel3.TabIndex = 10;
            this.gunaElipsePanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaElipsePanel3_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ingrese el cabezal:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 71);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 25);
            this.button2.TabIndex = 13;
            this.button2.Text = "Seleccionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPosCabezal
            // 
            this.txtPosCabezal.Location = new System.Drawing.Point(112, 74);
            this.txtPosCabezal.Margin = new System.Windows.Forms.Padding(2);
            this.txtPosCabezal.MaxLength = 2;
            this.txtPosCabezal.Name = "txtPosCabezal";
            this.txtPosCabezal.Size = new System.Drawing.Size(41, 20);
            this.txtPosCabezal.TabIndex = 12;
            this.txtPosCabezal.TextChanged += new System.EventHandler(this.txtPosCabezal_TextChanged);
            // 
            // btnGuardarCabezal
            // 
            this.btnGuardarCabezal.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarCabezal.BaseColor = System.Drawing.Color.Plum;
            this.btnGuardarCabezal.Controls.Add(this.groupBox1);
            this.btnGuardarCabezal.Controls.Add(this.groupBox2);
            this.btnGuardarCabezal.Controls.Add(this.groupBox4);
            this.btnGuardarCabezal.Location = new System.Drawing.Point(12, 258);
            this.btnGuardarCabezal.Name = "btnGuardarCabezal";
            this.btnGuardarCabezal.Radius = 20;
            this.btnGuardarCabezal.Size = new System.Drawing.Size(949, 215);
            this.btnGuardarCabezal.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(619, 148);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(259, 54);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Integrante:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-2, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ibarra Villanueva Andy Giovani                  #19100201";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAlfabeto);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtCaracterAlfabeto);
            this.groupBox2.Controls.Add(this.btnAgregarCaracterAlfabeto);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(544, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(388, 112);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alfabeto";
            // 
            // lblAlfabeto
            // 
            this.lblAlfabeto.AutoSize = true;
            this.lblAlfabeto.Location = new System.Drawing.Point(120, 67);
            this.lblAlfabeto.Name = "lblAlfabeto";
            this.lblAlfabeto.Size = new System.Drawing.Size(0, 13);
            this.lblAlfabeto.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresa un caracter:";
            // 
            // txtCaracterAlfabeto
            // 
            this.txtCaracterAlfabeto.Location = new System.Drawing.Point(234, 12);
            this.txtCaracterAlfabeto.Margin = new System.Windows.Forms.Padding(2);
            this.txtCaracterAlfabeto.MaxLength = 1;
            this.txtCaracterAlfabeto.Name = "txtCaracterAlfabeto";
            this.txtCaracterAlfabeto.Size = new System.Drawing.Size(40, 20);
            this.txtCaracterAlfabeto.TabIndex = 1;
            // 
            // btnAgregarCaracterAlfabeto
            // 
            this.btnAgregarCaracterAlfabeto.Location = new System.Drawing.Point(117, 35);
            this.btnAgregarCaracterAlfabeto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarCaracterAlfabeto.Name = "btnAgregarCaracterAlfabeto";
            this.btnAgregarCaracterAlfabeto.Size = new System.Drawing.Size(157, 27);
            this.btnAgregarCaracterAlfabeto.TabIndex = 3;
            this.btnAgregarCaracterAlfabeto.Text = "Agregar al alfabeto";
            this.btnAgregarCaracterAlfabeto.UseVisualStyleBackColor = true;
            this.btnAgregarCaracterAlfabeto.Click += new System.EventHandler(this.btnAgregarCaracterAlfabeto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(971, 485);
            this.Controls.Add(this.btnGuardarCabezal);
            this.Controls.Add(this.gunaElipsePanel3);
            this.Controls.Add(this.gunaElipsePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grpAcciones.ResumeLayout(false);
            this.grpAcciones.PerformLayout();
            this.grpMovimientos.ResumeLayout(false);
            this.grpMovimientos.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gunaElipsePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gunaElipsePanel3.ResumeLayout(false);
            this.gunaElipsePanel3.PerformLayout();
            this.btnGuardarCabezal.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCaracterReemplazar;
        private System.Windows.Forms.Button btnAgregarAccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCaracterAuxiliar;
        private System.Windows.Forms.Button btnEncenderMaquina;
        private System.Windows.Forms.ListView alfabetoEnCeldas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGuardarCadenaEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCadenaEntrada;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipsePanel btnGuardarCabezal;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel3;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAlfabeto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCaracterAlfabeto;
        private System.Windows.Forms.Button btnAgregarCaracterAlfabeto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPosCabezal;
        private System.Windows.Forms.GroupBox grpMovimientos;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox grpAcciones;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

