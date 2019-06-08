namespace Casa_de_schim_valutar
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.amount_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fromcombo1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tocombo2 = new System.Windows.Forms.ComboBox();
            this.disply_txt = new System.Windows.Forms.Label();
            this.conv_btn = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(55, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suma";
            // 
            // amount_txt
            // 
            this.amount_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amount_txt.Location = new System.Drawing.Point(59, 59);
            this.amount_txt.Margin = new System.Windows.Forms.Padding(4);
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(115, 29);
            this.amount_txt.TabIndex = 1;
            this.amount_txt.TextChanged += new System.EventHandler(this.amount_txt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(235, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alege Valuta";
            // 
            // fromcombo1
            // 
            this.fromcombo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromcombo1.FormattingEnabled = true;
            this.fromcombo1.Items.AddRange(new object[] {
            "MDL",
            "USD",
            "EUR"});
            this.fromcombo1.Location = new System.Drawing.Point(239, 59);
            this.fromcombo1.Margin = new System.Windows.Forms.Padding(4);
            this.fromcombo1.Name = "fromcombo1";
            this.fromcombo1.Size = new System.Drawing.Size(115, 32);
            this.fromcombo1.TabIndex = 3;
            this.fromcombo1.SelectedIndexChanged += new System.EventHandler(this.fromcombo1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(415, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alege valuta de schimb";
            // 
            // tocombo2
            // 
            this.tocombo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tocombo2.FormattingEnabled = true;
            this.tocombo2.Items.AddRange(new object[] {
            "MDL",
            "USD",
            "EUR"});
            this.tocombo2.Location = new System.Drawing.Point(419, 59);
            this.tocombo2.Margin = new System.Windows.Forms.Padding(4);
            this.tocombo2.Name = "tocombo2";
            this.tocombo2.Size = new System.Drawing.Size(115, 32);
            this.tocombo2.TabIndex = 5;
            this.tocombo2.SelectedIndexChanged += new System.EventHandler(this.tocombo2_SelectedIndexChanged);
            // 
            // disply_txt
            // 
            this.disply_txt.AutoSize = true;
            this.disply_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.disply_txt.Location = new System.Drawing.Point(55, 137);
            this.disply_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.disply_txt.Name = "disply_txt";
            this.disply_txt.Size = new System.Drawing.Size(135, 24);
            this.disply_txt.TabIndex = 6;
            this.disply_txt.Text = "Suma obtinuta:";
            // 
            // conv_btn
            // 
            this.conv_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.conv_btn.FlatAppearance.BorderSize = 0;
            this.conv_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.conv_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.conv_btn.Location = new System.Drawing.Point(697, 19);
            this.conv_btn.Margin = new System.Windows.Forms.Padding(4);
            this.conv_btn.Name = "conv_btn";
            this.conv_btn.Size = new System.Drawing.Size(147, 72);
            this.conv_btn.TabIndex = 7;
            this.conv_btn.Text = "Rezultat";
            this.conv_btn.UseVisualStyleBackColor = false;
            this.conv_btn.Click += new System.EventHandler(this.conv_btn_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(371, 120);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(520, 120);
            this.webBrowser1.TabIndex = 8;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(914, 252);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.conv_btn);
            this.Controls.Add(this.disply_txt);
            this.Controls.Add(this.tocombo2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fromcombo1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amount_txt);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Casa de schimb valutar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amount_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tocombo2;
        private System.Windows.Forms.Label disply_txt;
        private System.Windows.Forms.Button conv_btn;
        private System.Windows.Forms.ComboBox fromcombo1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

