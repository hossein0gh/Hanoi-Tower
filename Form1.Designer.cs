namespace TowersWindows
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
            this.DiskCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSolve = new System.Windows.Forms.Button();
            this.listMoves = new System.Windows.Forms.ListBox();
            this.lblMoves = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DiskCount)).BeginInit();
            this.SuspendLayout();
            // 
            // DiskCount
            // 
            this.DiskCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(255)))), ((int)(((byte)(216)))));
            this.DiskCount.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiskCount.Location = new System.Drawing.Point(175, 9);
            this.DiskCount.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.DiskCount.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.DiskCount.Name = "DiskCount";
            this.DiskCount.Size = new System.Drawing.Size(52, 26);
            this.DiskCount.TabIndex = 0;
            this.DiskCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DiskCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.DiskCount.ValueChanged += new System.EventHandler(this.DiskCount_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of disks : ";
            // 
            // btnSolve
            // 
            this.btnSolve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(255)))), ((int)(((byte)(216)))));
            this.btnSolve.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolve.Location = new System.Drawing.Point(254, 7);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(100, 28);
            this.btnSolve.TabIndex = 2;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = false;
            this.btnSolve.Click += new System.EventHandler(this.BtnSolve_Click);
            // 
            // listMoves
            // 
            this.listMoves.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listMoves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(255)))), ((int)(((byte)(216)))));
            this.listMoves.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMoves.FormattingEnabled = true;
            this.listMoves.ItemHeight = 18;
            this.listMoves.Location = new System.Drawing.Point(821, 38);
            this.listMoves.Name = "listMoves";
            this.listMoves.Size = new System.Drawing.Size(231, 400);
            this.listMoves.TabIndex = 4;
            // 
            // lblMoves
            // 
            this.lblMoves.AutoSize = true;
            this.lblMoves.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoves.Location = new System.Drawing.Point(818, 12);
            this.lblMoves.Name = "lblMoves";
            this.lblMoves.Size = new System.Drawing.Size(74, 21);
            this.lblMoves.TabIndex = 5;
            this.lblMoves.Text = "Moves :";
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.Location = new System.Drawing.Point(561, 13);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(226, 18);
            this.lblCounter.TabIndex = 6;
            this.lblCounter.Text = "Best solution in : {7} moves";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(15, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 400);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(659, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "Designed By : Hossein Gholizade and Mohammadreza Khodarahmi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1064, 483);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.lblMoves);
            this.Controls.Add(this.listMoves);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DiskCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tower of hanoi";
            ((System.ComponentModel.ISupportInitialize)(this.DiskCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown DiskCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.ListBox listMoves;
        private System.Windows.Forms.Label lblMoves;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}

