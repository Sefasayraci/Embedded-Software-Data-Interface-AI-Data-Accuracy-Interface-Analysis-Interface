namespace aerosense
{
    partial class contents
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
            this.tableofcontents = new System.Windows.Forms.Label();
            this.contbuton1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cont1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tableofcontents
            // 
            this.tableofcontents.AutoSize = true;
            this.tableofcontents.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableofcontents.ForeColor = System.Drawing.Color.White;
            this.tableofcontents.Location = new System.Drawing.Point(342, 9);
            this.tableofcontents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tableofcontents.Name = "tableofcontents";
            this.tableofcontents.Size = new System.Drawing.Size(229, 31);
            this.tableofcontents.TabIndex = 0;
            this.tableofcontents.Text = "Table of Contents";
            // 
            // contbuton1
            // 
            this.contbuton1.Location = new System.Drawing.Point(547, 88);
            this.contbuton1.Name = "contbuton1";
            this.contbuton1.Size = new System.Drawing.Size(154, 34);
            this.contbuton1.TabIndex = 1;
            this.contbuton1.Text = "Menu";
            this.contbuton1.UseVisualStyleBackColor = true;
            this.contbuton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(547, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "About Project";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cont1
            // 
            this.cont1.AutoSize = true;
            this.cont1.ForeColor = System.Drawing.Color.White;
            this.cont1.Location = new System.Drawing.Point(200, 95);
            this.cont1.Name = "cont1";
            this.cont1.Size = new System.Drawing.Size(329, 20);
            this.cont1.TabIndex = 3;
            this.cont1.Text = "Telemetry Data and Control Interface --------->";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(200, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Project Explanation --------------------------------->";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(547, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "About Project";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // contents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(968, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cont1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.contbuton1);
            this.Controls.Add(this.tableofcontents);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "contents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "contents";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tableofcontents;
        private System.Windows.Forms.Button contbuton1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label cont1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}