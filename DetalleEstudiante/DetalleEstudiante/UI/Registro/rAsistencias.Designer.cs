namespace DetalleEstudiante.UI.Registro
{
    partial class rAsistencias
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rAsistencias));
            this.AsistenciaIDlabel = new System.Windows.Forms.Label();
            this.AsistenciaIDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Asignaturalabel = new System.Windows.Forms.Label();
            this.AsignaturacomboBox = new System.Windows.Forms.ComboBox();
            this.Fechalabel = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.Removerbutton = new System.Windows.Forms.Button();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.EstudianteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presentes = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.AgregarEstudiantebutton = new System.Windows.Forms.Button();
            this.PresentecheckBox = new System.Windows.Forms.CheckBox();
            this.EstudiantecomboBox = new System.Windows.Forms.ComboBox();
            this.Estudiantelabel = new System.Windows.Forms.Label();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Cantidadlabel = new System.Windows.Forms.Label();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Gurdarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AsistenciaIDnumericUpDown)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // AsistenciaIDlabel
            // 
            this.AsistenciaIDlabel.AutoSize = true;
            this.AsistenciaIDlabel.Location = new System.Drawing.Point(12, 14);
            this.AsistenciaIDlabel.Name = "AsistenciaIDlabel";
            this.AsistenciaIDlabel.Size = new System.Drawing.Size(69, 13);
            this.AsistenciaIDlabel.TabIndex = 0;
            this.AsistenciaIDlabel.Text = "Asistencia ID";
            // 
            // AsistenciaIDnumericUpDown
            // 
            this.AsistenciaIDnumericUpDown.Location = new System.Drawing.Point(87, 11);
            this.AsistenciaIDnumericUpDown.Name = "AsistenciaIDnumericUpDown";
            this.AsistenciaIDnumericUpDown.Size = new System.Drawing.Size(102, 20);
            this.AsistenciaIDnumericUpDown.TabIndex = 1;
            // 
            // Asignaturalabel
            // 
            this.Asignaturalabel.AutoSize = true;
            this.Asignaturalabel.Location = new System.Drawing.Point(42, 55);
            this.Asignaturalabel.Name = "Asignaturalabel";
            this.Asignaturalabel.Size = new System.Drawing.Size(57, 13);
            this.Asignaturalabel.TabIndex = 0;
            this.Asignaturalabel.Text = "Asignatura";
            // 
            // AsignaturacomboBox
            // 
            this.AsignaturacomboBox.FormattingEnabled = true;
            this.AsignaturacomboBox.Location = new System.Drawing.Point(105, 51);
            this.AsignaturacomboBox.Name = "AsignaturacomboBox";
            this.AsignaturacomboBox.Size = new System.Drawing.Size(272, 21);
            this.AsignaturacomboBox.TabIndex = 2;
            // 
            // Fechalabel
            // 
            this.Fechalabel.AutoSize = true;
            this.Fechalabel.Location = new System.Drawing.Point(305, 14);
            this.Fechalabel.Name = "Fechalabel";
            this.Fechalabel.Size = new System.Drawing.Size(37, 13);
            this.Fechalabel.TabIndex = 0;
            this.Fechalabel.Text = "Fecha";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(348, 11);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(85, 20);
            this.FechadateTimePicker.TabIndex = 3;
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox.Controls.Add(this.Removerbutton);
            this.groupBox.Controls.Add(this.DetalledataGridView);
            this.groupBox.Controls.Add(this.Agregarbutton);
            this.groupBox.Controls.Add(this.AgregarEstudiantebutton);
            this.groupBox.Controls.Add(this.PresentecheckBox);
            this.groupBox.Controls.Add(this.EstudiantecomboBox);
            this.groupBox.Controls.Add(this.Estudiantelabel);
            this.groupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox.Location = new System.Drawing.Point(15, 78);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(418, 324);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Asistencia";
            // 
            // Removerbutton
            // 
            this.Removerbutton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Removerbutton.Image = ((System.Drawing.Image)(resources.GetObject("Removerbutton.Image")));
            this.Removerbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Removerbutton.Location = new System.Drawing.Point(293, 279);
            this.Removerbutton.Name = "Removerbutton";
            this.Removerbutton.Size = new System.Drawing.Size(119, 40);
            this.Removerbutton.TabIndex = 6;
            this.Removerbutton.Text = "-Remover Filas";
            this.Removerbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Removerbutton.UseVisualStyleBackColor = false;
            this.Removerbutton.Click += new System.EventHandler(this.Removerbutton_Click);
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EstudianteID,
            this.NombreColumn,
            this.Presentes});
            this.DetalledataGridView.Location = new System.Drawing.Point(12, 88);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.ReadOnly = true;
            this.DetalledataGridView.Size = new System.Drawing.Size(400, 172);
            this.DetalledataGridView.TabIndex = 5;
            // 
            // EstudianteID
            // 
            this.EstudianteID.HeaderText = "EstudianteID";
            this.EstudianteID.Name = "EstudianteID";
            this.EstudianteID.ReadOnly = true;
            // 
            // NombreColumn
            // 
            this.NombreColumn.HeaderText = "Nombres";
            this.NombreColumn.Name = "NombreColumn";
            this.NombreColumn.ReadOnly = true;
            this.NombreColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NombreColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Presentes
            // 
            this.Presentes.HeaderText = "Presentes";
            this.Presentes.Name = "Presentes";
            this.Presentes.ReadOnly = true;
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Agregarbutton.Image")));
            this.Agregarbutton.Location = new System.Drawing.Point(333, 44);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(43, 38);
            this.Agregarbutton.TabIndex = 4;
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // AgregarEstudiantebutton
            // 
            this.AgregarEstudiantebutton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarEstudiantebutton.Image")));
            this.AgregarEstudiantebutton.Location = new System.Drawing.Point(154, 44);
            this.AgregarEstudiantebutton.Name = "AgregarEstudiantebutton";
            this.AgregarEstudiantebutton.Size = new System.Drawing.Size(58, 38);
            this.AgregarEstudiantebutton.TabIndex = 3;
            this.AgregarEstudiantebutton.UseVisualStyleBackColor = true;
            this.AgregarEstudiantebutton.Click += new System.EventHandler(this.AgregarEstudiantebutton_Click);
            // 
            // PresentecheckBox
            // 
            this.PresentecheckBox.AutoSize = true;
            this.PresentecheckBox.Location = new System.Drawing.Point(232, 65);
            this.PresentecheckBox.Name = "PresentecheckBox";
            this.PresentecheckBox.Size = new System.Drawing.Size(68, 17);
            this.PresentecheckBox.TabIndex = 2;
            this.PresentecheckBox.Text = "Presente";
            this.PresentecheckBox.UseVisualStyleBackColor = true;
            // 
            // EstudiantecomboBox
            // 
            this.EstudiantecomboBox.FormattingEnabled = true;
            this.EstudiantecomboBox.Location = new System.Drawing.Point(12, 61);
            this.EstudiantecomboBox.Name = "EstudiantecomboBox";
            this.EstudiantecomboBox.Size = new System.Drawing.Size(121, 21);
            this.EstudiantecomboBox.TabIndex = 1;
            // 
            // Estudiantelabel
            // 
            this.Estudiantelabel.AutoSize = true;
            this.Estudiantelabel.Location = new System.Drawing.Point(9, 44);
            this.Estudiantelabel.Name = "Estudiantelabel";
            this.Estudiantelabel.Size = new System.Drawing.Size(57, 13);
            this.Estudiantelabel.TabIndex = 0;
            this.Estudiantelabel.Text = "Estudiante";
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // Cantidadlabel
            // 
            this.Cantidadlabel.AutoSize = true;
            this.Cantidadlabel.Location = new System.Drawing.Point(12, 421);
            this.Cantidadlabel.Name = "Cantidadlabel";
            this.Cantidadlabel.Size = new System.Drawing.Size(49, 13);
            this.Cantidadlabel.TabIndex = 0;
            this.Cantidadlabel.Text = "Cantidad";
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Location = new System.Drawing.Point(67, 418);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(100, 20);
            this.CantidadtextBox.TabIndex = 10;
            this.CantidadtextBox.TextChanged += new System.EventHandler(this.CantidadtextBox_TextChanged);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.AutoSize = true;
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(295, 477);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(82, 37);
            this.Eliminarbutton.TabIndex = 9;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Gurdarbutton
            // 
            this.Gurdarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Gurdarbutton.Image")));
            this.Gurdarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Gurdarbutton.Location = new System.Drawing.Point(169, 477);
            this.Gurdarbutton.Name = "Gurdarbutton";
            this.Gurdarbutton.Size = new System.Drawing.Size(83, 37);
            this.Gurdarbutton.TabIndex = 8;
            this.Gurdarbutton.Text = "Guardar";
            this.Gurdarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Gurdarbutton.UseVisualStyleBackColor = true;
            this.Gurdarbutton.Click += new System.EventHandler(this.Gurdarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(53, 477);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(83, 37);
            this.Nuevobutton.TabIndex = 7;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(196, 4);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 34);
            this.Buscarbutton.TabIndex = 6;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // rAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(445, 526);
            this.Controls.Add(this.CantidadtextBox);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Gurdarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.AsignaturacomboBox);
            this.Controls.Add(this.AsistenciaIDnumericUpDown);
            this.Controls.Add(this.Cantidadlabel);
            this.Controls.Add(this.Asignaturalabel);
            this.Controls.Add(this.Fechalabel);
            this.Controls.Add(this.AsistenciaIDlabel);
            this.MaximizeBox = false;
            this.Name = "rAsistencias";
            this.Text = "Registro de Asistencia";
            ((System.ComponentModel.ISupportInitialize)(this.AsistenciaIDnumericUpDown)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AsistenciaIDlabel;
        private System.Windows.Forms.NumericUpDown AsistenciaIDnumericUpDown;
        private System.Windows.Forms.Label Asignaturalabel;
        private System.Windows.Forms.ComboBox AsignaturacomboBox;
        private System.Windows.Forms.Label Fechalabel;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.Button AgregarEstudiantebutton;
        private System.Windows.Forms.CheckBox PresentecheckBox;
        private System.Windows.Forms.ComboBox EstudiantecomboBox;
        private System.Windows.Forms.Label Estudiantelabel;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Gurdarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.Label Cantidadlabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstudianteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Presentes;
        private System.Windows.Forms.Button Removerbutton;
        private System.Windows.Forms.DataGridView DetalledataGridView;
    }

}