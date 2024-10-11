namespace SupermercadoApp
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnRetirarProducto = new System.Windows.Forms.Button();
            this.lstDisponibles = new System.Windows.Forms.ListBox();
            this.lstRetirados = new System.Windows.Forms.ListBox();
            this.lblDisponibles = new System.Windows.Forms.Label();
            this.lblRetirados = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label(); // Título "Práctica 1"
            this.SuspendLayout();

            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(230, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(105, 22);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Práctica 1";

            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(100, 50);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(150, 30);
            this.btnAgregarProducto.TabIndex = 1;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);

            // 
            // btnRetirarProducto
            // 
            this.btnRetirarProducto.Location = new System.Drawing.Point(300, 50);
            this.btnRetirarProducto.Name = "btnRetirarProducto";
            this.btnRetirarProducto.Size = new System.Drawing.Size(150, 30);
            this.btnRetirarProducto.TabIndex = 2;
            this.btnRetirarProducto.Text = "Retirar Producto";
            this.btnRetirarProducto.UseVisualStyleBackColor = true;
            this.btnRetirarProducto.Click += new System.EventHandler(this.btnRetirarProducto_Click);

            // 
            // lstDisponibles
            // 
            this.lstDisponibles.FormattingEnabled = true;
            this.lstDisponibles.Location = new System.Drawing.Point(50, 110);
            this.lstDisponibles.Name = "lstDisponibles";
            this.lstDisponibles.Size = new System.Drawing.Size(250, 160);
            this.lstDisponibles.TabIndex = 3;

            // 
            // lstRetirados
            // 
            this.lstRetirados.FormattingEnabled = true;
            this.lstRetirados.Location = new System.Drawing.Point(350, 110);
            this.lstRetirados.Name = "lstRetirados";
            this.lstRetirados.Size = new System.Drawing.Size(250, 160);
            this.lstRetirados.TabIndex = 4;

            // 
            // lblDisponibles
            // 
            this.lblDisponibles.AutoSize = true;
            this.lblDisponibles.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblDisponibles.Location = new System.Drawing.Point(50, 90);
            this.lblDisponibles.Name = "lblDisponibles";
            this.lblDisponibles.Size = new System.Drawing.Size(150, 16);
            this.lblDisponibles.TabIndex = 5;
            this.lblDisponibles.Text = "Productos Disponibles";

            // 
            // lblRetirados
            // 
            this.lblRetirados.AutoSize = true;
            this.lblRetirados.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblRetirados.Location = new System.Drawing.Point(350, 90);
            this.lblRetirados.Name = "lblRetirados";
            this.lblRetirados.Size = new System.Drawing.Size(140, 16);
            this.lblRetirados.TabIndex = 6;
            this.lblRetirados.Text = "Productos Retirados";

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(650, 300);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.btnRetirarProducto);
            this.Controls.Add(this.lblDisponibles);
            this.Controls.Add(this.lstDisponibles);
            this.Controls.Add(this.lblRetirados);
            this.Controls.Add(this.lstRetirados);
            this.Name = "Form1";
            this.Text = "Supermercado - Productos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnRetirarProducto;
        private System.Windows.Forms.ListBox lstDisponibles;
        private System.Windows.Forms.ListBox lstRetirados;
        private System.Windows.Forms.Label lblDisponibles;
        private System.Windows.Forms.Label lblRetirados;
        private System.Windows.Forms.Label lblTitulo;

        #endregion
    }
}
