/*
 * Paint Ratio Calculator
 * Author: Drew Bach
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_Ratio_Calculator
{
    public partial class frm_ratioCalculator : Form
    {
        double ratio = 4.6;
        double paintAmount;

        public frm_ratioCalculator()
        {
            InitializeComponent();
        }

        private void calculateRatio()
        {
            if (txt_paint.Text == "")
            {
                txt_hardener.Text = "";
                txt_total.Text = "";
                lbl_error.Text = "";
            }
            else
            {
                if (double.TryParse(txt_paint.Text, out paintAmount))
                {
                    lbl_error.Text = "";
                    txt_hardener.Text = Math.Round((paintAmount / ratio), 2).ToString();
                    txt_total.Text = Math.Round(((paintAmount / ratio) + paintAmount), 2).ToString();
                }
                else
                {
                    lbl_error.Text = "Enter a valid paint weight";
                }
            }
        }

        private void btn_ratio_gloss_Click(object sender, EventArgs e)
        {
            ratio = 3.6;
            btn_ratio_gloss.BackColor = Color.LawnGreen;
            btn_ratio_flat.BackColor = SystemColors.Control;
            btn_ratio_semigloss.BackColor = SystemColors.Control;
            calculateRatio();
        }

        private void btn_ratio_semigloss_Click(object sender, EventArgs e)
        {
            ratio = 4.6;
            btn_ratio_semigloss.BackColor = Color.LawnGreen;
            btn_ratio_flat.BackColor = SystemColors.Control;
            btn_ratio_gloss.BackColor = SystemColors.Control;
            calculateRatio();
        }

        private void btn_ratio_flat_Click(object sender, EventArgs e)
        {
            ratio = 5.6;
            btn_ratio_flat.BackColor = Color.LawnGreen;
            btn_ratio_semigloss.BackColor = SystemColors.Control;
            btn_ratio_gloss.BackColor = SystemColors.Control;
            calculateRatio();
        }

        private void txt_paint_TextChanged(object sender, EventArgs e)
        {
            calculateRatio();
        }
    }
}
