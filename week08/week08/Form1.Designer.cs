namespace week08
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.lblNext = new System.Windows.Forms.Label();
            this.Carbtn = new System.Windows.Forms.Button();
            this.ballbtn = new System.Windows.Forms.Button();
            this.color = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(0, 332);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(801, 118);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(401, 148);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(35, 13);
            this.lblNext.TabIndex = 1;
            this.lblNext.Text = "label1";
            // 
            // Carbtn
            // 
            this.Carbtn.Location = new System.Drawing.Point(106, 47);
            this.Carbtn.Name = "Carbtn";
            this.Carbtn.Size = new System.Drawing.Size(75, 23);
            this.Carbtn.TabIndex = 2;
            this.Carbtn.Text = "Car";
            this.Carbtn.UseVisualStyleBackColor = true;
            this.Carbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ballbtn
            // 
            this.ballbtn.Location = new System.Drawing.Point(187, 47);
            this.ballbtn.Name = "ballbtn";
            this.ballbtn.Size = new System.Drawing.Size(75, 23);
            this.ballbtn.TabIndex = 3;
            this.ballbtn.Text = "Ball";
            this.ballbtn.UseVisualStyleBackColor = true;
            this.ballbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // color
            // 
            this.color.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.color.Location = new System.Drawing.Point(268, 47);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(75, 23);
            this.color.TabIndex = 4;
            this.color.Text = "Color";
            this.color.UseVisualStyleBackColor = false;
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.color);
            this.Controls.Add(this.ballbtn);
            this.Controls.Add(this.Carbtn);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Button Carbtn;
        private System.Windows.Forms.Button ballbtn;
        private System.Windows.Forms.Button color;
    }
}

