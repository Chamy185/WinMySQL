namespace WinMySQL.Views
{
    partial class frmAlumno
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
            label1 = new Label();
            txtNoControl = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtApellidoPaterno = new TextBox();
            label4 = new Label();
            txtApellidoMaterno = new TextBox();
            label5 = new Label();
            txtSemestre = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 26);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero de Control";
            // 
            // txtNoControl
            // 
            txtNoControl.Location = new Point(23, 62);
            txtNoControl.Name = "txtNoControl";
            txtNoControl.Size = new Size(229, 23);
            txtNoControl.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 117);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(23, 147);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(229, 23);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 207);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 4;
            label2.Text = "Appelido Paterno";
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Location = new Point(23, 248);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(229, 23);
            txtApellidoPaterno.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 306);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 6;
            label4.Text = "Apellido Materno";
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Location = new Point(23, 349);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(229, 23);
            txtApellidoMaterno.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 404);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 8;
            label5.Text = "Semestre";
            // 
            // txtSemestre
            // 
            txtSemestre.Location = new Point(23, 437);
            txtSemestre.Name = "txtSemestre";
            txtSemestre.Size = new Size(226, 23);
            txtSemestre.TabIndex = 9;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(94, 500);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 545);
            Controls.Add(btnAceptar);
            Controls.Add(txtSemestre);
            Controls.Add(label5);
            Controls.Add(txtApellidoMaterno);
            Controls.Add(label4);
            Controls.Add(txtApellidoPaterno);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtNoControl);
            Controls.Add(label1);
            Name = "frmAlumno";
            Text = "Alumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNoControl;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtApellidoPaterno;
        private Label label4;
        private TextBox txtApellidoMaterno;
        private Label label5;
        private TextBox txtSemestre;
        private Button btnAceptar;
    }
}