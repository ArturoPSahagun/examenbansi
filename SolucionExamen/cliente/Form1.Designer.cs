namespace cliente
{
    partial class Form1
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
            this.AgregarNombreInput = new System.Windows.Forms.TextBox();
            this.AgregarDescripcionInput = new System.Windows.Forms.TextBox();
            this.AgregarBoton = new System.Windows.Forms.Button();
            this.AgregarTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ActualizarBoton = new System.Windows.Forms.Button();
            this.ActualizarDescripcionInput = new System.Windows.Forms.TextBox();
            this.ActualizarNombreInput = new System.Windows.Forms.TextBox();
            this.ActualizarIdInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.EliminarIdInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EliminarBoton = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ConsultarGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultarBoton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label777 = new System.Windows.Forms.Label();
            this.ConsultarDescripcionInput = new System.Windows.Forms.TextBox();
            this.ConsultarNombreInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ComboMetodo = new System.Windows.Forms.ComboBox();
            this.AgregarTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultarGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AgregarNombreInput
            // 
            this.AgregarNombreInput.Location = new System.Drawing.Point(121, 15);
            this.AgregarNombreInput.Name = "AgregarNombreInput";
            this.AgregarNombreInput.Size = new System.Drawing.Size(160, 20);
            this.AgregarNombreInput.TabIndex = 0;
            // 
            // AgregarDescripcionInput
            // 
            this.AgregarDescripcionInput.Location = new System.Drawing.Point(121, 41);
            this.AgregarDescripcionInput.Name = "AgregarDescripcionInput";
            this.AgregarDescripcionInput.Size = new System.Drawing.Size(160, 20);
            this.AgregarDescripcionInput.TabIndex = 1;
            // 
            // AgregarBoton
            // 
            this.AgregarBoton.Location = new System.Drawing.Point(121, 115);
            this.AgregarBoton.Name = "AgregarBoton";
            this.AgregarBoton.Size = new System.Drawing.Size(75, 23);
            this.AgregarBoton.TabIndex = 2;
            this.AgregarBoton.Text = "Agregar";
            this.AgregarBoton.UseVisualStyleBackColor = true;
            this.AgregarBoton.Click += new System.EventHandler(this.AgregarBoton_Click);
            // 
            // AgregarTab
            // 
            this.AgregarTab.Controls.Add(this.tabPage1);
            this.AgregarTab.Controls.Add(this.tabPage2);
            this.AgregarTab.Controls.Add(this.tabPage3);
            this.AgregarTab.Controls.Add(this.tabPage4);
            this.AgregarTab.Location = new System.Drawing.Point(2, 69);
            this.AgregarTab.Name = "AgregarTab";
            this.AgregarTab.SelectedIndex = 0;
            this.AgregarTab.Size = new System.Drawing.Size(380, 380);
            this.AgregarTab.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.AgregarNombreInput);
            this.tabPage1.Controls.Add(this.AgregarBoton);
            this.tabPage1.Controls.Add(this.AgregarDescripcionInput);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(372, 354);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ActualizarBoton);
            this.tabPage2.Controls.Add(this.ActualizarDescripcionInput);
            this.tabPage2.Controls.Add(this.ActualizarNombreInput);
            this.tabPage2.Controls.Add(this.ActualizarIdInput);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(372, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Actualizar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ActualizarBoton
            // 
            this.ActualizarBoton.Location = new System.Drawing.Point(149, 134);
            this.ActualizarBoton.Name = "ActualizarBoton";
            this.ActualizarBoton.Size = new System.Drawing.Size(75, 23);
            this.ActualizarBoton.TabIndex = 6;
            this.ActualizarBoton.Text = "Actualizar";
            this.ActualizarBoton.UseVisualStyleBackColor = true;
            this.ActualizarBoton.Click += new System.EventHandler(this.ActualizarBoton_Click);
            // 
            // ActualizarDescripcionInput
            // 
            this.ActualizarDescripcionInput.Location = new System.Drawing.Point(149, 71);
            this.ActualizarDescripcionInput.Name = "ActualizarDescripcionInput";
            this.ActualizarDescripcionInput.Size = new System.Drawing.Size(100, 20);
            this.ActualizarDescripcionInput.TabIndex = 5;
            // 
            // ActualizarNombreInput
            // 
            this.ActualizarNombreInput.Location = new System.Drawing.Point(148, 44);
            this.ActualizarNombreInput.Name = "ActualizarNombreInput";
            this.ActualizarNombreInput.Size = new System.Drawing.Size(100, 20);
            this.ActualizarNombreInput.TabIndex = 4;
            // 
            // ActualizarIdInput
            // 
            this.ActualizarIdInput.Location = new System.Drawing.Point(148, 17);
            this.ActualizarIdInput.Name = "ActualizarIdInput";
            this.ActualizarIdInput.Size = new System.Drawing.Size(100, 20);
            this.ActualizarIdInput.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nueva Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nuevo Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.EliminarIdInput);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.EliminarBoton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(372, 354);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // EliminarIdInput
            // 
            this.EliminarIdInput.Location = new System.Drawing.Point(126, 55);
            this.EliminarIdInput.Name = "EliminarIdInput";
            this.EliminarIdInput.Size = new System.Drawing.Size(100, 20);
            this.EliminarIdInput.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "ID";
            // 
            // EliminarBoton
            // 
            this.EliminarBoton.Location = new System.Drawing.Point(126, 106);
            this.EliminarBoton.Name = "EliminarBoton";
            this.EliminarBoton.Size = new System.Drawing.Size(75, 23);
            this.EliminarBoton.TabIndex = 0;
            this.EliminarBoton.Text = "Eliminar";
            this.EliminarBoton.UseVisualStyleBackColor = true;
            this.EliminarBoton.Click += new System.EventHandler(this.EliminarBoton_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ConsultarGrid);
            this.tabPage4.Controls.Add(this.ConsultarBoton);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label777);
            this.tabPage4.Controls.Add(this.ConsultarDescripcionInput);
            this.tabPage4.Controls.Add(this.ConsultarNombreInput);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(372, 354);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Consultar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ConsultarGrid
            // 
            this.ConsultarGrid.AllowUserToAddRows = false;
            this.ConsultarGrid.AllowUserToDeleteRows = false;
            this.ConsultarGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultarGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Descripcion});
            this.ConsultarGrid.Location = new System.Drawing.Point(-4, 158);
            this.ConsultarGrid.Name = "ConsultarGrid";
            this.ConsultarGrid.ReadOnly = true;
            this.ConsultarGrid.Size = new System.Drawing.Size(373, 189);
            this.ConsultarGrid.TabIndex = 5;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // ConsultarBoton
            // 
            this.ConsultarBoton.Location = new System.Drawing.Point(289, 69);
            this.ConsultarBoton.Name = "ConsultarBoton";
            this.ConsultarBoton.Size = new System.Drawing.Size(75, 23);
            this.ConsultarBoton.TabIndex = 4;
            this.ConsultarBoton.Text = "Consultar";
            this.ConsultarBoton.UseVisualStyleBackColor = true;
            this.ConsultarBoton.Click += new System.EventHandler(this.ConsultarBoton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Descripcion";
            // 
            // label777
            // 
            this.label777.AutoSize = true;
            this.label777.Location = new System.Drawing.Point(103, 37);
            this.label777.Name = "label777";
            this.label777.Size = new System.Drawing.Size(44, 13);
            this.label777.TabIndex = 2;
            this.label777.Text = "Nombre";
            // 
            // ConsultarDescripcionInput
            // 
            this.ConsultarDescripcionInput.Location = new System.Drawing.Point(166, 72);
            this.ConsultarDescripcionInput.Name = "ConsultarDescripcionInput";
            this.ConsultarDescripcionInput.Size = new System.Drawing.Size(100, 20);
            this.ConsultarDescripcionInput.TabIndex = 1;
            // 
            // ConsultarNombreInput
            // 
            this.ConsultarNombreInput.Location = new System.Drawing.Point(166, 31);
            this.ConsultarNombreInput.Name = "ConsultarNombreInput";
            this.ConsultarNombreInput.Size = new System.Drawing.Size(100, 20);
            this.ConsultarNombreInput.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Metodo";
            // 
            // ComboMetodo
            // 
            this.ComboMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboMetodo.FormattingEnabled = true;
            this.ComboMetodo.Items.AddRange(new object[] {
            "Stored Procedure",
            "Web Service"});
            this.ComboMetodo.Location = new System.Drawing.Point(107, 29);
            this.ComboMetodo.Name = "ComboMetodo";
            this.ComboMetodo.Size = new System.Drawing.Size(121, 21);
            this.ComboMetodo.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 450);
            this.Controls.Add(this.ComboMetodo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AgregarTab);
            this.Name = "Form1";
            this.Text = "Examen";
            this.AgregarTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultarGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AgregarNombreInput;
        private System.Windows.Forms.TextBox AgregarDescripcionInput;
        private System.Windows.Forms.Button AgregarBoton;
        private System.Windows.Forms.TabControl AgregarTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ActualizarBoton;
        private System.Windows.Forms.TextBox ActualizarDescripcionInput;
        private System.Windows.Forms.TextBox ActualizarNombreInput;
        private System.Windows.Forms.TextBox ActualizarIdInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button EliminarBoton;
        private System.Windows.Forms.TextBox EliminarIdInput;
        private System.Windows.Forms.DataGridView ConsultarGrid;
        private System.Windows.Forms.Button ConsultarBoton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label777;
        private System.Windows.Forms.TextBox ConsultarDescripcionInput;
        private System.Windows.Forms.TextBox ConsultarNombreInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ComboMetodo;
    }
}

