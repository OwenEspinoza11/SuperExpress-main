namespace SuperExpress
{
    partial class Inicio
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
            menuStrip1 = new MenuStrip();
            MenuAdministrar = new FontAwesome.Sharp.IconMenuItem();
            productoToolStripMenuItem = new ToolStripMenuItem();
            negocioToolStripMenuItem = new ToolStripMenuItem();
            MenuVentas = new FontAwesome.Sharp.IconMenuItem();
            btnVentas = new ToolStripMenuItem();
            btnDetalleVenta = new ToolStripMenuItem();
            MenuCompras = new FontAwesome.Sharp.IconMenuItem();
            registrarToolStripMenuItem1 = new ToolStripMenuItem();
            verDetalleToolStripMenuItem1 = new ToolStripMenuItem();
            MenuProveedores = new FontAwesome.Sharp.IconMenuItem();
            MenuClientes = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            MenuReportes = new FontAwesome.Sharp.IconMenuItem();
            reporteDeComprasToolStripMenuItem = new ToolStripMenuItem();
            reporteDeVentasToolStripMenuItem = new ToolStripMenuItem();
            MenuInfo = new FontAwesome.Sharp.IconMenuItem();
            btnSalir = new FontAwesome.Sharp.IconMenuItem();
            panel1 = new Panel();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label10 = new Label();
            dateTimePicker1 = new DateTimePicker();
            iBtnLimpiar = new FontAwesome.Sharp.IconButton();
            iBtnEliminar = new FontAwesome.Sharp.IconButton();
            iBtnEditar = new FontAwesome.Sharp.IconButton();
            iBtnGuardar = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Orange;
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuAdministrar, MenuVentas, MenuCompras, MenuProveedores, MenuClientes, iconMenuItem1, MenuReportes, MenuInfo, btnSalir });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(837, 71);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "Menu";
            // 
            // MenuAdministrar
            // 
            MenuAdministrar.DropDownItems.AddRange(new ToolStripItem[] { productoToolStripMenuItem, negocioToolStripMenuItem });
            MenuAdministrar.IconChar = FontAwesome.Sharp.IconChar.Tools;
            MenuAdministrar.IconColor = Color.Black;
            MenuAdministrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuAdministrar.ImageScaling = ToolStripItemImageScaling.None;
            MenuAdministrar.Name = "MenuAdministrar";
            MenuAdministrar.Size = new Size(81, 67);
            MenuAdministrar.Text = "Administrar";
            MenuAdministrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // productoToolStripMenuItem
            // 
            productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            productoToolStripMenuItem.Size = new Size(180, 22);
            productoToolStripMenuItem.Text = "Producto";
            productoToolStripMenuItem.Click += productoToolStripMenuItem_Click;
            // 
            // negocioToolStripMenuItem
            // 
            negocioToolStripMenuItem.Name = "negocioToolStripMenuItem";
            negocioToolStripMenuItem.Size = new Size(180, 22);
            negocioToolStripMenuItem.Text = "Negocio";
            // 
            // MenuVentas
            // 
            MenuVentas.DropDownItems.AddRange(new ToolStripItem[] { btnVentas, btnDetalleVenta });
            MenuVentas.IconChar = FontAwesome.Sharp.IconChar.Sign;
            MenuVentas.IconColor = Color.Black;
            MenuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuVentas.ImageScaling = ToolStripItemImageScaling.None;
            MenuVentas.Name = "MenuVentas";
            MenuVentas.Size = new Size(60, 67);
            MenuVentas.Text = "Ventas";
            MenuVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // btnVentas
            // 
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(180, 22);
            btnVentas.Text = "Registrar";
            btnVentas.Click += btnVentas_Click;
            // 
            // btnDetalleVenta
            // 
            btnDetalleVenta.Name = "btnDetalleVenta";
            btnDetalleVenta.Size = new Size(180, 22);
            btnDetalleVenta.Text = "Ver detalle";
            btnDetalleVenta.Click += btnDetalleVenta_Click;
            // 
            // MenuCompras
            // 
            MenuCompras.DropDownItems.AddRange(new ToolStripItem[] { registrarToolStripMenuItem1, verDetalleToolStripMenuItem1 });
            MenuCompras.IconChar = FontAwesome.Sharp.IconChar.Speakap;
            MenuCompras.IconColor = Color.Black;
            MenuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuCompras.ImageScaling = ToolStripItemImageScaling.None;
            MenuCompras.Name = "MenuCompras";
            MenuCompras.Size = new Size(67, 67);
            MenuCompras.Text = "Compras";
            MenuCompras.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // registrarToolStripMenuItem1
            // 
            registrarToolStripMenuItem1.Name = "registrarToolStripMenuItem1";
            registrarToolStripMenuItem1.Size = new Size(180, 22);
            registrarToolStripMenuItem1.Text = "Registrar";
            // 
            // verDetalleToolStripMenuItem1
            // 
            verDetalleToolStripMenuItem1.Name = "verDetalleToolStripMenuItem1";
            verDetalleToolStripMenuItem1.Size = new Size(180, 22);
            verDetalleToolStripMenuItem1.Text = "Ver detalle";
            // 
            // MenuProveedores
            // 
            MenuProveedores.IconChar = FontAwesome.Sharp.IconChar.PeopleCarryBox;
            MenuProveedores.IconColor = Color.Black;
            MenuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuProveedores.ImageScaling = ToolStripItemImageScaling.None;
            MenuProveedores.Name = "MenuProveedores";
            MenuProveedores.Size = new Size(84, 67);
            MenuProveedores.Text = "Proveedores";
            MenuProveedores.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuProveedores.Click += MenuProveedores_Click;
            // 
            // MenuClientes
            // 
            MenuClientes.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            MenuClientes.IconColor = Color.Black;
            MenuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuClientes.ImageScaling = ToolStripItemImageScaling.None;
            MenuClientes.Name = "MenuClientes";
            MenuClientes.Size = new Size(61, 67);
            MenuClientes.Text = "Clientes";
            MenuClientes.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuClientes.Click += MenuClientes_Click;
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(72, 67);
            iconMenuItem1.Text = "Inventario";
            iconMenuItem1.TextAlign = ContentAlignment.TopCenter;
            iconMenuItem1.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // MenuReportes
            // 
            MenuReportes.DropDownItems.AddRange(new ToolStripItem[] { reporteDeComprasToolStripMenuItem, reporteDeVentasToolStripMenuItem });
            MenuReportes.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            MenuReportes.IconColor = Color.Black;
            MenuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuReportes.ImageScaling = ToolStripItemImageScaling.None;
            MenuReportes.Name = "MenuReportes";
            MenuReportes.Size = new Size(65, 67);
            MenuReportes.Text = "Reportes";
            MenuReportes.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // reporteDeComprasToolStripMenuItem
            // 
            reporteDeComprasToolStripMenuItem.Name = "reporteDeComprasToolStripMenuItem";
            reporteDeComprasToolStripMenuItem.Size = new Size(180, 22);
            reporteDeComprasToolStripMenuItem.Text = "Reporte de compras";
            // 
            // reporteDeVentasToolStripMenuItem
            // 
            reporteDeVentasToolStripMenuItem.Name = "reporteDeVentasToolStripMenuItem";
            reporteDeVentasToolStripMenuItem.Size = new Size(180, 22);
            reporteDeVentasToolStripMenuItem.Text = "Reporte de ventas";
            // 
            // MenuInfo
            // 
            MenuInfo.IconChar = FontAwesome.Sharp.IconChar.Info;
            MenuInfo.IconColor = Color.Black;
            MenuInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuInfo.ImageScaling = ToolStripItemImageScaling.None;
            MenuInfo.Name = "MenuInfo";
            MenuInfo.Size = new Size(60, 67);
            MenuInfo.Text = "Info";
            MenuInfo.TextAlign = ContentAlignment.TopCenter;
            MenuInfo.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuInfo.Click += MenuInfo_Click;
            // 
            // btnSalir
            // 
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.ImageScaling = ToolStripItemImageScaling.None;
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(60, 67);
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.TopCenter;
            btnSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(dateTimePicker3);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(iBtnLimpiar);
            panel1.Controls.Add(iBtnEliminar);
            panel1.Controls.Add(iBtnEditar);
            panel1.Controls.Add(iBtnGuardar);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox9);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(0, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 482);
            panel1.TabIndex = 1;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(175, 237);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(97, 23);
            dateTimePicker3.TabIndex = 25;
            dateTimePicker3.Visible = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(31, 237);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(97, 23);
            dateTimePicker2.TabIndex = 24;
            dateTimePicker2.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(172, 277);
            label10.Name = "label10";
            label10.Size = new Size(97, 15);
            label10.TabIndex = 23;
            label10.Text = "Fecha de registro";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(172, 295);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(97, 23);
            dateTimePicker1.TabIndex = 22;
            // 
            // iBtnLimpiar
            // 
            iBtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            iBtnLimpiar.IconColor = Color.Black;
            iBtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iBtnLimpiar.Location = new Point(31, 338);
            iBtnLimpiar.Name = "iBtnLimpiar";
            iBtnLimpiar.Size = new Size(75, 63);
            iBtnLimpiar.TabIndex = 21;
            iBtnLimpiar.Text = "Limpiar";
            iBtnLimpiar.TextAlign = ContentAlignment.BottomCenter;
            iBtnLimpiar.UseVisualStyleBackColor = true;
            // 
            // iBtnEliminar
            // 
            iBtnEliminar.IconChar = FontAwesome.Sharp.IconChar.FileCircleMinus;
            iBtnEliminar.IconColor = Color.Red;
            iBtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iBtnEliminar.Location = new Point(31, 407);
            iBtnEliminar.Name = "iBtnEliminar";
            iBtnEliminar.Size = new Size(75, 61);
            iBtnEliminar.TabIndex = 20;
            iBtnEliminar.Text = "Borrar";
            iBtnEliminar.TextAlign = ContentAlignment.BottomCenter;
            iBtnEliminar.UseVisualStyleBackColor = true;
            // 
            // iBtnEditar
            // 
            iBtnEditar.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            iBtnEditar.IconColor = SystemColors.ActiveCaptionText;
            iBtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iBtnEditar.Location = new Point(172, 407);
            iBtnEditar.Name = "iBtnEditar";
            iBtnEditar.Size = new Size(75, 61);
            iBtnEditar.TabIndex = 19;
            iBtnEditar.Text = "Editar";
            iBtnEditar.TextAlign = ContentAlignment.BottomCenter;
            iBtnEditar.UseVisualStyleBackColor = true;
            // 
            // iBtnGuardar
            // 
            iBtnGuardar.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            iBtnGuardar.IconColor = Color.Lime;
            iBtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iBtnGuardar.Location = new Point(172, 338);
            iBtnGuardar.Name = "iBtnGuardar";
            iBtnGuardar.Size = new Size(75, 63);
            iBtnGuardar.TabIndex = 18;
            iBtnGuardar.Text = "Guardar";
            iBtnGuardar.TextAlign = ContentAlignment.BottomCenter;
            iBtnGuardar.UseVisualStyleBackColor = true;
            iBtnGuardar.Click += iBtnGuardar_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 277);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 17;
            label9.Text = "label9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(172, 219);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 16;
            label8.Text = "label8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 219);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 15;
            label7.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(172, 157);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 14;
            label6.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 157);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 13;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(172, 90);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 12;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 90);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 11;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 18);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 10;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 18);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 9;
            label1.Text = "label1";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(31, 295);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 8;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(172, 237);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 7;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(31, 237);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(172, 175);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(31, 175);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(172, 108);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(31, 108);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(172, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(31, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(313, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(512, 374);
            dataGridView1.TabIndex = 2;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 557);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "Inicio";
            Text = "SuperExpress";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem MenuInfo;
        private FontAwesome.Sharp.IconMenuItem MenuAdministrar;
        private FontAwesome.Sharp.IconMenuItem MenuVentas;
        private FontAwesome.Sharp.IconMenuItem MenuCompras;
        private FontAwesome.Sharp.IconMenuItem MenuProveedores;
        private FontAwesome.Sharp.IconMenuItem MenuClientes;
        private FontAwesome.Sharp.IconMenuItem MenuReportes;
        private ToolStripMenuItem btnVentas;
        private ToolStripMenuItem btnDetalleVenta;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private ToolStripMenuItem productoToolStripMenuItem;
        private ToolStripMenuItem negocioToolStripMenuItem;
        private ToolStripMenuItem registrarToolStripMenuItem1;
        private ToolStripMenuItem verDetalleToolStripMenuItem1;
        private ToolStripMenuItem reporteDeComprasToolStripMenuItem;
        private ToolStripMenuItem reporteDeVentasToolStripMenuItem;
        private Panel panel1;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton iBtnLimpiar;
        private FontAwesome.Sharp.IconButton iBtnEliminar;
        private FontAwesome.Sharp.IconButton iBtnEditar;
        private FontAwesome.Sharp.IconButton iBtnGuardar;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label10;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private FontAwesome.Sharp.IconMenuItem btnSalir;
    }
}