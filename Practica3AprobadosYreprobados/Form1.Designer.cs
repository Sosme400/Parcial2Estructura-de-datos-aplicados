namespace AprobadosReprobadosApp
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrarResultados = new System.Windows.Forms.Button();
            this.lstAprobados = new System.Windows.Forms.ListView();
            this.lstReprobados = new System.Windows.Forms.ListView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.lblAprobados = new System.Windows.Forms.Label();
            this.lblReprobados = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // Título del formulario
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(180, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(105, 22);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Práctica 3";

            // Campo de texto para el nombre
            this.txtNombre.Location = new System.Drawing.Point(50, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;

            // Campo de texto para la calificación
            this.txtCalificacion.Location = new System.Drawing.Point(180, 50);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(100, 20);
            this.txtCalificacion.TabIndex = 1;

            // Botón para agregar alumnos
            this.btnAgregar.Location = new System.Drawing.Point(50, 80);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar Alumno";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            // Botón para mostrar los resultados
            this.btnMostrarResultados.Location = new System.Drawing.Point(180, 80);
            this.btnMostrarResultados.Name = "btnMostrarResultados";
            this.btnMostrarResultados.Size = new System.Drawing.Size(100, 23);
            this.btnMostrarResultados.TabIndex = 3;
            this.btnMostrarResultados.Text = "Mostrar Resultados";
            this.btnMostrarResultados.UseVisualStyleBackColor = true;
            this.btnMostrarResultados.Click += new System.EventHandler(this.btnMostrarResultados_Click);

            // ListView para los alumnos aprobados
            this.lstAprobados.Location = new System.Drawing.Point(50, 140);
            this.lstAprobados.Name = "lstAprobados";
            this.lstAprobados.Size = new System.Drawing.Size(120, 160);
            this.lstAprobados.TabIndex = 4;
            this.lstAprobados.View = System.Windows.Forms.View.List;

            // ListView para los alumnos reprobados
            this.lstReprobados.Location = new System.Drawing.Point(220, 140);
            this.lstReprobados.Name = "lstReprobados";
            this.lstReprobados.Size = new System.Drawing.Size(120, 160);
            this.lstReprobados.TabIndex = 5;
            this.lstReprobados.View = System.Windows.Forms.View.List;

            // Etiqueta para el campo de nombre
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(50, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";

            // Etiqueta para el campo de calificación
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Location = new System.Drawing.Point(180, 30);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(61, 13);
            this.lblCalificacion.TabIndex = 7;
            this.lblCalificacion.Text = "Calificación";

            // Etiqueta para aprobados
            this.lblAprobados.AutoSize = true;
            this.lblAprobados.Location = new System.Drawing.Point(50, 120);
            this.lblAprobados.Name = "lblAprobados";
            this.lblAprobados.Size = new System.Drawing.Size(60, 13);
            this.lblAprobados.TabIndex = 8;
            this.lblAprobados.Text = "Aprobados";

            // Etiqueta para reprobados
            this.lblReprobados.AutoSize = true;
            this.lblReprobados.Location = new System.Drawing.Point(220, 120);
            this.lblReprobados.Name = "lblReprobados";
            this.lblReprobados.Size = new System.Drawing.Size(67, 13);
            this.lblReprobados.TabIndex = 9;
            this.lblReprobados.Text = "Reprobados";

            // Agregar controles al formulario
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCalificacion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnMostrarResultados);
            this.Controls.Add(this.lblReprobados);
            this.Controls.Add(this.lblAprobados);
            this.Controls.Add(this.lstReprobados);
            this.Controls.Add(this.lstAprobados);
            this.Name = "Form1";
            this.Text = "Aprobados y Reprobados - Práctica 3";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListView lstAprobados;
        private System.Windows.Forms.ListView lstReprobados;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrarResultados;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.Label lblAprobados;
        private System.Windows.Forms.Label lblReprobados;
        private System.Windows.Forms.Label lblTitulo;
    }
}

