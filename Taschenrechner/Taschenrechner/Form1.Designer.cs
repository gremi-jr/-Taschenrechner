namespace Taschenrechner
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
            this.button1 = new System.Windows.Forms.Button();
            this.tBx_Zahl1 = new System.Windows.Forms.TextBox();
            this.tBx_Zahl2 = new System.Windows.Forms.TextBox();
            this.tBx_Ergebnis = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bt_1 = new System.Windows.Forms.Button();
            this.bt_2 = new System.Windows.Forms.Button();
            this.bt_3 = new System.Windows.Forms.Button();
            this.bt_4 = new System.Windows.Forms.Button();
            this.bt_5 = new System.Windows.Forms.Button();
            this.bt_6 = new System.Windows.Forms.Button();
            this.bt_7 = new System.Windows.Forms.Button();
            this.bt_8 = new System.Windows.Forms.Button();
            this.bt_9 = new System.Windows.Forms.Button();
            this.bt_0 = new System.Windows.Forms.Button();
            this.bt_komma = new System.Windows.Forms.Button();
            this.bt_C = new System.Windows.Forms.Button();
            this.bt_CE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tBx_Zahl1
            // 
            this.tBx_Zahl1.Location = new System.Drawing.Point(12, 12);
            this.tBx_Zahl1.Name = "tBx_Zahl1";
            this.tBx_Zahl1.Size = new System.Drawing.Size(100, 20);
            this.tBx_Zahl1.TabIndex = 1;
            this.tBx_Zahl1.Text = "Zahl 1";
            this.tBx_Zahl1.Enter += new System.EventHandler(this.tBx_Zahl1_Enter);
            this.tBx_Zahl1.Leave += new System.EventHandler(this.tBx_Zahl1_Leave);
            // 
            // tBx_Zahl2
            // 
            this.tBx_Zahl2.Location = new System.Drawing.Point(118, 12);
            this.tBx_Zahl2.Name = "tBx_Zahl2";
            this.tBx_Zahl2.Size = new System.Drawing.Size(100, 20);
            this.tBx_Zahl2.TabIndex = 2;
            this.tBx_Zahl2.Text = "Zahl 2";
            this.tBx_Zahl2.Enter += new System.EventHandler(this.tBx_Zahl2_Enter);
            this.tBx_Zahl2.Leave += new System.EventHandler(this.tBx_Zahl2_Leave);
            // 
            // tBx_Ergebnis
            // 
            this.tBx_Ergebnis.Location = new System.Drawing.Point(12, 196);
            this.tBx_Ergebnis.Name = "tBx_Ergebnis";
            this.tBx_Ergebnis.Size = new System.Drawing.Size(206, 20);
            this.tBx_Ergebnis.TabIndex = 3;
            this.tBx_Ergebnis.Text = "Ergebnis";
            this.tBx_Ergebnis.TextChanged += new System.EventHandler(this.tBx_Ergebnis_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(183, 38);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 34);
            this.button3.TabIndex = 6;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(183, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 34);
            this.button4.TabIndex = 8;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bt_1
            // 
            this.bt_1.Location = new System.Drawing.Point(13, 38);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(32, 34);
            this.bt_1.TabIndex = 9;
            this.bt_1.Text = "1";
            this.bt_1.UseVisualStyleBackColor = true;
            this.bt_1.Click += new System.EventHandler(this.button5_Click);
            // 
            // bt_2
            // 
            this.bt_2.Location = new System.Drawing.Point(51, 38);
            this.bt_2.Name = "bt_2";
            this.bt_2.Size = new System.Drawing.Size(32, 34);
            this.bt_2.TabIndex = 10;
            this.bt_2.Text = "2";
            this.bt_2.UseVisualStyleBackColor = true;
            this.bt_2.Click += new System.EventHandler(this.bt_2_Click);
            // 
            // bt_3
            // 
            this.bt_3.Location = new System.Drawing.Point(88, 38);
            this.bt_3.Name = "bt_3";
            this.bt_3.Size = new System.Drawing.Size(32, 34);
            this.bt_3.TabIndex = 11;
            this.bt_3.Text = "3";
            this.bt_3.UseVisualStyleBackColor = true;
            this.bt_3.Click += new System.EventHandler(this.bt_3_Click);
            // 
            // bt_4
            // 
            this.bt_4.Location = new System.Drawing.Point(12, 78);
            this.bt_4.Name = "bt_4";
            this.bt_4.Size = new System.Drawing.Size(32, 34);
            this.bt_4.TabIndex = 12;
            this.bt_4.Text = "4";
            this.bt_4.UseVisualStyleBackColor = true;
            this.bt_4.Click += new System.EventHandler(this.bt_4_Click);
            // 
            // bt_5
            // 
            this.bt_5.Location = new System.Drawing.Point(51, 78);
            this.bt_5.Name = "bt_5";
            this.bt_5.Size = new System.Drawing.Size(32, 34);
            this.bt_5.TabIndex = 13;
            this.bt_5.Text = "5";
            this.bt_5.UseVisualStyleBackColor = true;
            this.bt_5.Click += new System.EventHandler(this.bt_5_Click);
            // 
            // bt_6
            // 
            this.bt_6.Location = new System.Drawing.Point(89, 78);
            this.bt_6.Name = "bt_6";
            this.bt_6.Size = new System.Drawing.Size(31, 34);
            this.bt_6.TabIndex = 14;
            this.bt_6.Text = "6";
            this.bt_6.UseVisualStyleBackColor = true;
            this.bt_6.Click += new System.EventHandler(this.bt_6_Click);
            // 
            // bt_7
            // 
            this.bt_7.Location = new System.Drawing.Point(14, 116);
            this.bt_7.Name = "bt_7";
            this.bt_7.Size = new System.Drawing.Size(31, 34);
            this.bt_7.TabIndex = 15;
            this.bt_7.Text = "7";
            this.bt_7.UseVisualStyleBackColor = true;
            this.bt_7.Click += new System.EventHandler(this.bt_7_Click);
            // 
            // bt_8
            // 
            this.bt_8.Location = new System.Drawing.Point(51, 118);
            this.bt_8.Name = "bt_8";
            this.bt_8.Size = new System.Drawing.Size(32, 33);
            this.bt_8.TabIndex = 16;
            this.bt_8.Text = "8";
            this.bt_8.UseVisualStyleBackColor = true;
            this.bt_8.Click += new System.EventHandler(this.bt_8_Click);
            // 
            // bt_9
            // 
            this.bt_9.Location = new System.Drawing.Point(90, 118);
            this.bt_9.Name = "bt_9";
            this.bt_9.Size = new System.Drawing.Size(30, 32);
            this.bt_9.TabIndex = 17;
            this.bt_9.Text = "9";
            this.bt_9.UseVisualStyleBackColor = true;
            this.bt_9.Click += new System.EventHandler(this.bt_9_Click);
            // 
            // bt_0
            // 
            this.bt_0.Location = new System.Drawing.Point(12, 156);
            this.bt_0.Name = "bt_0";
            this.bt_0.Size = new System.Drawing.Size(108, 34);
            this.bt_0.TabIndex = 18;
            this.bt_0.Text = "0";
            this.bt_0.UseVisualStyleBackColor = true;
            this.bt_0.Click += new System.EventHandler(this.bt_0_Click);
            // 
            // bt_komma
            // 
            this.bt_komma.Location = new System.Drawing.Point(183, 116);
            this.bt_komma.Name = "bt_komma";
            this.bt_komma.Size = new System.Drawing.Size(32, 34);
            this.bt_komma.TabIndex = 19;
            this.bt_komma.Text = ",";
            this.bt_komma.UseVisualStyleBackColor = true;
            this.bt_komma.Click += new System.EventHandler(this.bt_kommer_Click);
            // 
            // bt_C
            // 
            this.bt_C.Location = new System.Drawing.Point(148, 156);
            this.bt_C.Name = "bt_C";
            this.bt_C.Size = new System.Drawing.Size(67, 34);
            this.bt_C.TabIndex = 20;
            this.bt_C.Tag = "";
            this.bt_C.Text = "C";
            this.bt_C.UseVisualStyleBackColor = true;
            this.bt_C.Click += new System.EventHandler(this.bt_C_Click);
            // 
            // bt_CE
            // 
            this.bt_CE.Location = new System.Drawing.Point(148, 118);
            this.bt_CE.Name = "bt_CE";
            this.bt_CE.Size = new System.Drawing.Size(32, 32);
            this.bt_CE.TabIndex = 21;
            this.bt_CE.Text = "CE";
            this.bt_CE.UseVisualStyleBackColor = true;
            this.bt_CE.Click += new System.EventHandler(this.bt_CE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 230);
            this.Controls.Add(this.bt_CE);
            this.Controls.Add(this.bt_C);
            this.Controls.Add(this.bt_komma);
            this.Controls.Add(this.bt_0);
            this.Controls.Add(this.bt_9);
            this.Controls.Add(this.bt_8);
            this.Controls.Add(this.bt_7);
            this.Controls.Add(this.bt_6);
            this.Controls.Add(this.bt_5);
            this.Controls.Add(this.bt_4);
            this.Controls.Add(this.bt_3);
            this.Controls.Add(this.bt_2);
            this.Controls.Add(this.bt_1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tBx_Ergebnis);
            this.Controls.Add(this.tBx_Zahl2);
            this.Controls.Add(this.tBx_Zahl1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Taschenrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tBx_Zahl1;
        private System.Windows.Forms.TextBox tBx_Zahl2;
        private System.Windows.Forms.TextBox tBx_Ergebnis;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.Button bt_2;
        private System.Windows.Forms.Button bt_3;
        private System.Windows.Forms.Button bt_4;
        private System.Windows.Forms.Button bt_5;
        private System.Windows.Forms.Button bt_6;
        private System.Windows.Forms.Button bt_7;
        private System.Windows.Forms.Button bt_8;
        private System.Windows.Forms.Button bt_9;
        private System.Windows.Forms.Button bt_0;
        private System.Windows.Forms.Button bt_komma;
        private System.Windows.Forms.Button bt_C;
        private System.Windows.Forms.Button bt_CE;
    }
}

