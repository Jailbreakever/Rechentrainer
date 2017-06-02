namespace M404_Rechentrainer_Leuenberger_Adrian
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAufgabe = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNeuesTraining = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb212 = new System.Windows.Forms.RadioButton();
            this.rdb219 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbSchwer = new System.Windows.Forms.RadioButton();
            this.rdbGemischt = new System.Windows.Forms.RadioButton();
            this.rdbLeicht = new System.Windows.Forms.RadioButton();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.txtErgebnis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tmrBasiszeit = new System.Windows.Forms.Timer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.lblBasiszeit = new System.Windows.Forms.Label();
            this.lblBonuszeit = new System.Windows.Forms.Label();
            this.lblRechnung = new System.Windows.Forms.Label();
            this.txtPunkte = new System.Windows.Forms.TextBox();
            this.tmrBonuszeit = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verbessere deine Kopfrechnen-Fähigkeiten";
            // 
            // lblAufgabe
            // 
            this.lblAufgabe.AutoSize = true;
            this.lblAufgabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAufgabe.Location = new System.Drawing.Point(168, 101);
            this.lblAufgabe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAufgabe.Name = "lblAufgabe";
            this.lblAufgabe.Size = new System.Drawing.Size(92, 25);
            this.lblAufgabe.TabIndex = 1;
            this.lblAufgabe.Text = "Aufgabe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dein Ergebnis lautet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Punkte:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 367);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "verbleibende Zeit:";
            // 
            // btnNeuesTraining
            // 
            this.btnNeuesTraining.Location = new System.Drawing.Point(73, 476);
            this.btnNeuesTraining.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNeuesTraining.Name = "btnNeuesTraining";
            this.btnNeuesTraining.Size = new System.Drawing.Size(201, 28);
            this.btnNeuesTraining.TabIndex = 5;
            this.btnNeuesTraining.Text = "neues Training";
            this.btnNeuesTraining.UseVisualStyleBackColor = true;
            this.btnNeuesTraining.Click += new System.EventHandler(this.btnNeuesTraining_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb212);
            this.groupBox1.Controls.Add(this.rdb219);
            this.groupBox1.Location = new System.Drawing.Point(703, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(127, 123);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zahlenreihen";
            // 
            // rdb212
            // 
            this.rdb212.AutoSize = true;
            this.rdb212.Location = new System.Drawing.Point(8, 34);
            this.rdb212.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdb212.Name = "rdb212";
            this.rdb212.Size = new System.Drawing.Size(58, 21);
            this.rdb212.TabIndex = 9;
            this.rdb212.Text = "2-12";
            this.rdb212.UseVisualStyleBackColor = true;
            // 
            // rdb219
            // 
            this.rdb219.AutoSize = true;
            this.rdb219.Location = new System.Drawing.Point(8, 63);
            this.rdb219.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdb219.Name = "rdb219";
            this.rdb219.Size = new System.Drawing.Size(58, 21);
            this.rdb219.TabIndex = 10;
            this.rdb219.Text = "2-19";
            this.rdb219.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbSchwer);
            this.groupBox2.Controls.Add(this.rdbGemischt);
            this.groupBox2.Controls.Add(this.rdbLeicht);
            this.groupBox2.Location = new System.Drawing.Point(703, 231);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(127, 123);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Schwierigkeit";
            // 
            // rdbSchwer
            // 
            this.rdbSchwer.AutoSize = true;
            this.rdbSchwer.Location = new System.Drawing.Point(8, 80);
            this.rdbSchwer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbSchwer.Name = "rdbSchwer";
            this.rdbSchwer.Size = new System.Drawing.Size(73, 21);
            this.rdbSchwer.TabIndex = 12;
            this.rdbSchwer.Text = "schwer";
            this.rdbSchwer.UseVisualStyleBackColor = true;
            this.rdbSchwer.Click += new System.EventHandler(this.rdbSchwer_Click);
            // 
            // rdbGemischt
            // 
            this.rdbGemischt.AutoSize = true;
            this.rdbGemischt.Location = new System.Drawing.Point(8, 52);
            this.rdbGemischt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbGemischt.Name = "rdbGemischt";
            this.rdbGemischt.Size = new System.Drawing.Size(85, 21);
            this.rdbGemischt.TabIndex = 13;
            this.rdbGemischt.TabStop = true;
            this.rdbGemischt.Text = "gemischt";
            this.rdbGemischt.UseVisualStyleBackColor = true;
            this.rdbGemischt.Click += new System.EventHandler(this.rdbGemischt_Click);
            // 
            // rdbLeicht
            // 
            this.rdbLeicht.AutoSize = true;
            this.rdbLeicht.Location = new System.Drawing.Point(8, 23);
            this.rdbLeicht.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbLeicht.Name = "rdbLeicht";
            this.rdbLeicht.Size = new System.Drawing.Size(62, 21);
            this.rdbLeicht.TabIndex = 11;
            this.rdbLeicht.Text = "leicht";
            this.rdbLeicht.UseVisualStyleBackColor = true;
            this.rdbLeicht.Click += new System.EventHandler(this.rdbLeicht_Click);
            // 
            // btnBeenden
            // 
            this.btnBeenden.Location = new System.Drawing.Point(588, 476);
            this.btnBeenden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(201, 28);
            this.btnBeenden.TabIndex = 9;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // txtErgebnis
            // 
            this.txtErgebnis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErgebnis.Location = new System.Drawing.Point(327, 182);
            this.txtErgebnis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtErgebnis.Name = "txtErgebnis";
            this.txtErgebnis.Size = new System.Drawing.Size(155, 30);
            this.txtErgebnis.TabIndex = 10;
            this.txtErgebnis.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtErgebnis_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 388);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 388);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "30";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(601, 388);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "60";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(420, 338);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Bonuszeit";
            // 
            // tmrBasiszeit
            // 
            this.tmrBasiszeit.Interval = 1000;
            this.tmrBasiszeit.Tick += new System.EventHandler(this.tmrBasiszeit_Tick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(205, 407);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 17);
            this.label10.TabIndex = 15;
            // 
            // lblBasiszeit
            // 
            this.lblBasiszeit.BackColor = System.Drawing.Color.Green;
            this.lblBasiszeit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBasiszeit.Location = new System.Drawing.Point(216, 367);
            this.lblBasiszeit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBasiszeit.MinimumSize = new System.Drawing.Size(0, 20);
            this.lblBasiszeit.Name = "lblBasiszeit";
            this.lblBasiszeit.Size = new System.Drawing.Size(200, 20);
            this.lblBasiszeit.TabIndex = 16;
            this.lblBasiszeit.Text = " ";
            // 
            // lblBonuszeit
            // 
            this.lblBonuszeit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBonuszeit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBonuszeit.Location = new System.Drawing.Point(419, 367);
            this.lblBonuszeit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBonuszeit.MinimumSize = new System.Drawing.Size(0, 20);
            this.lblBonuszeit.Name = "lblBonuszeit";
            this.lblBonuszeit.Size = new System.Drawing.Size(200, 20);
            this.lblBonuszeit.TabIndex = 17;
            this.lblBonuszeit.Text = " ";
            // 
            // lblRechnung
            // 
            this.lblRechnung.AutoSize = true;
            this.lblRechnung.BackColor = System.Drawing.Color.Gray;
            this.lblRechnung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechnung.Location = new System.Drawing.Point(323, 90);
            this.lblRechnung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRechnung.MinimumSize = new System.Drawing.Size(160, 49);
            this.lblRechnung.Name = "lblRechnung";
            this.lblRechnung.Size = new System.Drawing.Size(160, 49);
            this.lblRechnung.TabIndex = 18;
            this.lblRechnung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPunkte
            // 
            this.txtPunkte.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPunkte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPunkte.Location = new System.Drawing.Point(327, 260);
            this.txtPunkte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPunkte.Name = "txtPunkte";
            this.txtPunkte.ReadOnly = true;
            this.txtPunkte.Size = new System.Drawing.Size(155, 30);
            this.txtPunkte.TabIndex = 19;
            this.txtPunkte.Text = "0";
            // 
            // tmrBonuszeit
            // 
            this.tmrBonuszeit.Interval = 1000;
            this.tmrBonuszeit.Tick += new System.EventHandler(this.tmrBonuszeit_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 530);
            this.Controls.Add(this.txtPunkte);
            this.Controls.Add(this.lblRechnung);
            this.Controls.Add(this.lblBonuszeit);
            this.Controls.Add(this.lblBasiszeit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtErgebnis);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNeuesTraining);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAufgabe);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Rechentrainer ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAufgabe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNeuesTraining;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb212;
        private System.Windows.Forms.RadioButton rdb219;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbSchwer;
        private System.Windows.Forms.RadioButton rdbGemischt;
        private System.Windows.Forms.RadioButton rdbLeicht;
        private System.Windows.Forms.Button btnBeenden;
        private System.Windows.Forms.TextBox txtErgebnis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer tmrBasiszeit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblBasiszeit;
        private System.Windows.Forms.Label lblBonuszeit;
        private System.Windows.Forms.Label lblRechnung;
        private System.Windows.Forms.TextBox txtPunkte;
        private System.Windows.Forms.Timer tmrBonuszeit;
    }
}

