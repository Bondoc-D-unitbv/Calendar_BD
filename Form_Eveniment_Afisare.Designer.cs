
namespace Calendar_SQL
{
    partial class Form_Eveniment_Afisare
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
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label_afisare_eveniment = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Data_eveniment_an = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Data_eveniment_luna = new System.Windows.Forms.TextBox();
            this.textBox_Data_eveniment_zi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(545, 347);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 18;
            this.button_cancel.Text = "Închide";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_save.Location = new System.Drawing.Point(545, 89);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 17;
            this.button_save.Text = "Afișază";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label_afisare_eveniment
            // 
            this.label_afisare_eveniment.AutoSize = true;
            this.label_afisare_eveniment.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_afisare_eveniment.Location = new System.Drawing.Point(231, 8);
            this.label_afisare_eveniment.Name = "label_afisare_eveniment";
            this.label_afisare_eveniment.Size = new System.Drawing.Size(204, 28);
            this.label_afisare_eveniment.TabIndex = 10;
            this.label_afisare_eveniment.Text = "Afișare Eveniment";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(608, 224);
            this.dataGridView1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Introduceți data din care să se afișeze evenimentul";
            // 
            // textBox_Data_eveniment_an
            // 
            this.textBox_Data_eveniment_an.Location = new System.Drawing.Point(50, 91);
            this.textBox_Data_eveniment_an.Name = "textBox_Data_eveniment_an";
            this.textBox_Data_eveniment_an.Size = new System.Drawing.Size(57, 20);
            this.textBox_Data_eveniment_an.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "An";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "Lună";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(232, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "Zi";
            // 
            // textBox_Data_eveniment_luna
            // 
            this.textBox_Data_eveniment_luna.Location = new System.Drawing.Point(167, 91);
            this.textBox_Data_eveniment_luna.Name = "textBox_Data_eveniment_luna";
            this.textBox_Data_eveniment_luna.Size = new System.Drawing.Size(57, 20);
            this.textBox_Data_eveniment_luna.TabIndex = 26;
            // 
            // textBox_Data_eveniment_zi
            // 
            this.textBox_Data_eveniment_zi.Location = new System.Drawing.Point(263, 91);
            this.textBox_Data_eveniment_zi.Name = "textBox_Data_eveniment_zi";
            this.textBox_Data_eveniment_zi.Size = new System.Drawing.Size(57, 20);
            this.textBox_Data_eveniment_zi.TabIndex = 27;
            // 
            // Form_Eveniment_Afisare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 379);
            this.Controls.Add(this.textBox_Data_eveniment_zi);
            this.Controls.Add(this.textBox_Data_eveniment_luna);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Data_eveniment_an);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label_afisare_eveniment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Eveniment_Afisare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Eveniment_Afisare";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label_afisare_eveniment;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Data_eveniment_an;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Data_eveniment_luna;
        private System.Windows.Forms.TextBox textBox_Data_eveniment_zi;
    }
}