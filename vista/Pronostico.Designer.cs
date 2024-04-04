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
            this.equipo2 = new System.Windows.Forms.Panel();
            this.rd2Empate = new System.Windows.Forms.RadioButton();
            this.rd2Visitante = new System.Windows.Forms.RadioButton();
            this.rd2Local = new System.Windows.Forms.RadioButton();
            this.dtFecha = new System.Windows.Forms.DataGridView();
            this.btnHacerPronostico = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.equipo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtVisitante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLocal)).BeginInit();
            this.equipo2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha)).BeginInit();
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
            this.equipo1.Location = new System.Drawing.Point(173, 50);
            this.equipo1.Name = "equipo1";
            this.equipo1.Size = new System.Drawing.Size(438, 33);
            this.equipo1.TabIndex = 1;
            // 
            // rdEmpate
            // 
            this.rdEmpate.AutoSize = true;
            this.rdEmpate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdEmpate.Location = new System.Drawing.Point(168, 3);
            this.rdEmpate.Name = "rdEmpate";
            this.rdEmpate.Size = new System.Drawing.Size(93, 28);
            this.rdEmpate.TabIndex = 3;
            this.rdEmpate.TabStop = true;
            this.rdEmpate.Text = "Empate";
            this.rdEmpate.UseVisualStyleBackColor = true;
            // 
            // rdVisitante
            // 
            this.rdVisitante.AutoSize = true;
            this.rdVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdVisitante.Location = new System.Drawing.Point(337, 3);
            this.rdVisitante.Name = "rdVisitante";
            this.rdVisitante.Size = new System.Drawing.Size(98, 28);
            this.rdVisitante.TabIndex = 2;
            this.rdVisitante.TabStop = true;
            this.rdVisitante.Text = "Visitante";
            this.rdVisitante.UseVisualStyleBackColor = true;
            // 
            // rdLocal
            // 
            this.rdLocal.AutoSize = true;
            this.rdLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLocal.Location = new System.Drawing.Point(3, 3);
            this.rdLocal.Name = "rdLocal";
            this.rdLocal.Size = new System.Drawing.Size(73, 28);
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
            this.dtVisitante.Location = new System.Drawing.Point(620, 50);
            this.dtVisitante.Name = "dtVisitante";
            this.dtVisitante.Size = new System.Drawing.Size(166, 407);
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
            // equipo2
            // 
            this.equipo2.Controls.Add(this.rd2Empate);
            this.equipo2.Controls.Add(this.rd2Visitante);
            this.equipo2.Controls.Add(this.rd2Local);
            this.equipo2.Location = new System.Drawing.Point(173, 87);
            this.equipo2.Name = "equipo2";
            this.equipo2.Size = new System.Drawing.Size(438, 33);
            this.equipo2.TabIndex = 4;
            // 
            // rd2Empate
            // 
            this.rd2Empate.AutoSize = true;
            this.rd2Empate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd2Empate.Location = new System.Drawing.Point(168, 3);
            this.rd2Empate.Name = "rd2Empate";
            this.rd2Empate.Size = new System.Drawing.Size(93, 28);
            this.rd2Empate.TabIndex = 3;
            this.rd2Empate.TabStop = true;
            this.rd2Empate.Text = "Empate";
            this.rd2Empate.UseVisualStyleBackColor = true;
            // 
            // rd2Visitante
            // 
            this.rd2Visitante.AutoSize = true;
            this.rd2Visitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd2Visitante.Location = new System.Drawing.Point(337, 3);
            this.rd2Visitante.Name = "rd2Visitante";
            this.rd2Visitante.Size = new System.Drawing.Size(98, 28);
            this.rd2Visitante.TabIndex = 2;
            this.rd2Visitante.TabStop = true;
            this.rd2Visitante.Text = "Visitante";
            this.rd2Visitante.UseVisualStyleBackColor = true;
            // 
            // rd2Local
            // 
            this.rd2Local.AutoSize = true;
            this.rd2Local.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd2Local.Location = new System.Drawing.Point(3, 3);
            this.rd2Local.Name = "rd2Local";
            this.rd2Local.Size = new System.Drawing.Size(73, 28);
            this.rd2Local.TabIndex = 0;
            this.rd2Local.TabStop = true;
            this.rd2Local.Text = "Local";
            this.rd2Local.UseVisualStyleBackColor = true;
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
            // Pronostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 520);
            this.Controls.Add(this.btnHacerPronostico);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.equipo2);
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
            this.equipo2.ResumeLayout(false);
            this.equipo2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtVisitante;
        private System.Windows.Forms.DataGridView dtLocal;
        public System.Windows.Forms.RadioButton rdVisitante;
        public System.Windows.Forms.RadioButton rdLocal;
        public System.Windows.Forms.RadioButton rdEmpate;
        public System.Windows.Forms.RadioButton rd2Empate;
        public System.Windows.Forms.RadioButton rd2Visitante;
        public System.Windows.Forms.RadioButton rd2Local;
        public System.Windows.Forms.Panel equipo2;
        public System.Windows.Forms.Panel equipo1;
        private System.Windows.Forms.DataGridView dtFecha;
        public System.Windows.Forms.Button btnHacerPronostico;
    }
}