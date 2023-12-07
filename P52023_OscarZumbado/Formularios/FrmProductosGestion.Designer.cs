namespace P52023_OscarZumbado.Formularios
{
    partial class FrmProductosGestion
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
            this.DgvListaProductos = new System.Windows.Forms.DataGridView();
            this.ColProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUtilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTasaImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidadStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductoCategoriaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductoCategoriaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CbUsuarioActivo = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtProductoUtilidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtProductoSubtotal = new System.Windows.Forms.TextBox();
            this.CboxProductoCategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtProductoCosto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtProductoNombreProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtProductoCodigoBarras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtProductoCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.TxtProductoTasaImpuesto = new System.Windows.Forms.TextBox();
            this.TxtProductoPrecioUnitario = new System.Windows.Forms.TextBox();
            this.TxtProductoCantidadStock = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.CbVerActivos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvListaProductos
            // 
            this.DgvListaProductos.AllowUserToAddRows = false;
            this.DgvListaProductos.AllowUserToDeleteRows = false;
            this.DgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProductoID,
            this.ColCodigoBarras,
            this.ColNombreProducto,
            this.ColCosto,
            this.ColUtilidad,
            this.ColSubTotal,
            this.ColTasaImpuesto,
            this.CoPrecioUnitario,
            this.ColCantidadStock,
            this.ColProductoCategoriaID,
            this.ColProductoCategoriaDescripcion});
            this.DgvListaProductos.Location = new System.Drawing.Point(3, 32);
            this.DgvListaProductos.MultiSelect = false;
            this.DgvListaProductos.Name = "DgvListaProductos";
            this.DgvListaProductos.ReadOnly = true;
            this.DgvListaProductos.RowHeadersVisible = false;
            this.DgvListaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaProductos.Size = new System.Drawing.Size(958, 234);
            this.DgvListaProductos.TabIndex = 4;
            this.DgvListaProductos.VirtualMode = true;
            // 
            // ColProductoID
            // 
            this.ColProductoID.DataPropertyName = "ProductoID";
            this.ColProductoID.HeaderText = "ProductoID";
            this.ColProductoID.Name = "ColProductoID";
            this.ColProductoID.ReadOnly = true;
            // 
            // ColCodigoBarras
            // 
            this.ColCodigoBarras.DataPropertyName = "CodigoBarras";
            this.ColCodigoBarras.HeaderText = "CodigoBarras";
            this.ColCodigoBarras.Name = "ColCodigoBarras";
            this.ColCodigoBarras.ReadOnly = true;
            // 
            // ColNombreProducto
            // 
            this.ColNombreProducto.DataPropertyName = "NombreProducto";
            this.ColNombreProducto.HeaderText = "NombreProducto";
            this.ColNombreProducto.Name = "ColNombreProducto";
            this.ColNombreProducto.ReadOnly = true;
            // 
            // ColCosto
            // 
            this.ColCosto.DataPropertyName = "Costo";
            this.ColCosto.HeaderText = "Costo";
            this.ColCosto.Name = "ColCosto";
            this.ColCosto.ReadOnly = true;
            // 
            // ColUtilidad
            // 
            this.ColUtilidad.DataPropertyName = "Utilidad";
            this.ColUtilidad.HeaderText = "Utilidad";
            this.ColUtilidad.Name = "ColUtilidad";
            this.ColUtilidad.ReadOnly = true;
            // 
            // ColSubTotal
            // 
            this.ColSubTotal.DataPropertyName = "SubTotal";
            this.ColSubTotal.HeaderText = "SubTotal";
            this.ColSubTotal.Name = "ColSubTotal";
            this.ColSubTotal.ReadOnly = true;
            // 
            // ColTasaImpuesto
            // 
            this.ColTasaImpuesto.DataPropertyName = "TasaImpuesto";
            this.ColTasaImpuesto.HeaderText = "TasaImpuesto";
            this.ColTasaImpuesto.Name = "ColTasaImpuesto";
            this.ColTasaImpuesto.ReadOnly = true;
            // 
            // CoPrecioUnitario
            // 
            this.CoPrecioUnitario.DataPropertyName = "PrecioUnitario";
            this.CoPrecioUnitario.HeaderText = "PrecioUnitario";
            this.CoPrecioUnitario.Name = "CoPrecioUnitario";
            this.CoPrecioUnitario.ReadOnly = true;
            // 
            // ColCantidadStock
            // 
            this.ColCantidadStock.DataPropertyName = "CantidadStock";
            this.ColCantidadStock.HeaderText = "CantidadStock";
            this.ColCantidadStock.Name = "ColCantidadStock";
            this.ColCantidadStock.ReadOnly = true;
            // 
            // ColProductoCategoriaID
            // 
            this.ColProductoCategoriaID.DataPropertyName = "ProductoCategoriaID";
            this.ColProductoCategoriaID.HeaderText = "ProductoCategoriaID";
            this.ColProductoCategoriaID.Name = "ColProductoCategoriaID";
            this.ColProductoCategoriaID.ReadOnly = true;
            // 
            // ColProductoCategoriaDescripcion
            // 
            this.ColProductoCategoriaDescripcion.DataPropertyName = "ProductoCategoriaDescripcion";
            this.ColProductoCategoriaDescripcion.HeaderText = "ProductoCategoriaDescripcion";
            this.ColProductoCategoriaDescripcion.Name = "ColProductoCategoriaDescripcion";
            this.ColProductoCategoriaDescripcion.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.TxtProductoCantidadStock);
            this.groupBox1.Controls.Add(this.TxtProductoPrecioUnitario);
            this.groupBox1.Controls.Add(this.TxtProductoTasaImpuesto);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.CbUsuarioActivo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtProductoUtilidad);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtProductoSubtotal);
            this.groupBox1.Controls.Add(this.CboxProductoCategoria);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtProductoCosto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtProductoNombreProducto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtProductoCodigoBarras);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtProductoCodigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(949, 299);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del Usuario...";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(498, 271);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "Datos Requeridos.....";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(476, 269);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 18);
            this.label15.TabIndex = 22;
            this.label15.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(543, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 18);
            this.label14.TabIndex = 21;
            this.label14.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(573, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 18);
            this.label13.TabIndex = 20;
            this.label13.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(50, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 18);
            this.label12.TabIndex = 19;
            this.label12.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(109, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(96, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "*";
            // 
            // CbUsuarioActivo
            // 
            this.CbUsuarioActivo.AutoSize = true;
            this.CbUsuarioActivo.Enabled = false;
            this.CbUsuarioActivo.Location = new System.Drawing.Point(249, 39);
            this.CbUsuarioActivo.Name = "CbUsuarioActivo";
            this.CbUsuarioActivo.Size = new System.Drawing.Size(56, 17);
            this.CbUsuarioActivo.TabIndex = 16;
            this.CbUsuarioActivo.Text = "Activo";
            this.CbUsuarioActivo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(476, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tasa Impuesto";
            // 
            // TxtProductoUtilidad
            // 
            this.TxtProductoUtilidad.Location = new System.Drawing.Point(13, 253);
            this.TxtProductoUtilidad.Name = "TxtProductoUtilidad";
            this.TxtProductoUtilidad.Size = new System.Drawing.Size(292, 20);
            this.TxtProductoUtilidad.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Utilidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(476, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Sub Total";
            // 
            // TxtProductoSubtotal
            // 
            this.TxtProductoSubtotal.Location = new System.Drawing.Point(479, 60);
            this.TxtProductoSubtotal.Name = "TxtProductoSubtotal";
            this.TxtProductoSubtotal.Size = new System.Drawing.Size(300, 20);
            this.TxtProductoSubtotal.TabIndex = 10;
            // 
            // CboxProductoCategoria
            // 
            this.CboxProductoCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxProductoCategoria.FormattingEnabled = true;
            this.CboxProductoCategoria.Location = new System.Drawing.Point(479, 237);
            this.CboxProductoCategoria.Name = "CboxProductoCategoria";
            this.CboxProductoCategoria.Size = new System.Drawing.Size(300, 21);
            this.CboxProductoCategoria.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tipo de Categoria";
            // 
            // TxtProductoCosto
            // 
            this.TxtProductoCosto.Location = new System.Drawing.Point(13, 204);
            this.TxtProductoCosto.Name = "TxtProductoCosto";
            this.TxtProductoCosto.Size = new System.Drawing.Size(292, 20);
            this.TxtProductoCosto.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Costo";
            // 
            // TxtProductoNombreProducto
            // 
            this.TxtProductoNombreProducto.Location = new System.Drawing.Point(13, 148);
            this.TxtProductoNombreProducto.Name = "TxtProductoNombreProducto";
            this.TxtProductoNombreProducto.Size = new System.Drawing.Size(292, 20);
            this.TxtProductoNombreProducto.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre de Producto";
            // 
            // TxtProductoCodigoBarras
            // 
            this.TxtProductoCodigoBarras.Location = new System.Drawing.Point(13, 91);
            this.TxtProductoCodigoBarras.Name = "TxtProductoCodigoBarras";
            this.TxtProductoCodigoBarras.Size = new System.Drawing.Size(292, 20);
            this.TxtProductoCodigoBarras.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo de Barras";
            // 
            // TxtProductoCodigo
            // 
            this.TxtProductoCodigo.Enabled = false;
            this.TxtProductoCodigo.Location = new System.Drawing.Point(13, 36);
            this.TxtProductoCodigo.Name = "TxtProductoCodigo";
            this.TxtProductoCodigo.Size = new System.Drawing.Size(230, 20);
            this.TxtProductoCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo de Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(58, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(476, 132);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Precio Unitario";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(476, 172);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 13);
            this.label18.TabIndex = 26;
            this.label18.Text = "Cantidad Stock";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(552, 93);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 18);
            this.label19.TabIndex = 27;
            this.label19.Text = "*";
            // 
            // TxtProductoTasaImpuesto
            // 
            this.TxtProductoTasaImpuesto.Location = new System.Drawing.Point(479, 107);
            this.TxtProductoTasaImpuesto.Name = "TxtProductoTasaImpuesto";
            this.TxtProductoTasaImpuesto.Size = new System.Drawing.Size(300, 20);
            this.TxtProductoTasaImpuesto.TabIndex = 28;
            // 
            // TxtProductoPrecioUnitario
            // 
            this.TxtProductoPrecioUnitario.Location = new System.Drawing.Point(479, 149);
            this.TxtProductoPrecioUnitario.Name = "TxtProductoPrecioUnitario";
            this.TxtProductoPrecioUnitario.Size = new System.Drawing.Size(300, 20);
            this.TxtProductoPrecioUnitario.TabIndex = 29;
            // 
            // TxtProductoCantidadStock
            // 
            this.TxtProductoCantidadStock.Location = new System.Drawing.Point(479, 189);
            this.TxtProductoCantidadStock.Name = "TxtProductoCantidadStock";
            this.TxtProductoCantidadStock.Size = new System.Drawing.Size(300, 20);
            this.TxtProductoCantidadStock.TabIndex = 30;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(552, 132);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(15, 18);
            this.label20.TabIndex = 31;
            this.label20.Text = "*";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(552, 172);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(15, 18);
            this.label21.TabIndex = 32;
            this.label21.Text = "*";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Red;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.ForeColor = System.Drawing.Color.Black;
            this.BtnCerrar.Location = new System.Drawing.Point(809, 583);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(152, 40);
            this.BtnCerrar.TabIndex = 12;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.BtnLimpiar.Location = new System.Drawing.Point(639, 583);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(152, 40);
            this.BtnLimpiar.TabIndex = 11;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Lime;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.ForeColor = System.Drawing.Color.Black;
            this.BtnAgregar.Location = new System.Drawing.Point(25, 583);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(130, 40);
            this.BtnAgregar.TabIndex = 10;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // CbVerActivos
            // 
            this.CbVerActivos.AutoSize = true;
            this.CbVerActivos.Checked = true;
            this.CbVerActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbVerActivos.Location = new System.Drawing.Point(684, 9);
            this.CbVerActivos.Name = "CbVerActivos";
            this.CbVerActivos.Size = new System.Drawing.Size(131, 17);
            this.CbVerActivos.TabIndex = 13;
            this.CbVerActivos.Text = "Ver Productos Activos";
            this.CbVerActivos.UseVisualStyleBackColor = true;
            // 
            // FrmProductosGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 635);
            this.Controls.Add(this.CbVerActivos);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvListaProductos);
            this.MaximizeBox = false;
            this.Name = "FrmProductosGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos Gestion";
            this.Load += new System.EventHandler(this.FrmProductosGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvListaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUtilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTasaImpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidadStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductoCategoriaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductoCategoriaDescripcion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox CbUsuarioActivo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtProductoUtilidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtProductoSubtotal;
        private System.Windows.Forms.ComboBox CboxProductoCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtProductoCosto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtProductoNombreProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtProductoCodigoBarras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtProductoCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TxtProductoCantidadStock;
        private System.Windows.Forms.TextBox TxtProductoPrecioUnitario;
        private System.Windows.Forms.TextBox TxtProductoTasaImpuesto;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.CheckBox CbVerActivos;
    }
}