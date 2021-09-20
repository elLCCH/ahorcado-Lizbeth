
namespace ahorcado_Lizbeth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pCabeza = new System.Windows.Forms.PictureBox();
            this.pBrazos = new System.Windows.Forms.PictureBox();
            this.pEstomago = new System.Windows.Forms.PictureBox();
            this.pPiernas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pPalo2 = new System.Windows.Forms.PictureBox();
            this.pPalo1 = new System.Windows.Forms.PictureBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.txtLetras = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pCabeza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBrazos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEstomago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPiernas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPalo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPalo1)).BeginInit();
            this.SuspendLayout();
            // 
            // pCabeza
            // 
            this.pCabeza.Image = ((System.Drawing.Image)(resources.GetObject("pCabeza.Image")));
            this.pCabeza.Location = new System.Drawing.Point(224, 124);
            this.pCabeza.Name = "pCabeza";
            this.pCabeza.Size = new System.Drawing.Size(90, 78);
            this.pCabeza.TabIndex = 0;
            this.pCabeza.TabStop = false;
            this.pCabeza.Visible = false;
            // 
            // pBrazos
            // 
            this.pBrazos.Image = ((System.Drawing.Image)(resources.GetObject("pBrazos.Image")));
            this.pBrazos.Location = new System.Drawing.Point(221, 198);
            this.pBrazos.Name = "pBrazos";
            this.pBrazos.Size = new System.Drawing.Size(111, 19);
            this.pBrazos.TabIndex = 1;
            this.pBrazos.TabStop = false;
            this.pBrazos.Visible = false;
            // 
            // pEstomago
            // 
            this.pEstomago.Image = ((System.Drawing.Image)(resources.GetObject("pEstomago.Image")));
            this.pEstomago.Location = new System.Drawing.Point(254, 217);
            this.pEstomago.Name = "pEstomago";
            this.pEstomago.Size = new System.Drawing.Size(42, 31);
            this.pEstomago.TabIndex = 2;
            this.pEstomago.TabStop = false;
            this.pEstomago.Visible = false;
            // 
            // pPiernas
            // 
            this.pPiernas.Image = ((System.Drawing.Image)(resources.GetObject("pPiernas.Image")));
            this.pPiernas.Location = new System.Drawing.Point(248, 241);
            this.pPiernas.Name = "pPiernas";
            this.pPiernas.Size = new System.Drawing.Size(48, 67);
            this.pPiernas.TabIndex = 3;
            this.pPiernas.TabStop = false;
            this.pPiernas.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(344, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 86);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // pPalo2
            // 
            this.pPalo2.Image = ((System.Drawing.Image)(resources.GetObject("pPalo2.Image")));
            this.pPalo2.Location = new System.Drawing.Point(116, 52);
            this.pPalo2.Name = "pPalo2";
            this.pPalo2.Size = new System.Drawing.Size(216, 79);
            this.pPalo2.TabIndex = 6;
            this.pPalo2.TabStop = false;
            this.pPalo2.Visible = false;
            // 
            // pPalo1
            // 
            this.pPalo1.BackColor = System.Drawing.Color.Transparent;
            this.pPalo1.Image = ((System.Drawing.Image)(resources.GetObject("pPalo1.Image")));
            this.pPalo1.Location = new System.Drawing.Point(64, 52);
            this.pPalo1.Name = "pPalo1";
            this.pPalo1.Size = new System.Drawing.Size(90, 315);
            this.pPalo1.TabIndex = 7;
            this.pPalo1.TabStop = false;
            this.pPalo1.Visible = false;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(442, 12);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(157, 23);
            this.btnConsulta.TabIndex = 9;
            this.btnConsulta.Text = "Ir Siguiente Pregunta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // txtLetras
            // 
            this.txtLetras.Location = new System.Drawing.Point(224, 419);
            this.txtLetras.Name = "txtLetras";
            this.txtLetras.Size = new System.Drawing.Size(100, 23);
            this.txtLetras.TabIndex = 10;
            this.txtLetras.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLetras_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 485);
            this.Controls.Add(this.txtLetras);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.pPiernas);
            this.Controls.Add(this.pEstomago);
            this.Controls.Add(this.pBrazos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pCabeza);
            this.Controls.Add(this.pPalo2);
            this.Controls.Add(this.pPalo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pCabeza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBrazos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEstomago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPiernas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPalo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPalo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pCabeza;
        private System.Windows.Forms.PictureBox pBrazos;
        private System.Windows.Forms.PictureBox pEstomago;
        private System.Windows.Forms.PictureBox pPiernas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pPalo2;
        private System.Windows.Forms.PictureBox pPalo1;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.TextBox txtLetras;
    }
}

