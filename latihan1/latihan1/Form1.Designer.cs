namespace latihan1
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
            this.Lock_B = new System.Windows.Forms.Button();
            this.IFF_B = new System.Windows.Forms.Button();
            this.Radar_B = new System.Windows.Forms.Button();
            this.friendly_L = new System.Windows.Forms.Label();
            this.hostile_L = new System.Windows.Forms.Label();
            this.LNCH_L = new System.Windows.Forms.Button();
            this.HR_L = new System.Windows.Forms.Button();
            this.RadarDisp = new System.Windows.Forms.Button();
            this.TDC_T = new System.Windows.Forms.Label();
            this.TDC_B = new System.Windows.Forms.Label();
            this.ChaseHorR = new System.Windows.Forms.Label();
            this.ChaseHorL = new System.Windows.Forms.Label();
            this.ChaseRangeL = new System.Windows.Forms.Label();
            this.ChaseRangeR = new System.Windows.Forms.Label();
            this.Break_L = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lock_B
            // 
            this.Lock_B.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Lock_B.Location = new System.Drawing.Point(160, 311);
            this.Lock_B.Name = "Lock_B";
            this.Lock_B.Size = new System.Drawing.Size(75, 23);
            this.Lock_B.TabIndex = 0;
            this.Lock_B.Text = "Lock on";
            this.Lock_B.UseVisualStyleBackColor = true;
            this.Lock_B.Click += new System.EventHandler(this.button1_Click);
            // 
            // IFF_B
            // 
            this.IFF_B.Cursor = System.Windows.Forms.Cursors.Cross;
            this.IFF_B.Location = new System.Drawing.Point(79, 311);
            this.IFF_B.Name = "IFF_B";
            this.IFF_B.Size = new System.Drawing.Size(75, 23);
            this.IFF_B.TabIndex = 12;
            this.IFF_B.Text = "IFF";
            this.IFF_B.UseVisualStyleBackColor = true;
            this.IFF_B.Click += new System.EventHandler(this.iff_B_Click);
            // 
            // Radar_B
            // 
            this.Radar_B.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Radar_B.Location = new System.Drawing.Point(241, 311);
            this.Radar_B.Name = "Radar_B";
            this.Radar_B.Size = new System.Drawing.Size(75, 23);
            this.Radar_B.TabIndex = 13;
            this.Radar_B.Text = "Radar On";
            this.Radar_B.UseVisualStyleBackColor = true;
            this.Radar_B.Click += new System.EventHandler(this.radarOn_B_Click_1);
            // 
            // friendly_L
            // 
            this.friendly_L.AutoSize = true;
            this.friendly_L.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.friendly_L.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01-L2 Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendly_L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.friendly_L.Location = new System.Drawing.Point(154, 194);
            this.friendly_L.Name = "friendly_L";
            this.friendly_L.Size = new System.Drawing.Size(16, 16);
            this.friendly_L.TabIndex = 14;
            this.friendly_L.Text = "┼";
            // 
            // hostile_L
            // 
            this.hostile_L.AutoSize = true;
            this.hostile_L.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.hostile_L.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01-L2 Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostile_L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.hostile_L.Location = new System.Drawing.Point(203, 160);
            this.hostile_L.Name = "hostile_L";
            this.hostile_L.Size = new System.Drawing.Size(16, 16);
            this.hostile_L.TabIndex = 15;
            this.hostile_L.Text = "┴";
            // 
            // LNCH_L
            // 
            this.LNCH_L.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(86)))), ((int)(((byte)(65)))));
            this.LNCH_L.Cursor = System.Windows.Forms.Cursors.No;
            this.LNCH_L.Enabled = false;
            this.LNCH_L.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01-L2 Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNCH_L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.LNCH_L.Location = new System.Drawing.Point(43, 98);
            this.LNCH_L.Name = "LNCH_L";
            this.LNCH_L.Size = new System.Drawing.Size(30, 83);
            this.LNCH_L.TabIndex = 16;
            this.LNCH_L.Text = "L\r\nN\r\nC\r\nH";
            this.LNCH_L.UseVisualStyleBackColor = false;
            // 
            // HR_L
            // 
            this.HR_L.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(86)))), ((int)(((byte)(65)))));
            this.HR_L.Cursor = System.Windows.Forms.Cursors.No;
            this.HR_L.Enabled = false;
            this.HR_L.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01-L2 Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HR_L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.HR_L.Location = new System.Drawing.Point(43, 187);
            this.HR_L.Name = "HR_L";
            this.HR_L.Size = new System.Drawing.Size(30, 83);
            this.HR_L.TabIndex = 17;
            this.HR_L.Text = "H\r\nR";
            this.HR_L.UseVisualStyleBackColor = false;
            // 
            // RadarDisp
            // 
            this.RadarDisp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.RadarDisp.Cursor = System.Windows.Forms.Cursors.No;
            this.RadarDisp.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01-L2 Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadarDisp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(86)))), ((int)(((byte)(65)))));
            this.RadarDisp.Location = new System.Drawing.Point(79, 29);
            this.RadarDisp.Name = "RadarDisp";
            this.RadarDisp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RadarDisp.Size = new System.Drawing.Size(275, 241);
            this.RadarDisp.TabIndex = 18;
            this.RadarDisp.Text = resources.GetString("RadarDisp.Text");
            this.RadarDisp.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RadarDisp.UseVisualStyleBackColor = false;
            // 
            // TDC_T
            // 
            this.TDC_T.AutoSize = true;
            this.TDC_T.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.TDC_T.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01-L2 Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDC_T.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.TDC_T.Location = new System.Drawing.Point(200, 144);
            this.TDC_T.Name = "TDC_T";
            this.TDC_T.Size = new System.Drawing.Size(23, 16);
            this.TDC_T.TabIndex = 19;
            this.TDC_T.Text = "──";
            this.TDC_T.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TDC_B
            // 
            this.TDC_B.AutoSize = true;
            this.TDC_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.TDC_B.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01-L2 Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDC_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.TDC_B.Location = new System.Drawing.Point(200, 176);
            this.TDC_B.Name = "TDC_B";
            this.TDC_B.Size = new System.Drawing.Size(23, 16);
            this.TDC_B.TabIndex = 20;
            this.TDC_B.Text = "──";
            this.TDC_B.Click += new System.EventHandler(this.TDC_B_Click);
            // 
            // ChaseHorR
            // 
            this.ChaseHorR.AutoSize = true;
            this.ChaseHorR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ChaseHorR.Cursor = System.Windows.Forms.Cursors.No;
            this.ChaseHorR.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01-L2 Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChaseHorR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ChaseHorR.Location = new System.Drawing.Point(229, 161);
            this.ChaseHorR.Name = "ChaseHorR";
            this.ChaseHorR.Size = new System.Drawing.Size(95, 16);
            this.ChaseHorR.TabIndex = 22;
            this.ChaseHorR.Text = "───────────";
            // 
            // ChaseHorL
            // 
            this.ChaseHorL.AutoSize = true;
            this.ChaseHorL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ChaseHorL.Cursor = System.Windows.Forms.Cursors.No;
            this.ChaseHorL.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01-L2 Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChaseHorL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ChaseHorL.Location = new System.Drawing.Point(104, 161);
            this.ChaseHorL.Name = "ChaseHorL";
            this.ChaseHorL.Size = new System.Drawing.Size(87, 16);
            this.ChaseHorL.TabIndex = 23;
            this.ChaseHorL.Text = "──────────";
            // 
            // ChaseRangeL
            // 
            this.ChaseRangeL.AutoSize = true;
            this.ChaseRangeL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ChaseRangeL.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01-L2 Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChaseRangeL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ChaseRangeL.Location = new System.Drawing.Point(115, 151);
            this.ChaseRangeL.Name = "ChaseRangeL";
            this.ChaseRangeL.Size = new System.Drawing.Size(15, 16);
            this.ChaseRangeL.TabIndex = 24;
            this.ChaseRangeL.Text = "│";
            // 
            // ChaseRangeR
            // 
            this.ChaseRangeR.AutoSize = true;
            this.ChaseRangeR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ChaseRangeR.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01-L2 Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChaseRangeR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ChaseRangeR.Location = new System.Drawing.Point(299, 151);
            this.ChaseRangeR.Name = "ChaseRangeR";
            this.ChaseRangeR.Size = new System.Drawing.Size(15, 16);
            this.ChaseRangeR.TabIndex = 25;
            this.ChaseRangeR.Text = "│";
            // 
            // Break_L
            // 
            this.Break_L.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(86)))), ((int)(((byte)(65)))));
            this.Break_L.Cursor = System.Windows.Forms.Cursors.No;
            this.Break_L.Enabled = false;
            this.Break_L.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01-L2 Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Break_L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Break_L.Location = new System.Drawing.Point(79, 276);
            this.Break_L.Name = "Break_L";
            this.Break_L.Size = new System.Drawing.Size(77, 25);
            this.Break_L.TabIndex = 26;
            this.Break_L.Text = "BREAK";
            this.Break_L.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(193)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.Break_L);
            this.Controls.Add(this.ChaseRangeR);
            this.Controls.Add(this.ChaseRangeL);
            this.Controls.Add(this.ChaseHorL);
            this.Controls.Add(this.ChaseHorR);
            this.Controls.Add(this.TDC_B);
            this.Controls.Add(this.TDC_T);
            this.Controls.Add(this.friendly_L);
            this.Controls.Add(this.hostile_L);
            this.Controls.Add(this.RadarDisp);
            this.Controls.Add(this.HR_L);
            this.Controls.Add(this.LNCH_L);
            this.Controls.Add(this.Radar_B);
            this.Controls.Add(this.IFF_B);
            this.Controls.Add(this.Lock_B);
            this.Name = "Form1";
            this.Text = "RP-22 Sapfir Radar Sim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Lock_B;
        private System.Windows.Forms.Button IFF_B;
        private System.Windows.Forms.Button Radar_B;
        private System.Windows.Forms.Label friendly_L;
        private System.Windows.Forms.Label hostile_L;
        private System.Windows.Forms.Button LNCH_L;
        private System.Windows.Forms.Button HR_L;
        private System.Windows.Forms.Button RadarDisp;
        private System.Windows.Forms.Label TDC_T;
        private System.Windows.Forms.Label TDC_B;
        private System.Windows.Forms.Label ChaseHorL;
        private System.Windows.Forms.Label ChaseRangeL;
        private System.Windows.Forms.Label ChaseRangeR;
        private System.Windows.Forms.Label ChaseHorR;
        private System.Windows.Forms.Button Break_L;
    }
}

