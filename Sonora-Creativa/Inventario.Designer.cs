
namespace Sonora_Creativa
{
    partial class Inventario
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblProductos = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.roundbutton5 = new CustomControls.RJControls.roundbutton();
            this.roundbutton4 = new CustomControls.RJControls.roundbutton();
            this.roundbutton3 = new CustomControls.RJControls.roundbutton();
            this.roundbutton2 = new CustomControls.RJControls.roundbutton();
            this.roundbutton1 = new CustomControls.RJControls.roundbutton();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(685, 49);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(184, 52);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(137, 20);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.Text = "Buscar...";
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(327, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_producto,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(160, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(719, 476);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id_producto
            // 
            this.Id_producto.DataPropertyName = "Id_producto";
            this.Id_producto.HeaderText = "Id_producto";
            this.Id_producto.Name = "Id_producto";
            this.Id_producto.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(945, 282);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(922, 327);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(124, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(766, 49);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(980, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 13;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(980, 121);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 14;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(980, 159);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 15;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(980, 200);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 16;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(980, 242);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 17;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(894, 88);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(894, 124);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 19;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(894, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(894, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(894, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Cantidad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 576);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pictureBox2.Location = new System.Drawing.Point(130, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(967, 23);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProductos.Location = new System.Drawing.Point(162, 5);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(62, 15);
            this.lblProductos.TabIndex = 30;
            this.lblProductos.Text = "Productos";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(971, 544);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 32;
            this.txtId.Visible = false;
            // 
            // roundbutton5
            // 
            this.roundbutton5.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.roundbutton5.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.roundbutton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundbutton5.BorderRadius = 0;
            this.roundbutton5.BorderSize = 0;
            this.roundbutton5.FlatAppearance.BorderSize = 0;
            this.roundbutton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundbutton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundbutton5.ForeColor = System.Drawing.Color.White;
            this.roundbutton5.Location = new System.Drawing.Point(971, 1);
            this.roundbutton5.Name = "roundbutton5";
            this.roundbutton5.Size = new System.Drawing.Size(93, 22);
            this.roundbutton5.TabIndex = 31;
            this.roundbutton5.Text = "Cerrar Sesión";
            this.roundbutton5.TextColor = System.Drawing.Color.White;
            this.roundbutton5.UseVisualStyleBackColor = false;
            // 
            // roundbutton4
            // 
            this.roundbutton4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.roundbutton4.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.roundbutton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundbutton4.BorderRadius = 0;
            this.roundbutton4.BorderSize = 0;
            this.roundbutton4.FlatAppearance.BorderSize = 0;
            this.roundbutton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundbutton4.ForeColor = System.Drawing.Color.White;
            this.roundbutton4.Location = new System.Drawing.Point(0, 265);
            this.roundbutton4.Name = "roundbutton4";
            this.roundbutton4.Size = new System.Drawing.Size(135, 40);
            this.roundbutton4.TabIndex = 29;
            this.roundbutton4.Text = "Reportes";
            this.roundbutton4.TextColor = System.Drawing.Color.White;
            this.roundbutton4.UseVisualStyleBackColor = false;
            // 
            // roundbutton3
            // 
            this.roundbutton3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.roundbutton3.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.roundbutton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundbutton3.BorderRadius = 0;
            this.roundbutton3.BorderSize = 0;
            this.roundbutton3.FlatAppearance.BorderSize = 0;
            this.roundbutton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundbutton3.ForeColor = System.Drawing.Color.White;
            this.roundbutton3.Location = new System.Drawing.Point(0, 211);
            this.roundbutton3.Name = "roundbutton3";
            this.roundbutton3.Size = new System.Drawing.Size(135, 40);
            this.roundbutton3.TabIndex = 28;
            this.roundbutton3.Text = "Empleados";
            this.roundbutton3.TextColor = System.Drawing.Color.White;
            this.roundbutton3.UseVisualStyleBackColor = false;
            // 
            // roundbutton2
            // 
            this.roundbutton2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.roundbutton2.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.roundbutton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundbutton2.BorderRadius = 0;
            this.roundbutton2.BorderSize = 0;
            this.roundbutton2.FlatAppearance.BorderSize = 0;
            this.roundbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundbutton2.ForeColor = System.Drawing.Color.White;
            this.roundbutton2.Location = new System.Drawing.Point(0, 158);
            this.roundbutton2.Name = "roundbutton2";
            this.roundbutton2.Size = new System.Drawing.Size(135, 40);
            this.roundbutton2.TabIndex = 27;
            this.roundbutton2.Text = "Usuarios";
            this.roundbutton2.TextColor = System.Drawing.Color.White;
            this.roundbutton2.UseVisualStyleBackColor = false;
            // 
            // roundbutton1
            // 
            this.roundbutton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundbutton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.roundbutton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundbutton1.BorderRadius = 0;
            this.roundbutton1.BorderSize = 0;
            this.roundbutton1.FlatAppearance.BorderSize = 0;
            this.roundbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundbutton1.ForeColor = System.Drawing.Color.White;
            this.roundbutton1.Location = new System.Drawing.Point(0, 107);
            this.roundbutton1.Name = "roundbutton1";
            this.roundbutton1.Size = new System.Drawing.Size(135, 40);
            this.roundbutton1.TabIndex = 26;
            this.roundbutton1.Text = "Productos";
            this.roundbutton1.TextColor = System.Drawing.Color.White;
            this.roundbutton1.UseVisualStyleBackColor = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataSource = typeof(Sonora_Creativa.Productos);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1093, 576);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.roundbutton5);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.roundbutton4);
            this.Controls.Add(this.roundbutton3);
            this.Controls.Add(this.roundbutton2);
            this.Controls.Add(this.roundbutton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomControls.RJControls.roundbutton roundbutton1;
        private CustomControls.RJControls.roundbutton roundbutton2;
        private CustomControls.RJControls.roundbutton roundbutton3;
        private CustomControls.RJControls.roundbutton roundbutton4;
        private System.Windows.Forms.Label lblProductos;
        private CustomControls.RJControls.roundbutton roundbutton5;
        private System.Windows.Forms.TextBox txtId;
    }
}