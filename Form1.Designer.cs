
namespace Calendar_SQL
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;


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
            this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_prev = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_month_year = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_afisare_eveniment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // daycontainer
            // 
            this.daycontainer.BackColor = System.Drawing.Color.LightGray;
            this.daycontainer.Location = new System.Drawing.Point(12, 111);
            this.daycontainer.Name = "daycontainer";
            this.daycontainer.Size = new System.Drawing.Size(926, 537);
            this.daycontainer.TabIndex = 0;
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.White;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.Color.DarkGray;
            this.button_exit.Location = new System.Drawing.Point(849, 12);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(89, 34);
            this.button_exit.TabIndex = 1;
            this.button_exit.Text = "Ieșire";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_prev
            // 
            this.button_prev.BackColor = System.Drawing.Color.White;
            this.button_prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_prev.ForeColor = System.Drawing.Color.DarkGray;
            this.button_prev.Location = new System.Drawing.Point(754, 654);
            this.button_prev.Name = "button_prev";
            this.button_prev.Size = new System.Drawing.Size(89, 34);
            this.button_prev.TabIndex = 2;
            this.button_prev.Text = "Înapoi";
            this.button_prev.UseVisualStyleBackColor = false;
            this.button_prev.Click += new System.EventHandler(this.button_prev_Click);
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.Color.White;
            this.button_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_next.ForeColor = System.Drawing.Color.DarkGray;
            this.button_next.Location = new System.Drawing.Point(849, 654);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(89, 34);
            this.button_next.TabIndex = 3;
            this.button_next.Text = "Înainte";
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Duminică";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Luni";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Marți";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(436, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Miercuri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(589, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Joi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(712, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Vineri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(832, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Sâmbătă";
            // 
            // label_month_year
            // 
            this.label_month_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_month_year.Location = new System.Drawing.Point(324, 12);
            this.label_month_year.Name = "label_month_year";
            this.label_month_year.Size = new System.Drawing.Size(297, 34);
            this.label_month_year.TabIndex = 11;
            this.label_month_year.Text = "Month - Year";
            this.label_month_year.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(754, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 34);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_afisare_eveniment
            // 
            this.button_afisare_eveniment.BackColor = System.Drawing.Color.White;
            this.button_afisare_eveniment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_afisare_eveniment.ForeColor = System.Drawing.Color.DarkGray;
            this.button_afisare_eveniment.Location = new System.Drawing.Point(12, 12);
            this.button_afisare_eveniment.Name = "button_afisare_eveniment";
            this.button_afisare_eveniment.Size = new System.Drawing.Size(197, 34);
            this.button_afisare_eveniment.TabIndex = 13;
            this.button_afisare_eveniment.Text = "Afișare Evenimente";
            this.button_afisare_eveniment.UseVisualStyleBackColor = false;
            this.button_afisare_eveniment.Click += new System.EventHandler(this.button_afisare_eveniment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(950, 700);
            this.Controls.Add(this.button_afisare_eveniment);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_month_year);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_prev);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.daycontainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel daycontainer;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_prev;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_month_year;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_afisare_eveniment;
    }
}

