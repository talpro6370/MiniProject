namespace MiniProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Ball = new System.Windows.Forms.PictureBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.addBallBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // Ball
            // 
            this.Ball.Image = ((System.Drawing.Image)(resources.GetObject("Ball.Image")));
            this.Ball.Location = new System.Drawing.Point(517, 179);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(272, 259);
            this.Ball.TabIndex = 0;
            this.Ball.TabStop = false;
            this.Ball.Visible = false;
            this.Ball.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.SystemColors.Menu;
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Niagara Engraved", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.startBtn.Location = new System.Drawing.Point(517, 50);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(206, 87);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // addBallBtn
            // 
            this.addBallBtn.BackColor = System.Drawing.SystemColors.Menu;
            this.addBallBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBallBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBallBtn.Font = new System.Drawing.Font("Niagara Engraved", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBallBtn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.addBallBtn.Location = new System.Drawing.Point(219, 50);
            this.addBallBtn.Name = "addBallBtn";
            this.addBallBtn.Size = new System.Drawing.Size(206, 87);
            this.addBallBtn.TabIndex = 2;
            this.addBallBtn.Text = "Add ball";
            this.addBallBtn.UseVisualStyleBackColor = false;
            this.addBallBtn.Click += new System.EventHandler(this.addBallBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(967, 487);
            this.Controls.Add(this.addBallBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.Ball);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button addBallBtn;
    }
}

