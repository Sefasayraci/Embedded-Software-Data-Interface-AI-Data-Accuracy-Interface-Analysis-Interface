namespace aerosense
{
    partial class @abstract
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
            this.abstract2 = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // abstract2
            // 
            this.abstract2.AutoSize = true;
            this.abstract2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abstract2.ForeColor = System.Drawing.Color.White;
            this.abstract2.Location = new System.Drawing.Point(383, 9);
            this.abstract2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.abstract2.Name = "abstract2";
            this.abstract2.Size = new System.Drawing.Size(115, 31);
            this.abstract2.TabIndex = 1;
            this.abstract2.Text = "Abstract";
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(30, 355);
            this.backbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(202, 53);
            this.backbutton.TabIndex = 2;
            this.backbutton.Text = "Back (Table Of Contents)";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // @abstract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(968, 422);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.abstract2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "@abstract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abstract";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label abstract2;
        private System.Windows.Forms.Button backbutton;
    }
}