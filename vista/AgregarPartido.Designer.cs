namespace prototipo_Quiniela.vista
{
    partial class AgregarPartido
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
            this.Local = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVisitante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarPartido = new System.Windows.Forms.Button();
            this.fechaPartido = new System.Windows.Forms.DateTimePicker();
            this.dtPartidos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtPartidos)).BeginInit();
            this.SuspendLayout();
            // 
            // Local
            // 
            this.Local.AutoSize = true;
            this.Local.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Local.Location = new System.Drawing.Point(26, 59);
            this.Local.Name = "Local";
            this.Local.Size = new System.Drawing.Size(55, 24);
            this.Local.TabIndex = 0;
            this.Local.Text = "Local";
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(91, 63);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(141, 20);
            this.txtLocal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Debe agregar el id de equipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Debe agregar el id de equipo";
            // 
            // txtVisitante
            // 
            this.txtVisitante.Location = new System.Drawing.Point(344, 64);
            this.txtVisitante.Name = "txtVisitante";
            this.txtVisitante.Size = new System.Drawing.Size(141, 20);
            this.txtVisitante.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Visitante";
            // 
            // btnAgregarPartido
            // 
            this.btnAgregarPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPartido.Location = new System.Drawing.Point(206, 147);
            this.btnAgregarPartido.Name = "btnAgregarPartido";
            this.btnAgregarPartido.Size = new System.Drawing.Size(141, 32);
            this.btnAgregarPartido.TabIndex = 6;
            this.btnAgregarPartido.Text = "Agregar Partido";
            this.btnAgregarPartido.UseVisualStyleBackColor = true;
            // 
            // fechaPartido
            // 
            this.fechaPartido.Location = new System.Drawing.Point(173, 108);
            this.fechaPartido.Name = "fechaPartido";
            this.fechaPartido.Size = new System.Drawing.Size(200, 20);
            this.fechaPartido.TabIndex = 7;
            // 
            // dtPartidos
            // 
            this.dtPartidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPartidos.Location = new System.Drawing.Point(12, 185);
            this.dtPartidos.Name = "dtPartidos";
            this.dtPartidos.Size = new System.Drawing.Size(509, 204);
            this.dtPartidos.TabIndex = 8;
            // 
            // AgregarPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 401);
            this.Controls.Add(this.dtPartidos);
            this.Controls.Add(this.fechaPartido);
            this.Controls.Add(this.btnAgregarPartido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVisitante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.Local);
            this.Name = "AgregarPartido";
            this.Text = "Partidos";
            ((System.ComponentModel.ISupportInitialize)(this.dtPartidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Local;
        public System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtVisitante;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnAgregarPartido;
        public System.Windows.Forms.DateTimePicker fechaPartido;
        public System.Windows.Forms.DataGridView dtPartidos;
    }
}