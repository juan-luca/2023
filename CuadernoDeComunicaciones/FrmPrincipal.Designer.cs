namespace CuadernoDeComunicaciones
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Button btnComunicaciones;
        private Button btnCalificaciones;
        private Button btnPerfiles;
        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnComunicaciones = new Button();
            btnCalificaciones = new Button();
            btnPerfiles = new Button();
            SuspendLayout();
            // 
            // btnComunicaciones
            // 
            btnComunicaciones.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnComunicaciones.Location = new Point(91, 119);
            btnComunicaciones.Name = "btnComunicaciones";
            btnComunicaciones.Size = new Size(235, 62);
            btnComunicaciones.TabIndex = 0;
            btnComunicaciones.Text = "Comunicaciones";
            btnComunicaciones.UseVisualStyleBackColor = true;
            btnComunicaciones.Click += btnComunicaciones_Click;
            // 
            // btnCalificaciones
            // 
            btnCalificaciones.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalificaciones.Location = new Point(426, 119);
            btnCalificaciones.Name = "btnCalificaciones";
            btnCalificaciones.Size = new Size(235, 62);
            btnCalificaciones.TabIndex = 1;
            btnCalificaciones.Text = "Calificaciones";
            btnCalificaciones.UseVisualStyleBackColor = true;
            btnCalificaciones.Click += btnCalificaciones_Click;
            // 
            // btnPerfiles
            // 
            btnPerfiles.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnPerfiles.Location = new Point(228, 281);
            btnPerfiles.Name = "btnPerfiles";
            btnPerfiles.Size = new Size(300, 50);
            btnPerfiles.TabIndex = 2;
            btnPerfiles.Text = "Perfiles";
            btnPerfiles.UseVisualStyleBackColor = true;
            btnPerfiles.Click += btnPerfiles_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(790, 439);
            Controls.Add(btnPerfiles);
            Controls.Add(btnCalificaciones);
            Controls.Add(btnComunicaciones);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cuaderno de Comunicaciones";
            ResumeLayout(false);
        }

        #endregion
    }
}