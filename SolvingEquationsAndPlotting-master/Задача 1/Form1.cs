using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Numerics;

namespace Задача_1
{
    public partial class Form1 : Form
    {
        private List<TextBox> TextBoxes;
        private List<Label> LabelBoxes;

        public Form1()
        {

            InitializeComponent();

            TextBoxes = new List<TextBox>
            {
                TextBox_0,
                TextBox_1,
                TextBox_2,
                TextBox_3,
                TextBox_4,
                TextBox_5
            };

            LabelBoxes = new List<Label>
            {
                LabelBox_0,
                LabelBox_1,
                LabelBox_2,
                LabelBox_3,
                LabelBox_4,
                LabelBox_5
            };
        }

        private void Degree_SelectedIndexChanged(object sender, EventArgs e)
        {

            for (int i = 1; i <= 5; i++)
            {
                TextBoxes[i].Visible = false;
                TextBoxes[i].ResetText();
                LabelBoxes[i].Visible = false;
            }

            for (int i = 0; i <= Convert.ToInt32(Degree.SelectedItem); i++)
            {
                TextBoxes[i].Visible = true;
                TextBoxes[i].ResetText();
                LabelBoxes[i].Visible = true;
            }
        }

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb == null) return;

            char pressedKey = e.KeyChar;
            if ((pressedKey <= 47 || pressedKey >= 58) && pressedKey != 8 && pressedKey != 44 && pressedKey != 46 && (tb.Text=="" && pressedKey !=45) && pressedKey !=13)
            {    
                e.Handled = true;
            }
            if (pressedKey == 44)
            {
                tb.Text.Replace(',', '.');
            }
        }

        private void WriteInTable(List<Complex> matrix)
        {
            SovleGraph Equation = new SovleGraph(TextBoxes, Grapths, X_min, X_max);

            dataGridView1.Rows.Clear();

            double xMax = 0;
            for (int i = 0; i < matrix.Count; i++)
            {


                dataGridView1.Rows.Add();
                
                if (matrix[i].Imaginary == 0)
                {
                    dataGridView1[0, i].Value = $"x_{i + 1} = {matrix[i].Real:0.#####}";
                    dataGridView1[1, i].Value = $"f(x{i+1}) = {Equation.DegreeEquation(matrix[i]).Real:0.#####}";

                    if (i == 0)
                    {
                        xMax = matrix[i].Real;
                    }
                    else
                    {
                        if (matrix[i].Real > xMax)
                        {
                            xMax = matrix[i].Real;
                        }
                    }
                }
                else
                {
                    dataGridView1[0, i].Value = $"x_{i + 1} = {matrix[i].Real:0.#####} + ({matrix[i].Imaginary:0.#####})*i";
                    dataGridView1[1, i].Value = $"f(x{ i + 1}) = {Equation.DegreeEquation(matrix[i])}";
                }
            }

            X_min.Text = Convert.ToString(xMax - 2.0);
            X_max.Text = Convert.ToString(xMax + 2.0);


        }

        private void Solve_Click(object sender, EventArgs e)
        {
            try
            {
                ErrorChecking();

                SovleEQ matrix = new SovleEQ(TextBoxes);
                WriteInTable(matrix.EquationSolution());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void Plot_Click(object sender, EventArgs e)
        {
            try
            {
                ErrorChecking();

                SovleGraph graph = new SovleGraph(TextBoxes, Grapths, X_min, X_max);

                graph.CreateGraphics();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void ErrorChecking()
        {
            if (LabelBoxes[0].Visible == false) throw new Exception("Не выбрано уравнение вида");

            int Count = 0;

            foreach (var TextBox in TextBoxes)
            {
                if (TextBox.Text != String.Empty) Count++;
            }

            if (Convert.ToInt32(Degree.SelectedItem) + 1 != Count) throw new Exception("Не все поля заполнены");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox_5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LabelBox_5_Click(object sender, EventArgs e)
        {

        }

        private void LabelBox_0_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_0_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelBox_1_Click(object sender, EventArgs e)
        {

        }

        private void LabelBox_2_Click(object sender, EventArgs e)
        {

        }

        private void LabelBox_3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_4_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelBox_4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
