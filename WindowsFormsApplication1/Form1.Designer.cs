namespace WindowsFormsApplication1
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
            this.canvas = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numIncrement = new System.Windows.Forms.TextBox();
            this.numLength = new System.Windows.Forms.TextBox();
            this.numAngle = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numLine = new System.Windows.Forms.TextBox();
            this.Increment = new System.Windows.Forms.Label();
            this.Length = new System.Windows.Forms.Label();
            this.Angle = new System.Windows.Forms.Label();
            this.Lines = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(606, 492);
            this.canvas.TabIndex = 0;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.numIncrement);
            this.panel2.Controls.Add(this.numLength);
            this.panel2.Controls.Add(this.numAngle);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.numLine);
            this.panel2.Controls.Add(this.Increment);
            this.panel2.Controls.Add(this.Length);
            this.panel2.Controls.Add(this.Angle);
            this.panel2.Controls.Add(this.Lines);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 65);
            this.panel2.TabIndex = 1;
            // 
            // numIncrement
            // 
            this.numIncrement.Location = new System.Drawing.Point(463, 23);
            this.numIncrement.Name = "numIncrement";
            this.numIncrement.Size = new System.Drawing.Size(38, 20);
            this.numIncrement.TabIndex = 11;
            this.numIncrement.Text = "1";
            this.numIncrement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numLength
            // 
            this.numLength.Location = new System.Drawing.Point(315, 23);
            this.numLength.Name = "numLength";
            this.numLength.Size = new System.Drawing.Size(38, 20);
            this.numLength.TabIndex = 10;
            this.numLength.Text = "100";
            this.numLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numAngle
            // 
            this.numAngle.Location = new System.Drawing.Point(189, 23);
            this.numAngle.Name = "numAngle";
            this.numAngle.Size = new System.Drawing.Size(38, 20);
            this.numAngle.TabIndex = 9;
            this.numAngle.Text = "90";
            this.numAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "GO!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numLine
            // 
            this.numLine.Location = new System.Drawing.Point(76, 23);
            this.numLine.Name = "numLine";
            this.numLine.Size = new System.Drawing.Size(38, 20);
            this.numLine.TabIndex = 4;
            this.numLine.Text = "1";
            this.numLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Increment
            // 
            this.Increment.AutoSize = true;
            this.Increment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Increment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Increment.Location = new System.Drawing.Point(382, 25);
            this.Increment.Name = "Increment";
            this.Increment.Size = new System.Drawing.Size(75, 16);
            this.Increment.TabIndex = 3;
            this.Increment.Text = "Increment";
            // 
            // Length
            // 
            this.Length.AutoSize = true;
            this.Length.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Length.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Length.Location = new System.Drawing.Point(255, 25);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(54, 16);
            this.Length.TabIndex = 2;
            this.Length.Text = "Length";
            // 
            // Angle
            // 
            this.Angle.AutoSize = true;
            this.Angle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Angle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Angle.Location = new System.Drawing.Point(135, 25);
            this.Angle.Name = "Angle";
            this.Angle.Size = new System.Drawing.Size(48, 16);
            this.Angle.TabIndex = 1;
            this.Angle.Text = "Angle";
            // 
            // Lines
            // 
            this.Lines.AutoSize = true;
            this.Lines.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lines.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lines.Location = new System.Drawing.Point(13, 25);
            this.Lines.Name = "Lines";
            this.Lines.Size = new System.Drawing.Size(57, 16);
            this.Lines.TabIndex = 0;
            this.Lines.Text = "# Lines";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 492);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LinePatterns";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox numIncrement;
        private System.Windows.Forms.TextBox numLength;
        private System.Windows.Forms.TextBox numAngle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox numLine;
        private System.Windows.Forms.Label Increment;
        private System.Windows.Forms.Label Length;
        private System.Windows.Forms.Label Angle;
        private System.Windows.Forms.Label Lines;
    }
}

