
namespace Lab01Deneme
{
    partial class Araform
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LavenderBlush;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(163, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculator";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LavenderBlush;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button2.Location = new System.Drawing.Point(455, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cipher";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LavenderBlush;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button3.Location = new System.Drawing.Point(308, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 65);
            this.button3.TabIndex = 2;
            this.button3.Text = "Map";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Araform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Araform";
            this.Text = "Araform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}