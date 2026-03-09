namespace WinMySQL.Views
{
    partial class frmProfesor
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
            txtMatricula = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtAppPaterno = new TextBox();
            label4 = new Label();
            txtAppMaterno = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 24);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Matricula";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(24, 54);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(254, 23);
            txtMatricula.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 113);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(24, 157);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(254, 23);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 214);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 4;
            label3.Text = "Appellido Paterno";
            // 
            // txtAppPaterno
            // 
            txtAppPaterno.Location = new Point(24, 257);
            txtAppPaterno.Name = "txtAppPaterno";
            txtAppPaterno.Size = new Size(254, 23);
            txtAppPaterno.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 320);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 6;
            label4.Text = "Appellido Materno";
            // 
            // txtAppMaterno
            // 
            txtAppMaterno.Location = new Point(24, 354);
            txtAppMaterno.Name = "txtAppMaterno";
            txtAppMaterno.Size = new Size(254, 23);
            txtAppMaterno.TabIndex = 7;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(109, 425);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 460);
            Controls.Add(btnAceptar);
            Controls.Add(txtAppMaterno);
            Controls.Add(label4);
            Controls.Add(txtAppPaterno);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtMatricula);
            Controls.Add(label1);
            Name = "frmProfesor";
            Text = "Profesor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMatricula;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtAppPaterno;
        private Label label4;
        private TextBox txtAppMaterno;
        private Button btnAceptar;
    }
}