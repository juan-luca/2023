namespace ControlDeEmpleados
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewEmpleados = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.groupBoxGenero = new System.Windows.Forms.GroupBox();
            this.chkMasculino = new System.Windows.Forms.CheckBox();
            this.chkFemenino = new System.Windows.Forms.CheckBox();
            this.lblTareas = new System.Windows.Forms.Label();
            this.comboBoxTareas = new System.Windows.Forms.ComboBox();
            this.btnGuardarEmpleado = new System.Windows.Forms.Button();
            this.dataGridViewTareas = new System.Windows.Forms.DataGridView(); // DataGridView de tareas
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
            this.groupBoxGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTareas)).BeginInit(); // Inicialización del DataGridView de tareas
            this.SuspendLayout();
            // 
            // dataGridViewEmpleados
            // 
            this.dataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleados.Location = new System.Drawing.Point(12, 255);
            this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            this.dataGridViewEmpleados.Size = new System.Drawing.Size(500, 150);
            this.dataGridViewEmpleados.TabIndex = 0;
            // ...

            // 
            // dataGridViewTareas
            // 
            this.dataGridViewTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTareas.Location = new System.Drawing.Point(12, 410); // Ubicación y tamaño del DataGridView de tareas
            this.dataGridViewTareas.Name = "dataGridViewTareas";
            this.dataGridViewTareas.Size = new System.Drawing.Size(500, 150); // Tamaño del DataGridView de tareas
            this.dataGridViewTareas.TabIndex = 9; // Índice del DataGridView de tareas
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(65, 17);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(160, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(12, 50);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(42, 13);
            this.lblSalario.TabIndex = 3;
            this.lblSalario.Text = "Salario:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(65, 47);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(160, 20);
            this.txtSalario.TabIndex = 4;
            // 
            // groupBoxGenero
            // 
            this.groupBoxGenero.Controls.Add(this.chkFemenino);
            this.groupBoxGenero.Controls.Add(this.chkMasculino);
            this.groupBoxGenero.Location = new System.Drawing.Point(15, 87);
            this.groupBoxGenero.Name = "groupBoxGenero";
            this.groupBoxGenero.Size = new System.Drawing.Size(210, 70);
            this.groupBoxGenero.TabIndex = 5;
            this.groupBoxGenero.TabStop = false;
            this.groupBoxGenero.Text = "Género";
            // 
            // chkMasculino
            // 
            this.chkMasculino.AutoSize = true;
            this.chkMasculino.Location = new System.Drawing.Point(6, 31);
            this.chkMasculino.Name = "chkMasculino";
            this.chkMasculino.Size = new System.Drawing.Size(74, 17);
            this.chkMasculino.TabIndex = 0;
            this.chkMasculino.Text = "Masculino";
            this.chkMasculino.UseVisualStyleBackColor = true;
            // 
            // chkFemenino
            // 
            this.chkFemenino.AutoSize = true;
            this.chkFemenino.Location = new System.Drawing.Point(101, 31);
            this.chkFemenino.Name = "chkFemenino";
            this.chkFemenino.Size = new System.Drawing.Size(71, 17);
            this.chkFemenino.TabIndex = 1;
            this.chkFemenino.Text = "Femenino";
            this.chkFemenino.UseVisualStyleBackColor = true;
            // 
            // lblTareas
            // 
            this.lblTareas.AutoSize = true;
            this.lblTareas.Location = new System.Drawing.Point(12, 179);
            this.lblTareas.Name = "lblTareas";
            this.lblTareas.Size = new System.Drawing.Size(44, 13);
            this.lblTareas.TabIndex = 6;
            this.lblTareas.Text = "Tareas:";
            // 
            // comboBoxTareas
            // 
            this.comboBoxTareas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTareas.FormattingEnabled = true;
            
            this.comboBoxTareas.Location = new System.Drawing.Point(65, 176);
            this.comboBoxTareas.Name = "comboBoxTareas";
            this.comboBoxTareas.Size = new System.Drawing.Size(160, 21);
            this.comboBoxTareas.TabIndex = 7;
            // 
            // btnGuardarEmpleado
            // 
            this.btnGuardarEmpleado.Location = new System.Drawing.Point(15, 218);
            this.btnGuardarEmpleado.Name = "btnGuardarEmpleado";
            this.btnGuardarEmpleado.Size = new System.Drawing.Size(100, 25);
            this.btnGuardarEmpleado.TabIndex = 8;
            this.btnGuardarEmpleado.Text = "Guardar Empleado";
            this.btnGuardarEmpleado.UseVisualStyleBackColor = true;
            this.btnGuardarEmpleado.Click += new System.EventHandler(this.btnGuardarEmpleado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 417);
            this.Controls.Add(this.btnGuardarEmpleado);
            this.Controls.Add(this.comboBoxTareas);
            this.Controls.Add(this.lblTareas);
            this.Controls.Add(this.groupBoxGenero);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dataGridViewEmpleados);
            this.Name = "Form1";
            this.Text = "Mi Aplicación";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).EndInit();
            this.groupBoxGenero.ResumeLayout(false);
            this.groupBoxGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmpleados;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.GroupBox groupBoxGenero;
        private System.Windows.Forms.CheckBox chkMasculino;
        private System.Windows.Forms.CheckBox chkFemenino;
        private System.Windows.Forms.Label lblTareas;
        private System.Windows.Forms.ComboBox comboBoxTareas;
        private System.Windows.Forms.Button btnGuardarEmpleado;
    }
}
