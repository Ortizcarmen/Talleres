namespace Talleres
{
    partial class Form1
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
            this.dataGridViewEstudiantes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTalleres = new System.Windows.Forms.DataGridView();
            this.dataGridViewInscripciones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxAlumnos = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonInscripcion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTalleres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInscripciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEstudiantes
            // 
            this.dataGridViewEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstudiantes.Location = new System.Drawing.Point(12, 72);
            this.dataGridViewEstudiantes.Name = "dataGridViewEstudiantes";
            this.dataGridViewEstudiantes.RowHeadersWidth = 51;
            this.dataGridViewEstudiantes.RowTemplate.Height = 24;
            this.dataGridViewEstudiantes.Size = new System.Drawing.Size(347, 239);
            this.dataGridViewEstudiantes.TabIndex = 0;
            // 
            // dataGridViewTalleres
            // 
            this.dataGridViewTalleres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTalleres.Location = new System.Drawing.Point(418, 72);
            this.dataGridViewTalleres.Name = "dataGridViewTalleres";
            this.dataGridViewTalleres.RowHeadersWidth = 51;
            this.dataGridViewTalleres.RowTemplate.Height = 24;
            this.dataGridViewTalleres.Size = new System.Drawing.Size(334, 239);
            this.dataGridViewTalleres.TabIndex = 1;
            // 
            // dataGridViewInscripciones
            // 
            this.dataGridViewInscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInscripciones.Location = new System.Drawing.Point(815, 72);
            this.dataGridViewInscripciones.Name = "dataGridViewInscripciones";
            this.dataGridViewInscripciones.RowHeadersWidth = 51;
            this.dataGridViewInscripciones.RowTemplate.Height = 24;
            this.dataGridViewInscripciones.Size = new System.Drawing.Size(327, 239);
            this.dataGridViewInscripciones.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datos estudiantes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Informacion Talleres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(812, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Inscripciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seleccionar alumno:";
            // 
            // comboBoxAlumnos
            // 
            this.comboBoxAlumnos.FormattingEnabled = true;
            this.comboBoxAlumnos.Location = new System.Drawing.Point(106, 411);
            this.comboBoxAlumnos.Name = "comboBoxAlumnos";
            this.comboBoxAlumnos.Size = new System.Drawing.Size(121, 24);
            this.comboBoxAlumnos.TabIndex = 7;
            this.comboBoxAlumnos.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlumnos_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cargar Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(996, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 48);
            this.button2.TabIndex = 9;
            this.button2.Text = "Ordenar Alfabeticamente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonInscripcion
            // 
            this.buttonInscripcion.Location = new System.Drawing.Point(815, 346);
            this.buttonInscripcion.Name = "buttonInscripcion";
            this.buttonInscripcion.Size = new System.Drawing.Size(126, 40);
            this.buttonInscripcion.TabIndex = 10;
            this.buttonInscripcion.Text = "Inscripcion";
            this.buttonInscripcion.UseVisualStyleBackColor = true;
            this.buttonInscripcion.Click += new System.EventHandler(this.buttonInscripcion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 602);
            this.Controls.Add(this.buttonInscripcion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxAlumnos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewInscripciones);
            this.Controls.Add(this.dataGridViewTalleres);
            this.Controls.Add(this.dataGridViewEstudiantes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTalleres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInscripciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEstudiantes;
        private System.Windows.Forms.DataGridView dataGridViewTalleres;
        private System.Windows.Forms.DataGridView dataGridViewInscripciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxAlumnos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonInscripcion;
    }
}

