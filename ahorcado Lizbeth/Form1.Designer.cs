
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
            ((System.ComponentModel.ISupportInitialize)(this.pCabeza)).BeginInit();
            this.SuspendLayout();
            // 
            // pCabeza
            // 
            this.pCabeza.Image = ((System.Drawing.Image)(resources.GetObject("pCabeza.Image")));
            this.pCabeza.Location = new System.Drawing.Point(127, 41);
            this.pCabeza.Name = "pCabeza";
            this.pCabeza.Size = new System.Drawing.Size(90, 79);
            this.pCabeza.TabIndex = 0;
            this.pCabeza.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 411);
            this.Controls.Add(this.pCabeza);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pCabeza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pCabeza;
    }
}

