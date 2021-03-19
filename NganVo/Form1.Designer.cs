namespace NganVo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSoA = new System.Windows.Forms.TextBox();
            this.tbKQ = new System.Windows.Forms.TextBox();
            this.tbSoB = new System.Windows.Forms.TextBox();
            this.btKQ = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(33, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số A";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(33, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số B";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbSoA
            // 
            this.tbSoA.Location = new System.Drawing.Point(162, 45);
            this.tbSoA.Name = "tbSoA";
            this.tbSoA.Size = new System.Drawing.Size(143, 22);
            this.tbSoA.TabIndex = 3;
            // 
            // tbKQ
            // 
            this.tbKQ.Location = new System.Drawing.Point(162, 142);
            this.tbKQ.Name = "tbKQ";
            this.tbKQ.Size = new System.Drawing.Size(143, 22);
            this.tbKQ.TabIndex = 4;
            this.tbKQ.TextChanged += new System.EventHandler(this.tbKQ_TextChanged);
            // 
            // tbSoB
            // 
            this.tbSoB.Location = new System.Drawing.Point(162, 94);
            this.tbSoB.Name = "tbSoB";
            this.tbSoB.Size = new System.Drawing.Size(143, 22);
            this.tbSoB.TabIndex = 5;
            // 
            // btKQ
            // 
            this.btKQ.Location = new System.Drawing.Point(329, 210);
            this.btKQ.Name = "btKQ";
            this.btKQ.Size = new System.Drawing.Size(73, 29);
            this.btKQ.TabIndex = 6;
            this.btKQ.Text = "Cộng";
            this.btKQ.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(33, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kết quả";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btKQ);
            this.Controls.Add(this.tbSoB);
            this.Controls.Add(this.tbKQ);
            this.Controls.Add(this.tbSoA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSoA;
        private System.Windows.Forms.TextBox tbKQ;
        private System.Windows.Forms.TextBox tbSoB;
        private System.Windows.Forms.Button btKQ;
        private System.Windows.Forms.Label label3;
    }
}

