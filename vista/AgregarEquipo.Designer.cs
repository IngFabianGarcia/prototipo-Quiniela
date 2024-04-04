namespace prototipo_Quiniela.vista
{
    partial class AgregarEquipo
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
            this.txtNombreEquipo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarEquipo = new System.Windows.Forms.Button();
            this.dtEquipos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.Location = new System.Drawing.Point(133, 21);
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(157, 20);
            this.txtNombreEquipo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de equipo";
            // 
            // btnAgregarEquipo
            // 
            this.btnAgregarEquipo.Location = new System.Drawing.Point(133, 57);
            this.btnAgregarEquipo.Name = "btnAgregarEquipo";
            this.btnAgregarEquipo.Size = new System.Drawing.Size(157, 23);
            this.btnAgregarEquipo.TabIndex = 2;
            this.btnAgregarEquipo.Text = "Agregar Equipo";
            this.btnAgregarEquipo.UseVisualStyleBackColor = true;
            // 
            // dtEquipos
            // 
            this.dtEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtEquipos.Location = new System.Drawing.Point(12, 113);
            this.dtEquipos.Name = "dtEquipos";
            this.dtEquipos.Size = new System.Drawing.Size(386, 323);
            this.dtEquipos.TabIndex = 3;
            // 
            // AgregarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 448);
            this.Controls.Add(this.dtEquipos);
            this.Controls.Add(this.btnAgregarEquipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreEquipo);
            this.Name = "AgregarEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarEquipo";
            ((System.ComponentModel.ISupportInitialize)(this.dtEquipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtNombreEquipo;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnAgregarEquipo;
        public System.Windows.Forms.DataGridView dtEquipos;
    }
}