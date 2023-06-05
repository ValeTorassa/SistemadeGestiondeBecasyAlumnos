
namespace SistemaBecasUniversitarias_TorassaColomberoValentin
{
    partial class Form
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
            dtgvAlumnos = new DataGridView();
            dgtvBecas = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnCrear = new Button();
            btnBorrar = new Button();
            btnModificar = new Button();
            btnRemover = new Button();
            btnAsignar = new Button();
            dgtvSeleccionado = new DataGridView();
            label5 = new Label();
            lblError = new Label();
            btnSimularPago = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgtvBecas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgtvSeleccionado).BeginInit();
            SuspendLayout();
            // 
            // dtgvAlumnos
            // 
            dtgvAlumnos.AllowDrop = true;
            dtgvAlumnos.AllowUserToAddRows = false;
            dtgvAlumnos.AllowUserToDeleteRows = false;
            dtgvAlumnos.AllowUserToResizeColumns = false;
            dtgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAlumnos.Location = new Point(14, 84);
            dtgvAlumnos.Margin = new Padding(4, 3, 4, 3);
            dtgvAlumnos.MultiSelect = false;
            dtgvAlumnos.Name = "dtgvAlumnos";
            dtgvAlumnos.RowHeadersWidth = 20;
            dtgvAlumnos.Size = new Size(488, 269);
            dtgvAlumnos.TabIndex = 0;
            dtgvAlumnos.CellClick += dtgvAlumnos_CellClick;
            dtgvAlumnos.CellLeave += dtgvAlumnos_CellLeave;
            // 
            // dgtvBecas
            // 
            dgtvBecas.AllowUserToAddRows = false;
            dgtvBecas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtvBecas.Location = new Point(603, 84);
            dgtvBecas.Margin = new Padding(4, 3, 4, 3);
            dgtvBecas.Name = "dgtvBecas";
            dgtvBecas.RowHeadersWidth = 20;
            dgtvBecas.Size = new Size(333, 160);
            dgtvBecas.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(319, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(328, 25);
            label1.TabIndex = 2;
            label1.Text = "Sistema de Administracion de Becas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 57);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 3;
            label2.Text = "Alumnos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(598, 57);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 21);
            label3.TabIndex = 4;
            label3.Text = "Becas";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(14, 372);
            btnAgregar.Margin = new Padding(4, 3, 4, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(115, 37);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar Alumno";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(387, 372);
            btnEliminar.Margin = new Padding(4, 3, 4, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(115, 37);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Borrar Alumno";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(603, 250);
            btnCrear.Margin = new Padding(4, 3, 4, 3);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(115, 37);
            btnCrear.TabIndex = 7;
            btnCrear.Text = "Crear Beca";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(821, 250);
            btnBorrar.Margin = new Padding(4, 3, 4, 3);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(115, 37);
            btnBorrar.TabIndex = 8;
            btnBorrar.Text = "Borrar Beca";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(198, 372);
            btnModificar.Margin = new Padding(4, 3, 4, 3);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(115, 37);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar Alumno";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(821, 425);
            btnRemover.Margin = new Padding(4, 3, 4, 3);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(115, 37);
            btnRemover.TabIndex = 13;
            btnRemover.Text = "Remover Beca";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnAsignar
            // 
            btnAsignar.Location = new Point(598, 425);
            btnAsignar.Margin = new Padding(4, 3, 4, 3);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(115, 37);
            btnAsignar.TabIndex = 12;
            btnAsignar.Text = "Asignar Beca";
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // dgtvSeleccionado
            // 
            dgtvSeleccionado.AllowUserToAddRows = false;
            dgtvSeleccionado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtvSeleccionado.Location = new Point(603, 326);
            dgtvSeleccionado.Margin = new Padding(4, 3, 4, 3);
            dgtvSeleccionado.Name = "dgtvSeleccionado";
            dgtvSeleccionado.RowHeadersWidth = 20;
            dgtvSeleccionado.Size = new Size(333, 66);
            dgtvSeleccionado.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(603, 302);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(196, 21);
            label5.TabIndex = 14;
            label5.Text = "Beca Alumno Seleccionado";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.Location = new Point(593, 396);
            lblError.Margin = new Padding(4, 0, 4, 0);
            lblError.Name = "lblError";
            lblError.Size = new Size(343, 13);
            lblError.TabIndex = 15;
            lblError.Text = "Error: No ha seleccionado a un alumno y/o una beca para asignar";
            // 
            // btnSimularPago
            // 
            btnSimularPago.Location = new Point(189, 437);
            btnSimularPago.Margin = new Padding(4, 3, 4, 3);
            btnSimularPago.Name = "btnSimularPago";
            btnSimularPago.Size = new Size(138, 65);
            btnSimularPago.TabIndex = 16;
            btnSimularPago.Text = "Simular Pago";
            btnSimularPago.UseVisualStyleBackColor = true;
            btnSimularPago.Click += btnSimularPago_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(994, 514);
            Controls.Add(btnSimularPago);
            Controls.Add(lblError);
            Controls.Add(label5);
            Controls.Add(btnRemover);
            Controls.Add(btnAsignar);
            Controls.Add(dgtvSeleccionado);
            Controls.Add(btnModificar);
            Controls.Add(btnBorrar);
            Controls.Add(btnCrear);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgtvBecas);
            Controls.Add(dtgvAlumnos);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form";
            Text = "Administrador de Becas";
            ((System.ComponentModel.ISupportInitialize)dtgvAlumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgtvBecas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgtvSeleccionado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvAlumnos;
        private System.Windows.Forms.DataGridView dgtvBecas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private Button btnRemover;
        private Button btnAsignar;
        private DataGridView dgtvSeleccionado;
        private Label label5;
        private Label lblError;
        private Button btnSimularPago;
    }
}

