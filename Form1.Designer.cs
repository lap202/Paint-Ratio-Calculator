namespace Paint_Ratio_Calculator
{
    partial class frm_ratioCalculator
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
            this.btn_ratio_gloss = new System.Windows.Forms.Button();
            this.btn_ratio_semigloss = new System.Windows.Forms.Button();
            this.btn_ratio_flat = new System.Windows.Forms.Button();
            this.txt_paint = new System.Windows.Forms.TextBox();
            this.txt_hardener = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ratio_gloss
            // 
            this.btn_ratio_gloss.Location = new System.Drawing.Point(98, 43);
            this.btn_ratio_gloss.Name = "btn_ratio_gloss";
            this.btn_ratio_gloss.Size = new System.Drawing.Size(75, 23);
            this.btn_ratio_gloss.TabIndex = 0;
            this.btn_ratio_gloss.Text = "3.6:1";
            this.btn_ratio_gloss.UseVisualStyleBackColor = true;
            this.btn_ratio_gloss.Click += new System.EventHandler(this.btn_ratio_gloss_Click);
            // 
            // btn_ratio_semigloss
            // 
            this.btn_ratio_semigloss.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_ratio_semigloss.Location = new System.Drawing.Point(179, 43);
            this.btn_ratio_semigloss.Name = "btn_ratio_semigloss";
            this.btn_ratio_semigloss.Size = new System.Drawing.Size(75, 23);
            this.btn_ratio_semigloss.TabIndex = 1;
            this.btn_ratio_semigloss.Text = "4.6:1";
            this.btn_ratio_semigloss.UseVisualStyleBackColor = false;
            this.btn_ratio_semigloss.Click += new System.EventHandler(this.btn_ratio_semigloss_Click);
            // 
            // btn_ratio_flat
            // 
            this.btn_ratio_flat.Location = new System.Drawing.Point(259, 43);
            this.btn_ratio_flat.Name = "btn_ratio_flat";
            this.btn_ratio_flat.Size = new System.Drawing.Size(75, 23);
            this.btn_ratio_flat.TabIndex = 2;
            this.btn_ratio_flat.Text = "5.6:1";
            this.btn_ratio_flat.UseVisualStyleBackColor = true;
            this.btn_ratio_flat.Click += new System.EventHandler(this.btn_ratio_flat_Click);
            // 
            // txt_paint
            // 
            this.txt_paint.Location = new System.Drawing.Point(21, 107);
            this.txt_paint.MaxLength = 7;
            this.txt_paint.Name = "txt_paint";
            this.txt_paint.Size = new System.Drawing.Size(100, 20);
            this.txt_paint.TabIndex = 3;
            this.txt_paint.TextChanged += new System.EventHandler(this.txt_paint_TextChanged);
            // 
            // txt_hardener
            // 
            this.txt_hardener.Enabled = false;
            this.txt_hardener.Location = new System.Drawing.Point(127, 107);
            this.txt_hardener.Name = "txt_hardener";
            this.txt_hardener.Size = new System.Drawing.Size(100, 20);
            this.txt_hardener.TabIndex = 4;
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(233, 107);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 20);
            this.txt_total.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Paint (g)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hardener (g)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total (g)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gloss";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Semi-Gloss";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Flat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ratio";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(20, 130);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 13);
            this.lbl_error.TabIndex = 13;
            // 
            // frm_ratioCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 155);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_hardener);
            this.Controls.Add(this.txt_paint);
            this.Controls.Add(this.btn_ratio_flat);
            this.Controls.Add(this.btn_ratio_semigloss);
            this.Controls.Add(this.btn_ratio_gloss);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_ratioCalculator";
            this.Text = "Paint Ratio Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ratio_gloss;
        private System.Windows.Forms.Button btn_ratio_semigloss;
        private System.Windows.Forms.Button btn_ratio_flat;
        private System.Windows.Forms.TextBox txt_paint;
        private System.Windows.Forms.TextBox txt_hardener;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_error;
    }
}

