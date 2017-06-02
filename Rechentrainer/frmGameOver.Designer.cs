namespace M404_Rechentrainer_Leuenberger_Adrian
{
    partial class frmGameOver
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
            this.btnzurueck = new System.Windows.Forms.Button();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnzurueck
            // 
            this.btnzurueck.Location = new System.Drawing.Point(170, 147);
            this.btnzurueck.Name = "btnzurueck";
            this.btnzurueck.Size = new System.Drawing.Size(75, 23);
            this.btnzurueck.TabIndex = 2;
            this.btnzurueck.Text = "zurück";
            this.btnzurueck.UseVisualStyleBackColor = true;
            this.btnzurueck.Click += new System.EventHandler(this.btnzurueck_Click);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(13, 62);
            this.lblGameOver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(0, 20);
            this.lblGameOver.TabIndex = 3;
            // 
            // frmGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 203);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.btnzurueck);
            this.Name = "frmGameOver";
            this.Text = "frmGameOver";
            this.Load += new System.EventHandler(this.frmGameOver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnzurueck;
        private System.Windows.Forms.Label lblGameOver;
    }
}