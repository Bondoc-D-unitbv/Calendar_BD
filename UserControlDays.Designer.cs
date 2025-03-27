
namespace Calendar_SQL
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_day = new System.Windows.Forms.Label();
            this.button_event_new = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_day
            // 
            this.label_day.AutoSize = true;
            this.label_day.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_day.Location = new System.Drawing.Point(4, 4);
            this.label_day.Name = "label_day";
            this.label_day.Size = new System.Drawing.Size(34, 21);
            this.label_day.TabIndex = 0;
            this.label_day.Text = "00";
            // 
            // button_event_new
            // 
            this.button_event_new.Location = new System.Drawing.Point(3, 57);
            this.button_event_new.Name = "button_event_new";
            this.button_event_new.Size = new System.Drawing.Size(120, 23);
            this.button_event_new.TabIndex = 1;
            this.button_event_new.Text = "Eveniment Nou";
            this.button_event_new.UseVisualStyleBackColor = true;
            this.button_event_new.Click += new System.EventHandler(this.button_event_new_Click);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_event_new);
            this.Controls.Add(this.label_day);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(126, 83);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_day;
        private System.Windows.Forms.Button button_event_new;
    }
}
