using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //取得列數
            int? rows = GetRows();
            //判斷列數必須大於零
            if (rows.HasValue == false)
            {
                MessageBox.Show("請輸入列數");
            }
            if (rows.Value < 0)
            {
                MessageBox.Show("列數必須大於零");
            }
            //生成星號三角形
            string stars = GenerateStars(rows.Value);
            //用textbox呈現
            Display(stars);
        }

        private void Display(string stars)
        {
            txtResult.Text = stars;
        }

        private string GenerateStars(int rows)
        {
            string result = string.Empty;
            for (int i = 1; i < rows; i++)
            {
                result += new string('*', i) + "\r\n";
            }
            return result;
        }
        private int? GetRows()
        {
            string input = txtRows.Text;
            bool isInt = int.TryParse(input, out int rows);
            if (isInt)
            {
                return rows;
            }
            else
            {
                return null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            int? rows = GetRows();
            
            if (rows.HasValue == false)
            {
                MessageBox.Show("請輸入列數");
            }
            if (rows.Value < 0)
            {
                MessageBox.Show("列數必須大於零");
            }
            //生成星號三角形
            string stars = GenerateStars2(rows.Value);
            //用textbox呈現
            Display(stars);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            int? rows = GetRows();
            
            if (rows.HasValue == false)
            {
                MessageBox.Show("請輸入列數");
            }
            if (rows.Value < 0)
            {
                MessageBox.Show("列數必須大於零");
            }
            //生成星號三角形
            string stars = GenerateStars3(rows.Value);
            //用textbox呈現
            Display(stars);
        }
        private string GenerateStars2(int rows)
        {
            string result = string.Empty;
            for (int i = 1; i < rows; i++)
            {
                int countOfEmpty = rows - i;
                int countOfStar = i * 2 - 1;
                result += new string(' ', countOfEmpty) + new string('*', countOfStar) + "\r\n";
            }
            return result;
        }
        private string GenerateStars3(int rows)
        {
            string result = string.Empty;
            for (int i = 1; i < rows; i++)
            {
                int countOfEmpty = rows - i;
                int countOfStar = i;
                result += new string(' ', countOfEmpty) + new string('*', countOfStar) + "\r\n";
            }
            return result;
        }
    }
    
}
