namespace ProfessionalLesson13Task1
{
    partial class Form1
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
            this.IsComplete_Btn = new System.Windows.Forms.Button();
            this.End_Btn = new System.Windows.Forms.Button();
            this.CallBack_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IsComplete_Btn
            // 
            this.IsComplete_Btn.Location = new System.Drawing.Point(12, 12);
            this.IsComplete_Btn.Name = "IsComplete_Btn";
            this.IsComplete_Btn.Size = new System.Drawing.Size(95, 23);
            this.IsComplete_Btn.TabIndex = 0;
            this.IsComplete_Btn.Text = "IsComplete";
            this.IsComplete_Btn.UseVisualStyleBackColor = true;
            this.IsComplete_Btn.Click += new System.EventHandler(this.IsComplete_Btn_Click);
            // 
            // End_Btn
            // 
            this.End_Btn.Location = new System.Drawing.Point(113, 12);
            this.End_Btn.Name = "End_Btn";
            this.End_Btn.Size = new System.Drawing.Size(75, 23);
            this.End_Btn.TabIndex = 1;
            this.End_Btn.Text = "End";
            this.End_Btn.UseVisualStyleBackColor = true;
            this.End_Btn.Click += new System.EventHandler(this.End_Btn_Click);
            // 
            // CallBack_Btn
            // 
            this.CallBack_Btn.Location = new System.Drawing.Point(194, 12);
            this.CallBack_Btn.Name = "CallBack_Btn";
            this.CallBack_Btn.Size = new System.Drawing.Size(75, 23);
            this.CallBack_Btn.TabIndex = 2;
            this.CallBack_Btn.Text = "CallBack";
            this.CallBack_Btn.UseVisualStyleBackColor = true;
            this.CallBack_Btn.Click += new System.EventHandler(this.CallBack_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 62);
            this.Controls.Add(this.CallBack_Btn);
            this.Controls.Add(this.End_Btn);
            this.Controls.Add(this.IsComplete_Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IsComplete_Btn;
        private System.Windows.Forms.Button End_Btn;
        private System.Windows.Forms.Button CallBack_Btn;
    }
}

