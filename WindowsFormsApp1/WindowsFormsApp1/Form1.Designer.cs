namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textDvojkova = new System.Windows.Forms.TextBox();
            this.textOsmickova = new System.Windows.Forms.TextBox();
            this.textSestnactkova = new System.Windows.Forms.TextBox();
            this.textSestkova = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dvojkova = new System.Windows.Forms.CheckBox();
            this.osmickova = new System.Windows.Forms.CheckBox();
            this.sestkova = new System.Windows.Forms.CheckBox();
            this.sestnactkova = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Převeď";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(296, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zadejte nenulové kladné číslo v desítkové soustavě:";
            // 
            // textDvojkova
            // 
            this.textDvojkova.Location = new System.Drawing.Point(45, 202);
            this.textDvojkova.Name = "textDvojkova";
            this.textDvojkova.Size = new System.Drawing.Size(296, 26);
            this.textDvojkova.TabIndex = 3;
            this.textDvojkova.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textOsmickova
            // 
            this.textOsmickova.Location = new System.Drawing.Point(45, 279);
            this.textOsmickova.Name = "textOsmickova";
            this.textOsmickova.Size = new System.Drawing.Size(296, 26);
            this.textOsmickova.TabIndex = 4;
            // 
            // textSestnactkova
            // 
            this.textSestnactkova.Location = new System.Drawing.Point(45, 355);
            this.textSestnactkova.Name = "textSestnactkova";
            this.textSestnactkova.Size = new System.Drawing.Size(296, 26);
            this.textSestnactkova.TabIndex = 5;
            // 
            // textSestkova
            // 
            this.textSestkova.Location = new System.Drawing.Point(45, 437);
            this.textSestkova.Name = "textSestkova";
            this.textSestkova.Size = new System.Drawing.Size(296, 26);
            this.textSestkova.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Zadané číslo ve dvojkové soustavě:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Zadané číslo v osmičkové soustavě:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Zadané číslo v šestnáctkové soustavě:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Zadané číslo v šestkové soustavě:";
            // 
            // dvojkova
            // 
            this.dvojkova.AutoSize = true;
            this.dvojkova.Location = new System.Drawing.Point(16, 101);
            this.dvojkova.Name = "dvojkova";
            this.dvojkova.Size = new System.Drawing.Size(96, 24);
            this.dvojkova.TabIndex = 11;
            this.dvojkova.Text = "dvojková";
            this.dvojkova.UseVisualStyleBackColor = true;
            this.dvojkova.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // osmickova
            // 
            this.osmickova.AutoSize = true;
            this.osmickova.Location = new System.Drawing.Point(16, 143);
            this.osmickova.Name = "osmickova";
            this.osmickova.Size = new System.Drawing.Size(109, 24);
            this.osmickova.TabIndex = 12;
            this.osmickova.Text = "osmičková";
            this.osmickova.UseVisualStyleBackColor = true;
            // 
            // sestkova
            // 
            this.sestkova.AutoSize = true;
            this.sestkova.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sestkova.Location = new System.Drawing.Point(128, 101);
            this.sestkova.Name = "sestkova";
            this.sestkova.Size = new System.Drawing.Size(98, 24);
            this.sestkova.TabIndex = 13;
            this.sestkova.Text = "šestková";
            this.sestkova.UseVisualStyleBackColor = true;
            this.sestkova.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // sestnactkova
            // 
            this.sestnactkova.AutoSize = true;
            this.sestnactkova.Location = new System.Drawing.Point(128, 143);
            this.sestnactkova.Name = "sestnactkova";
            this.sestnactkova.Size = new System.Drawing.Size(129, 24);
            this.sestnactkova.TabIndex = 14;
            this.sestnactkova.Text = "šestnáctková";
            this.sestnactkova.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 40);
            this.label6.TabIndex = 15;
            this.label6.Text = "              © \r\nSchenaTeam 2019";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(407, 523);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sestnactkova);
            this.Controls.Add(this.sestkova);
            this.Controls.Add(this.osmickova);
            this.Controls.Add(this.dvojkova);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSestkova);
            this.Controls.Add(this.textSestnactkova);
            this.Controls.Add(this.textOsmickova);
            this.Controls.Add(this.textDvojkova);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Přepočet soustav";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textDvojkova;
        private System.Windows.Forms.TextBox textOsmickova;
        private System.Windows.Forms.TextBox textSestnactkova;
        private System.Windows.Forms.TextBox textSestkova;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox dvojkova;
        private System.Windows.Forms.CheckBox osmickova;
        private System.Windows.Forms.CheckBox sestkova;
        private System.Windows.Forms.CheckBox sestnactkova;
        private System.Windows.Forms.Label label6;
    }
}

