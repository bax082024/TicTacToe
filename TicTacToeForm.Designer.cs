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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
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
            this.panel1.Size = new System.Drawing.Size(800, 674);
            this.panel1.TabIndex = 0;
            // 
            // btn22
            // 
            this.btn22.Location = new System.Drawing.Point(482, 446);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(150, 150);
            this.btn22.TabIndex = 9;
            this.btn22.UseVisualStyleBackColor = true;
            // 
            // btn21
            // 
            this.btn21.Location = new System.Drawing.Point(317, 446);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(150, 150);
            this.btn21.TabIndex = 8;
            this.btn21.UseVisualStyleBackColor = true;
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(152, 446);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(150, 150);
            this.btn20.TabIndex = 7;
            this.btn20.UseVisualStyleBackColor = true;
            // 
            // btn12
            // 
            this.btn12.Location = new System.Drawing.Point(482, 281);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(150, 150);
            this.btn12.TabIndex = 6;
            this.btn12.UseVisualStyleBackColor = true;
            // 
            // btn11
            // 
            this.btn11.Location = new System.Drawing.Point(317, 281);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(150, 150);
            this.btn11.TabIndex = 5;
            this.btn11.UseVisualStyleBackColor = true;
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(152, 281);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(150, 150);
            this.btn10.TabIndex = 4;
            this.btn10.UseVisualStyleBackColor = true;
            // 
            // btn02
            // 
            this.btn02.Location = new System.Drawing.Point(482, 116);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(150, 150);
            this.btn02.TabIndex = 3;
            this.btn02.UseVisualStyleBackColor = true;
            // 
            // btn01
            // 
            this.btn01.Location = new System.Drawing.Point(317, 116);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(150, 150);
            this.btn01.TabIndex = 2;
            this.btn01.UseVisualStyleBackColor = true;
            // 
            // btn00
            // 
            this.btn00.Location = new System.Drawing.Point(152, 116);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(150, 150);
            this.btn00.TabIndex = 1;
            this.btn00.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(329, 34);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(116, 20);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Player X Turn";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightGray;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(334, 627);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(111, 35);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // TicTacToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 674);
            this.Controls.Add(this.panel1);
            this.Name = "TicTacToeForm";
            this.Text = "Tic Tac Toe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}

