namespace CuadernoDeComunicaciones.Formularios
{
    partial class FrmConfiguracion
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
            chkModoOscuro = new CheckBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // chkModoOscuro
            // 
            chkModoOscuro.AutoSize = true;
            chkModoOscuro.Location = new Point(14, 14);
            chkModoOscuro.Margin = new Padding(4, 3, 4, 3);
            chkModoOscuro.Name = "chkModoOscuro";
            chkModoOscuro.Size = new Size(99, 19);
            chkModoOscuro.TabIndex = 0;
            chkModoOscuro.Text = "Modo Oscuro";
            chkModoOscuro.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(14, 58);
            btnGuardar.Margin = new Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(88, 27);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmConfiguracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(233, 115);
            Controls.Add(btnGuardar);
            Controls.Add(chkModoOscuro);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmConfiguracion";
            Text = "Configuraciones";
            ResumeLayout(false);
            PerformLayout();
        }

        private CheckBox chkModoOscuro;
        private Button btnGuardar;
    }
}
