namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gl = new System.Windows.Forms.Button();
            this.gs = new System.Windows.Forms.Button();
            this.gp = new System.Windows.Forms.Button();
            this.sl = new System.Windows.Forms.Button();
            this.ss = new System.Windows.Forms.Button();
            this.sp = new System.Windows.Forms.Button();
            this.dl = new System.Windows.Forms.Button();
            this.ds = new System.Windows.Forms.Button();
            this.dp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.currentPlayerLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.Controls.Add(this.gl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gs, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gp, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.sl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ss, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.sp, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ds, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dp, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(68, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(330, 287);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gl
            // 
            this.gl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gl.Location = new System.Drawing.Point(3, 3);
            this.gl.Name = "gl";
            this.gl.Size = new System.Drawing.Size(105, 92);
            this.gl.TabIndex = 0;
            this.gl.UseVisualStyleBackColor = true;
            this.gl.Click += new System.EventHandler(this.Mark);
            // 
            // gs
            // 
            this.gs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gs.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gs.Location = new System.Drawing.Point(114, 3);
            this.gs.Name = "gs";
            this.gs.Size = new System.Drawing.Size(105, 92);
            this.gs.TabIndex = 1;
            this.gs.UseVisualStyleBackColor = true;
            this.gs.Click += new System.EventHandler(this.Mark);
            // 
            // gp
            // 
            this.gp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gp.Location = new System.Drawing.Point(225, 3);
            this.gp.Name = "gp";
            this.gp.Size = new System.Drawing.Size(102, 92);
            this.gp.TabIndex = 2;
            this.gp.UseVisualStyleBackColor = true;
            this.gp.Click += new System.EventHandler(this.Mark);
            // 
            // sl
            // 
            this.sl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sl.Location = new System.Drawing.Point(3, 101);
            this.sl.Name = "sl";
            this.sl.Size = new System.Drawing.Size(105, 92);
            this.sl.TabIndex = 3;
            this.sl.UseVisualStyleBackColor = true;
            this.sl.Click += new System.EventHandler(this.Mark);
            // 
            // ss
            // 
            this.ss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ss.Location = new System.Drawing.Point(114, 101);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(105, 92);
            this.ss.TabIndex = 4;
            this.ss.UseVisualStyleBackColor = true;
            this.ss.Click += new System.EventHandler(this.Mark);
            // 
            // sp
            // 
            this.sp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sp.Location = new System.Drawing.Point(225, 101);
            this.sp.Name = "sp";
            this.sp.Size = new System.Drawing.Size(102, 92);
            this.sp.TabIndex = 5;
            this.sp.UseVisualStyleBackColor = true;
            this.sp.Click += new System.EventHandler(this.Mark);
            // 
            // dl
            // 
            this.dl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dl.Location = new System.Drawing.Point(3, 199);
            this.dl.Name = "dl";
            this.dl.Size = new System.Drawing.Size(105, 85);
            this.dl.TabIndex = 6;
            this.dl.UseVisualStyleBackColor = true;
            this.dl.Click += new System.EventHandler(this.Mark);
            // 
            // ds
            // 
            this.ds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ds.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ds.Location = new System.Drawing.Point(114, 199);
            this.ds.Name = "ds";
            this.ds.Size = new System.Drawing.Size(105, 85);
            this.ds.TabIndex = 7;
            this.ds.UseVisualStyleBackColor = true;
            this.ds.Click += new System.EventHandler(this.Mark);
            // 
            // dp
            // 
            this.dp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dp.Location = new System.Drawing.Point(225, 199);
            this.dp.Name = "dp";
            this.dp.Size = new System.Drawing.Size(102, 85);
            this.dp.TabIndex = 8;
            this.dp.UseVisualStyleBackColor = true;
            this.dp.Click += new System.EventHandler(this.Mark);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aktualny ruch:";
            // 
            // currentPlayerLabel
            // 
            this.currentPlayerLabel.AutoSize = true;
            this.currentPlayerLabel.Location = new System.Drawing.Point(170, 354);
            this.currentPlayerLabel.Name = "currentPlayerLabel";
            this.currentPlayerLabel.Size = new System.Drawing.Size(0, 15);
            this.currentPlayerLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 378);
            this.Controls.Add(this.currentPlayerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button gl;
        private Button gs;
        private Button gp;
        private Button sl;
        private Button ss;
        private Button sp;
        private Button dl;
        private Button ds;
        private Button dp;
        private Label label1;
        private Label currentPlayerLabel;
    }
}