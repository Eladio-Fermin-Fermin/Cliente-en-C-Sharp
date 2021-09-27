
namespace WindowsFormsApp3
{
    partial class Consulta
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
            this.Consultar = new System.Windows.Forms.Button();
            this.NuC = new System.Windows.Forms.Label();
            this.lDeC = new System.Windows.Forms.Label();
            this.APC = new System.Windows.Forms.Label();
            this.NC = new System.Windows.Forms.Label();
            this.DescripcionC = new System.Windows.Forms.TextBox();
            this.ApellidoC = new System.Windows.Forms.TextBox();
            this.NumeroC = new System.Windows.Forms.TextBox();
            this.NombreC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Consultar
            // 
            this.Consultar.Location = new System.Drawing.Point(97, 216);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(75, 23);
            this.Consultar.TabIndex = 17;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // NuC
            // 
            this.NuC.AutoSize = true;
            this.NuC.Location = new System.Drawing.Point(109, 114);
            this.NuC.Name = "NuC";
            this.NuC.Size = new System.Drawing.Size(44, 13);
            this.NuC.TabIndex = 16;
            this.NuC.Text = "Numero";
            // 
            // lDeC
            // 
            this.lDeC.AutoSize = true;
            this.lDeC.Location = new System.Drawing.Point(94, 160);
            this.lDeC.Name = "lDeC";
            this.lDeC.Size = new System.Drawing.Size(63, 13);
            this.lDeC.TabIndex = 15;
            this.lDeC.Text = "Descripcion";
            // 
            // APC
            // 
            this.APC.AutoSize = true;
            this.APC.Location = new System.Drawing.Point(109, 66);
            this.APC.Name = "APC";
            this.APC.Size = new System.Drawing.Size(44, 13);
            this.APC.TabIndex = 14;
            this.APC.Text = "Apellido";
            // 
            // NC
            // 
            this.NC.AutoSize = true;
            this.NC.Location = new System.Drawing.Point(109, 24);
            this.NC.Name = "NC";
            this.NC.Size = new System.Drawing.Size(44, 13);
            this.NC.TabIndex = 13;
            this.NC.Text = "Nombre";
            // 
            // DescripcionC
            // 
            this.DescripcionC.Location = new System.Drawing.Point(61, 176);
            this.DescripcionC.Name = "DescripcionC";
            this.DescripcionC.Size = new System.Drawing.Size(162, 20);
            this.DescripcionC.TabIndex = 12;
            // 
            // ApellidoC
            // 
            this.ApellidoC.Location = new System.Drawing.Point(61, 82);
            this.ApellidoC.Name = "ApellidoC";
            this.ApellidoC.Size = new System.Drawing.Size(162, 20);
            this.ApellidoC.TabIndex = 11;
            // 
            // NumeroC
            // 
            this.NumeroC.Location = new System.Drawing.Point(61, 130);
            this.NumeroC.Name = "NumeroC";
            this.NumeroC.Size = new System.Drawing.Size(162, 20);
            this.NumeroC.TabIndex = 10;
            // 
            // NombreC
            // 
            this.NombreC.Location = new System.Drawing.Point(61, 40);
            this.NombreC.Name = "NombreC";
            this.NombreC.Size = new System.Drawing.Size(162, 20);
            this.NombreC.TabIndex = 9;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 263);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.NuC);
            this.Controls.Add(this.lDeC);
            this.Controls.Add(this.APC);
            this.Controls.Add(this.NC);
            this.Controls.Add(this.DescripcionC);
            this.Controls.Add(this.ApellidoC);
            this.Controls.Add(this.NumeroC);
            this.Controls.Add(this.NombreC);
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Label NuC;
        private System.Windows.Forms.Label lDeC;
        private System.Windows.Forms.Label APC;
        private System.Windows.Forms.Label NC;
        private System.Windows.Forms.TextBox DescripcionC;
        private System.Windows.Forms.TextBox ApellidoC;
        private System.Windows.Forms.TextBox NumeroC;
        private System.Windows.Forms.TextBox NombreC;
    }
}