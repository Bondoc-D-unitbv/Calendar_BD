
namespace Calendar_SQL
{
    partial class Form_Eveniment
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
            this.label_eveniment_nou = new System.Windows.Forms.Label();
            this.label_titu = new System.Windows.Forms.Label();
            this.label_data = new System.Windows.Forms.Label();
            this.label_descriere = new System.Windows.Forms.Label();
            this.textBox_Titlu = new System.Windows.Forms.TextBox();
            this.textBox_Data_an = new System.Windows.Forms.TextBox();
            this.richTextBox_Descriere = new System.Windows.Forms.RichTextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Data_luna = new System.Windows.Forms.TextBox();
            this.textBox_Data_zi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_eveniment_nou
            // 
            this.label_eveniment_nou.AutoSize = true;
            this.label_eveniment_nou.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_eveniment_nou.Location = new System.Drawing.Point(231, 9);
            this.label_eveniment_nou.Name = "label_eveniment_nou";
            this.label_eveniment_nou.Size = new System.Drawing.Size(172, 28);
            this.label_eveniment_nou.TabIndex = 0;
            this.label_eveniment_nou.Text = "Eveniment nou";
            // 
            // label_titu
            // 
            this.label_titu.AutoSize = true;
            this.label_titu.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titu.Location = new System.Drawing.Point(63, 65);
            this.label_titu.Name = "label_titu";
            this.label_titu.Size = new System.Drawing.Size(57, 28);
            this.label_titu.TabIndex = 1;
            this.label_titu.Text = "Titlu";
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_data.Location = new System.Drawing.Point(61, 93);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(60, 28);
            this.label_data.TabIndex = 2;
            this.label_data.Text = "Data";
            // 
            // label_descriere
            // 
            this.label_descriere.AutoSize = true;
            this.label_descriere.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_descriere.Location = new System.Drawing.Point(13, 121);
            this.label_descriere.Name = "label_descriere";
            this.label_descriere.Size = new System.Drawing.Size(107, 28);
            this.label_descriere.TabIndex = 3;
            this.label_descriere.Text = "Descriere";
            // 
            // textBox_Titlu
            // 
            this.textBox_Titlu.Location = new System.Drawing.Point(129, 73);
            this.textBox_Titlu.Name = "textBox_Titlu";
            this.textBox_Titlu.Size = new System.Drawing.Size(491, 20);
            this.textBox_Titlu.TabIndex = 4;
            // 
            // textBox_Data_an
            // 
            this.textBox_Data_an.Location = new System.Drawing.Point(170, 101);
            this.textBox_Data_an.Name = "textBox_Data_an";
            this.textBox_Data_an.Size = new System.Drawing.Size(47, 20);
            this.textBox_Data_an.TabIndex = 5;
            // 
            // richTextBox_Descriere
            // 
            this.richTextBox_Descriere.Location = new System.Drawing.Point(129, 127);
            this.richTextBox_Descriere.Name = "richTextBox_Descriere";
            this.richTextBox_Descriere.Size = new System.Drawing.Size(491, 215);
            this.richTextBox_Descriere.TabIndex = 6;
            this.richTextBox_Descriere.Text = "";
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_save.Location = new System.Drawing.Point(464, 348);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 7;
            this.button_save.Text = "Salvează";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(545, 348);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 8;
            this.button_cancel.Text = "Închide";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "An";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lună";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Zi";
            // 
            // textBox_Data_luna
            // 
            this.textBox_Data_luna.Location = new System.Drawing.Point(290, 101);
            this.textBox_Data_luna.Name = "textBox_Data_luna";
            this.textBox_Data_luna.Size = new System.Drawing.Size(47, 20);
            this.textBox_Data_luna.TabIndex = 12;
            // 
            // textBox_Data_zi
            // 
            this.textBox_Data_zi.Location = new System.Drawing.Point(380, 101);
            this.textBox_Data_zi.Name = "textBox_Data_zi";
            this.textBox_Data_zi.Size = new System.Drawing.Size(47, 20);
            this.textBox_Data_zi.TabIndex = 13;
            // 
            // Form_Eveniment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 379);
            this.Controls.Add(this.textBox_Data_zi);
            this.Controls.Add(this.textBox_Data_luna);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.richTextBox_Descriere);
            this.Controls.Add(this.textBox_Data_an);
            this.Controls.Add(this.textBox_Titlu);
            this.Controls.Add(this.label_descriere);
            this.Controls.Add(this.label_data);
            this.Controls.Add(this.label_titu);
            this.Controls.Add(this.label_eveniment_nou);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Eveniment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Eveniment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_eveniment_nou;
        private System.Windows.Forms.Label label_titu;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.Label label_descriere;
        private System.Windows.Forms.TextBox textBox_Titlu;
        private System.Windows.Forms.TextBox textBox_Data_an;
        private System.Windows.Forms.RichTextBox richTextBox_Descriere;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Data_luna;
        private System.Windows.Forms.TextBox textBox_Data_zi;
    }
}