namespace prototipo_Quiniela.vista
{
    partial class Pronostico
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.equipo1 = new System.Windows.Forms.Panel();
            this.rdEmpate = new System.Windows.Forms.RadioButton();
            this.rdVisitante = new System.Windows.Forms.RadioButton();
            this.rdLocal = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dtVisitante = new System.Windows.Forms.DataGridView();
            this.dtLocal = new System.Windows.Forms.DataGridView();
            this.dtFecha = new System.Windows.Forms.DataGridView();
            this.btnHacerPronostico = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.equipo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtVisitante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 45);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jornada #1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(683, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Visitante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Local";
            // 
            // equipo1
            // 
            this.equipo1.Controls.Add(this.rdEmpate);
            this.equipo1.Controls.Add(this.rdVisitante);
            this.equipo1.Controls.Add(this.rdLocal);
            this.equipo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipo1.Location = new System.Drawing.Point(173, 71);
            this.equipo1.Name = "equipo1";
            this.equipo1.Size = new System.Drawing.Size(438, 21);
            this.equipo1.TabIndex = 1;
            // 
            // rdEmpate
            // 
            this.rdEmpate.AutoSize = true;
            this.rdEmpate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdEmpate.Location = new System.Drawing.Point(173, 0);
            this.rdEmpate.Name = "rdEmpate";
            this.rdEmpate.Size = new System.Drawing.Size(72, 20);
            this.rdEmpate.TabIndex = 3;
            this.rdEmpate.TabStop = true;
            this.rdEmpate.Text = "Empate";
            this.rdEmpate.UseVisualStyleBackColor = true;
            // 
            // rdVisitante
            // 
            this.rdVisitante.AutoSize = true;
            this.rdVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdVisitante.Location = new System.Drawing.Point(362, 0);
            this.rdVisitante.Name = "rdVisitante";
            this.rdVisitante.Size = new System.Drawing.Size(76, 20);
            this.rdVisitante.TabIndex = 2;
            this.rdVisitante.TabStop = true;
            this.rdVisitante.Text = "Visitante";
            this.rdVisitante.UseVisualStyleBackColor = true;
            // 
            // rdLocal
            // 
            this.rdLocal.AutoSize = true;
            this.rdLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLocal.Location = new System.Drawing.Point(3, 0);
            this.rdLocal.Name = "rdLocal";
            this.rdLocal.Size = new System.Drawing.Size(58, 20);
            this.rdLocal.TabIndex = 0;
            this.rdLocal.TabStop = true;
            this.rdLocal.Text = "Local";
            this.rdLocal.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(845, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha";
            // 
            // dtVisitante
            // 
            this.dtVisitante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtVisitante.Location = new System.Drawing.Point(617, 50);
            this.dtVisitante.Name = "dtVisitante";
            this.dtVisitante.Size = new System.Drawing.Size(178, 407);
            this.dtVisitante.TabIndex = 4;
            // 
            // dtLocal
            // 
            this.dtLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLocal.Location = new System.Drawing.Point(1, 50);
            this.dtLocal.Name = "dtLocal";
            this.dtLocal.Size = new System.Drawing.Size(166, 407);
            this.dtLocal.TabIndex = 5;
            // 
            // dtFecha
            // 
            this.dtFecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtFecha.Location = new System.Drawing.Point(801, 50);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(166, 407);
            this.dtFecha.TabIndex = 3;
            // 
            // btnHacerPronostico
            // 
            this.btnHacerPronostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHacerPronostico.Location = new System.Drawing.Point(801, 475);
            this.btnHacerPronostico.Name = "btnHacerPronostico";
            this.btnHacerPronostico.Size = new System.Drawing.Size(176, 45);
            this.btnHacerPronostico.TabIndex = 6;
            this.btnHacerPronostico.Text = "Hacer Pronostico";
            this.btnHacerPronostico.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(173, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 21);
            this.panel2.TabIndex = 4;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(173, 0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 20);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Empate";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(362, 0);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(76, 20);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Visitante";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(3, 0);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(58, 20);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Local";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButton4);
            this.panel3.Controls.Add(this.radioButton5);
            this.panel3.Controls.Add(this.radioButton6);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(173, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 21);
            this.panel3.TabIndex = 5;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(173, 0);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(72, 20);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Empate";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(362, 0);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(76, 20);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Visitante";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.Location = new System.Drawing.Point(3, 0);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(58, 20);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Local";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // Pronostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 520);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnHacerPronostico);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtLocal);
            this.Controls.Add(this.dtVisitante);
            this.Controls.Add(this.equipo1);
            this.Controls.Add(this.panel1);
            this.Name = "Pronostico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pronostico";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.equipo1.ResumeLayout(false);
            this.equipo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtVisitante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.RadioButton rdVisitante;
        public System.Windows.Forms.RadioButton rdLocal;
        public System.Windows.Forms.RadioButton rdEmpate;
        public System.Windows.Forms.Panel equipo1;
        public System.Windows.Forms.Button btnHacerPronostico;
        public System.Windows.Forms.DataGridView dtLocal;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.RadioButton radioButton3;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.RadioButton radioButton4;
        public System.Windows.Forms.RadioButton radioButton5;
        public System.Windows.Forms.RadioButton radioButton6;
        public System.Windows.Forms.DataGridView dtVisitante;
        public System.Windows.Forms.DataGridView dtFecha;
    }
}