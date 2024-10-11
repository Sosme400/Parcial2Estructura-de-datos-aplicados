namespace EliminarOrdenarProductosApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtClaveProducto = new System.Windows.Forms.TextBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnMostrarOrdenados = new System.Windows.Forms.Button();
            this.btnCalcularTotal = new System.Windows.Forms.Button();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblTotalCosto = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();  // Título de la práctica
            this.SuspendLayout();
            
            // 
            // lblTitulo (Práctica 4)
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(250, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(120, 26);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Práctica 4";

            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(20, 80);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(180, 20);
            this.txtNombreProducto.TabIndex = 0;
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(20, 140);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(180, 20);
            this.txtPrecioProducto.TabIndex = 1;
            // 
            // txtClaveProducto
            // 
            this.txtClaveProducto.Location = new System.Drawing.Point(20, 200);
            this.txtClaveProducto.Name = "txtClaveProducto";
            this.txtClaveProducto.Size = new System.Drawing.Size(180, 20);
            this.txtClaveProducto.TabIndex = 2;
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.Location = new System.Drawing.Point(380, 80);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(250, 160);
            this.lstProductos.TabIndex = 7;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.Blue;  // Nombre en azul
            this.lblNombre.Location = new System.Drawing.Point(20, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(93, 13);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre Producto:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.ForeColor = System.Drawing.Color.Green;  // Precio en verde
            this.lblPrecio.Location = new System.Drawing.Point(20, 120);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(79, 13);
            this.lblPrecio.TabIndex = 9;
            this.lblPrecio.Text = "Precio Producto";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.ForeColor = System.Drawing.Color.Red;  // Clave en rojo
            this.lblClave.Location = new System.Drawing.Point(20, 180);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(77, 13);
            this.lblClave.TabIndex = 10;
            this.lblClave.Text = "Clave Producto";
            // 
            // lblTotalCosto
            // 
            this.lblTotalCosto.AutoSize = true;
            this.lblTotalCosto.Location = new System.Drawing.Point(380, 260);
            this.lblTotalCosto.Name = "lblTotalCosto";
            this.lblTotalCosto.Size = new System.Drawing.Size(76, 13);
            this.lblTotalCosto.TabIndex = 11;
            this.lblTotalCosto.Text = "Costo Total: $0";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.LightGreen;  // Color de fondo
            this.btnAgregarProducto.Location = new System.Drawing.Point(20, 260);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(140, 30);
            this.btnAgregarProducto.TabIndex = 3;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.Salmon;  // Color de fondo
            this.btnEliminarProducto.Location = new System.Drawing.Point(20, 310);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(140, 30);
            this.btnEliminarProducto.TabIndex = 4;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnMostrarOrdenados
            // 
            this.btnMostrarOrdenados.BackColor = System.Drawing.Color.LightBlue;  // Color de fondo
            this.btnMostrarOrdenados.Location = new System.Drawing.Point(20, 360);
            this.btnMostrarOrdenados.Name = "btnMostrarOrdenados";
            this.btnMostrarOrdenados.Size = new System.Drawing.Size(140, 30);
            this.btnMostrarOrdenados.TabIndex = 5;
            this.btnMostrarOrdenados.Text = "Ordenar Productos";
            this.btnMostrarOrdenados.UseVisualStyleBackColor = false;
            this.btnMostrarOrdenados.Click += new System.EventHandler(this.btnMostrarOrdenados_Click);
            // 
            // btnCalcularTotal
            // 
            this.btnCalcularTotal.BackColor = System.Drawing.Color.LightGray;  // Color de fondo
            this.btnCalcularTotal.Location = new System.Drawing.Point(20, 410);
            this.btnCalcularTotal.Name = "btnCalcularTotal";
            this.btnCalcularTotal.Size = new System.Drawing.Size(140, 30);
            this.btnCalcularTotal.TabIndex = 6;
            this.btnCalcularTotal.Text = "Calcular Total";
            this.btnCalcularTotal.UseVisualStyleBackColor = false;
            this.btnCalcularTotal.Click += new System.EventHandler(this.btnCalcularTotal_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(700, 500);  // Tamaño de formulario ajustado
            this.Controls.Add(this.lblTitulo);  // Título de la práctica
            this.Controls.Add(this.lblTotalCosto);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lstProductos);
            this.Controls.Add(this.btnCalcularTotal);
            this.Controls.Add(this.btnMostrarOrdenados);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.txtClaveProducto);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Name = "Form1";
            this.Text = "Eliminar y Ordenar Productos - Práctica 4";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TextBox txtClaveProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnMostrarOrdenados;
        private System.Windows.Forms.Button btnCalcularTotal;
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblTotalCosto;
        private System.Windows.Forms.Label lblTitulo;  // Título de la práctica
    }
}
