namespace cslab4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.color1 = new System.Windows.Forms.Button();
            this.color2 = new System.Windows.Forms.Button();
            this.color3 = new System.Windows.Forms.Button();
            this.color4 = new System.Windows.Forms.Button();
            this.shape1 = new System.Windows.Forms.Button();
            this.shape2 = new System.Windows.Forms.Button();
            this.shape3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.showBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel1.Location = new System.Drawing.Point(179, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 817);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // color1
            // 
            this.color1.BackColor = System.Drawing.Color.Black;
            this.color1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.color1.Location = new System.Drawing.Point(7, 270);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(80, 80);
            this.color1.TabIndex = 1;
            this.color1.UseVisualStyleBackColor = false;
            this.color1.Click += new System.EventHandler(this.color1_Click);
            // 
            // color2
            // 
            this.color2.BackColor = System.Drawing.Color.White;
            this.color2.Location = new System.Drawing.Point(93, 270);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(80, 80);
            this.color2.TabIndex = 2;
            this.color2.UseVisualStyleBackColor = false;
            this.color2.Click += new System.EventHandler(this.color2_Click);
            // 
            // color3
            // 
            this.color3.BackColor = System.Drawing.Color.Red;
            this.color3.Location = new System.Drawing.Point(7, 356);
            this.color3.Name = "color3";
            this.color3.Size = new System.Drawing.Size(80, 80);
            this.color3.TabIndex = 3;
            this.color3.UseVisualStyleBackColor = false;
            this.color3.Click += new System.EventHandler(this.color3_Click);
            // 
            // color4
            // 
            this.color4.BackColor = System.Drawing.Color.Blue;
            this.color4.Location = new System.Drawing.Point(93, 356);
            this.color4.Name = "color4";
            this.color4.Size = new System.Drawing.Size(80, 80);
            this.color4.TabIndex = 4;
            this.color4.UseVisualStyleBackColor = false;
            this.color4.Click += new System.EventHandler(this.color4_Click);
            // 
            // shape1
            // 
            this.shape1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shape1.Location = new System.Drawing.Point(8, 12);
            this.shape1.Name = "shape1";
            this.shape1.Size = new System.Drawing.Size(165, 80);
            this.shape1.TabIndex = 5;
            this.shape1.Text = "line";
            this.shape1.UseVisualStyleBackColor = true;
            this.shape1.Click += new System.EventHandler(this.shape1_Click);
            // 
            // shape2
            // 
            this.shape2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shape2.Location = new System.Drawing.Point(8, 98);
            this.shape2.Name = "shape2";
            this.shape2.Size = new System.Drawing.Size(165, 80);
            this.shape2.TabIndex = 6;
            this.shape2.Text = "point";
            this.shape2.UseVisualStyleBackColor = true;
            this.shape2.Click += new System.EventHandler(this.shape2_Click);
            // 
            // shape3
            // 
            this.shape3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shape3.Location = new System.Drawing.Point(8, 184);
            this.shape3.Name = "shape3";
            this.shape3.Size = new System.Drawing.Size(165, 80);
            this.shape3.TabIndex = 7;
            this.shape3.Text = "square";
            this.shape3.UseVisualStyleBackColor = true;
            this.shape3.Click += new System.EventHandler(this.shape3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Size:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(78, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(141, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 29);
            this.button2.TabIndex = 10;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // showBox
            // 
            this.showBox.AutoSize = true;
            this.showBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.showBox.Location = new System.Drawing.Point(116, 457);
            this.showBox.Name = "showBox";
            this.showBox.Size = new System.Drawing.Size(24, 20);
            this.showBox.TabIndex = 11;
            this.showBox.Text = "ttt";
            this.showBox.Click += new System.EventHandler(this.showBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1184, 841);
            this.Controls.Add(this.showBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shape3);
            this.Controls.Add(this.shape2);
            this.Controls.Add(this.shape1);
            this.Controls.Add(this.color4);
            this.Controls.Add(this.color3);
            this.Controls.Add(this.color2);
            this.Controls.Add(this.color1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lines";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button color1;
        private System.Windows.Forms.Button color2;
        private System.Windows.Forms.Button color3;
        private System.Windows.Forms.Button color4;
        private System.Windows.Forms.Button shape1;
        private System.Windows.Forms.Button shape2;
        private System.Windows.Forms.Button shape3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label showBox;
        public System.Windows.Forms.Panel panel1;
    }
}

