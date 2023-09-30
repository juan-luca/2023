namespace Clase_forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            btnMostrar = new Button();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lstEmpleados = new ListBox();
            gbGenero = new GroupBox();
            rdMasculino = new RadioButton();
            rdFemenino = new RadioButton();
            txtSalario = new TextBox();
            lblSalario = new Label();
            dataGridView1 = new DataGridView();
            lblTareas = new Label();
            cbTareas = new ComboBox();
            gbGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(234, 27);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(118, 37);
            btnMostrar.TabIndex = 0;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(36, 17);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(36, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(176, 23);
            txtNombre.TabIndex = 2;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 15;
            lstEmpleados.Location = new Point(491, 204);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(120, 94);
            lstEmpleados.TabIndex = 5;
            // 
            // gbGenero
            // 
            gbGenero.Controls.Add(rdMasculino);
            gbGenero.Controls.Add(rdFemenino);
            gbGenero.Location = new Point(428, 69);
            gbGenero.Name = "gbGenero";
            gbGenero.Size = new Size(200, 100);
            gbGenero.TabIndex = 6;
            gbGenero.TabStop = false;
            gbGenero.Text = "Genero";
            // 
            // rdMasculino
            // 
            rdMasculino.AutoSize = true;
            rdMasculino.Location = new Point(30, 67);
            rdMasculino.Name = "rdMasculino";
            rdMasculino.Size = new Size(80, 19);
            rdMasculino.TabIndex = 1;
            rdMasculino.Text = "Masculino";
            rdMasculino.UseVisualStyleBackColor = true;
            // 
            // rdFemenino
            // 
            rdFemenino.AutoSize = true;
            rdFemenino.Location = new Point(31, 33);
            rdFemenino.Name = "rdFemenino";
            rdFemenino.Size = new Size(78, 19);
            rdFemenino.TabIndex = 0;
            rdFemenino.Text = "Femenino";
            rdFemenino.UseVisualStyleBackColor = true;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(36, 98);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(176, 23);
            txtSalario.TabIndex = 8;
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Location = new Point(36, 80);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(42, 15);
            lblSalario.TabIndex = 7;
            lblSalario.Text = "Salario";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(84, 346);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(724, 248);
            dataGridView1.TabIndex = 9;
            // 
            // lblTareas
            // 
            lblTareas.AutoSize = true;
            lblTareas.Location = new Point(36, 140);
            lblTareas.Name = "lblTareas";
            lblTareas.Size = new Size(39, 15);
            lblTareas.TabIndex = 10;
            lblTareas.Text = "Tareas";
            // 
            // cbTareas
            // 
            cbTareas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTareas.FormattingEnabled = true;
            cbTareas.Location = new Point(36, 158);
            cbTareas.Name = "cbTareas";
            cbTareas.Size = new Size(121, 23);
            cbTareas.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 606);
            Controls.Add(cbTareas);
            Controls.Add(lblTareas);
            Controls.Add(dataGridView1);
            Controls.Add(txtSalario);
            Controls.Add(lblSalario);
            Controls.Add(gbGenero);
            Controls.Add(lstEmpleados);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(btnMostrar);
            Name = "Form1";
            Text = "Form1";
            gbGenero.ResumeLayout(false);
            gbGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostrar;
        private Label lblNombre;
        private TextBox txtNombre;
        private ListBox lstEmpleados;
        private GroupBox gbGenero;
        private RadioButton rdMasculino;
        private RadioButton rdFemenino;
        private TextBox txtSalario;
        private Label lblSalario;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Tarea;
        private Label lblTareas;
        private ComboBox cbTareas;
    }
}