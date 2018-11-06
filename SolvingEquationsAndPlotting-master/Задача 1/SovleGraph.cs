using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задача_1
{
    class SovleGraph
    {
        private double XMin;
        private double XMax;
        private List<double> Variables;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graphs;

        public SovleGraph(List<TextBox> TextBoxes, System.Windows.Forms.DataVisualization.Charting.Chart Graphs, TextBox x_min, TextBox x_max)
        {
            this.XMin = Convert.ToDouble(x_min.Text);
            this.XMax = Convert.ToDouble(x_max.Text);

            this.Graphs = Graphs;

            Variables = new List<double>();

            foreach (var TextBox in TextBoxes)
            {
                if (TextBox.Text != String.Empty) Variables.Add(Convert.ToDouble(TextBox.Text));
            }

        }
        public Complex DegreeEquation(Complex x)
        {
            Complex valueY = 0;

            for (int i = 0; i < Variables.Count(); i++)
            {
                valueY += Variables[i] * ComplexPow(x, i);
            }

            return valueY;
        }

        private Complex ComplexPow(Complex number, int degree)
        {
            var ValuePhi = Math.Atan2(number.Imaginary, number.Real);
            var ValueR = Math.Sqrt(Math.Pow(number.Real, 2) + Math.Pow(number.Imaginary, 2));
                ValueR = Math.Pow(ValueR, degree);
                ValuePhi = degree * ValuePhi;
            return new Complex(ValueR * Math.Cos(ValuePhi), ValueR * Math.Sin(ValuePhi));
        }

        public void CreateGraphics()
        {
            double Diapasone = XMax - XMin;

            double Step = Math.Abs(Diapasone / 10);

            // Количество точек графика
            int count = (int)Math.Ceiling((XMax - XMin) / Step) + 1;

            double[] x = new double[count];
            double[] y1 = new double[count];

            for (int i = 0; i < count; i++)
            {
                // Вычисляем значение X
                x[i] = XMin + Step * i;
                y1[i] = DegreeEquation(x[i]).Real;
            }

            // Настраиваем оси графика
            Graphs.ChartAreas[0].AxisX.Minimum = XMin;
            Graphs.ChartAreas[0].AxisX.Maximum = XMax;

            // Определяем шаг сетки
            Graphs.ChartAreas[0].AxisX.MajorGrid.Interval = Step;

            // Добавляем вычисленные значения в графики
            Graphs.Series[0].Points.DataBindXY(x, y1);
        }
    }
}
