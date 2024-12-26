namespace TicTacToe
{
    partial class TicTacToeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn00 = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chkSinglePlayer = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.chkSinglePlayer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btn22);
            this.panel1.Controls.Add(this.btn21);
            this.panel1.Controls.Add(this.btn20);
            this.panel1.Controls.Add(this.btn12);
            this.panel1.Controls.Add(this.btn11);
            this.panel1.Controls.Add(this.btn10);
            this.panel1.Controls.Add(this.btn02);
            this.panel1.Controls.Add(this.btn01);
            this.panel1.Controls.Add(this.btn00);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 672);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tic Tac Toe";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 650);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(74, 17);
            this.toolStripStatusLabel1.Text = "Bax Creation";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.BackColor = System.Drawing.Color.LightGray;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(248, 590);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 35);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.BackColor = System.Drawing.Color.LightGray;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(415, 590);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(111, 35);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btn22
            // 
            this.btn22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn22.Location = new System.Drawing.Point(477, 418);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(150, 150);
            this.btn22.TabIndex = 9;
            this.btn22.UseVisualStyleBackColor = true;
            this.btn22.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn21
            // 
            this.btn21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn21.Location = new System.Drawing.Point(312, 418);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(150, 150);
            this.btn21.TabIndex = 8;
            this.btn21.UseVisualStyleBackColor = true;
            this.btn21.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn20
            // 
            this.btn20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn20.Location = new System.Drawing.Point(147, 418);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(150, 150);
            this.btn20.TabIndex = 7;
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn12
            // 
            this.btn12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn12.Location = new System.Drawing.Point(477, 253);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(150, 150);
            this.btn12.TabIndex = 6;
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn11
            // 
            this.btn11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn11.Location = new System.Drawing.Point(312, 253);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(150, 150);
            this.btn11.TabIndex = 5;
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn10
            // 
            this.btn10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn10.Location = new System.Drawing.Point(147, 253);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(150, 150);
            this.btn10.TabIndex = 4;
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn02
            // 
            this.btn02.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn02.Location = new System.Drawing.Point(477, 88);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(150, 150);
            this.btn02.TabIndex = 3;
            this.btn02.UseVisualStyleBackColor = true;
            this.btn02.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn01
            // 
            this.btn01.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn01.Location = new System.Drawing.Point(312, 88);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(150, 150);
            this.btn01.TabIndex = 2;
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn00
            // 
            this.btn00.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn00.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn00.Location = new System.Drawing.Point(147, 88);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(150, 150);
            this.btn00.TabIndex = 1;
            this.btn00.UseVisualStyleBackColor = true;
            this.btn00.Click += new System.EventHandler(this.Button_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.IndianRed;
            this.lblStatus.Location = new System.Drawing.Point(306, 51);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(156, 25);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Player X Turn";
            // 
            // chkSinglePlayer
            // 
            this.chkSinglePlayer.AutoSize = true;
            this.chkSinglePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSinglePlayer.Location = new System.Drawing.Point(531, 59);
            this.chkSinglePlayer.Name = "chkSinglePlayer";
            this.chkSinglePlayer.Size = new System.Drawing.Size(96, 17);
            this.chkSinglePlayer.TabIndex = 14;
            this.chkSinglePlayer.Text = "SinglePlayer";
            this.chkSinglePlayer.UseVisualStyleBackColor = true;
            // 
            // TicTacToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 672);
            this.Controls.Add(this.panel1);
            this.Name = "TicTacToeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkSinglePlayer;
    }
}

