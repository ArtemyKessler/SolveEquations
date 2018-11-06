using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows.Forms;

namespace Задача_1
{
    class SovleEQ
    {
        private List<Complex> AnswerTable;
        private List<double> Variables;

        public SovleEQ(List<TextBox> TextBoxes)
        {
            AnswerTable = new List<Complex>();

            Variables = new List<double>();

            foreach (var TextBox in TextBoxes)
            {
                if (TextBox.Text != String.Empty) Variables.Add(Convert.ToDouble(TextBox.Text));
            }

        }

        public List<Complex> EquationSolution()
        {
            switch (Variables.Count())
            {
                case 2:
                    FirstDegreeEquation();
                    break;
                case 3:
                    SecondDegreeEquation();
                    break;
                case 4:
                    ThirdDegreeEquation();
                    break;
                case 5:
                    FourthDegreeEquation();
                    break;
                case 6:
                    FifthDegreeEquation();
                    break;
            }

            return AnswerTable;
        }

        private void FirstDegreeEquation()
        {
            double answer = ((-1) * Variables[0]) / (Variables[1]);
            AnswerTable.Add(answer);
        }

        private void SecondDegreeEquation()
        {
            if ((Variables[1] * Variables[1] - 4 * Variables[2] * Variables[0]) >= 0)
            {
                double discRoot = Math.Sqrt(Variables[1] * Variables[1] - 4.0 * Variables[2] * Variables[0]);

                AnswerTable.Add(((-Variables[1] + discRoot) / (2 * Variables[2])));
                AnswerTable.Add(((-Variables[1] - discRoot) / (2 * Variables[2])));
            }
            else
            {
                Complex d = Variables[1] * Variables[1] - 4 * Variables[2] * Variables[0];
                var real = -Variables[1] / (2 * Variables[2]);
                var im = Complex.Sqrt(d) / (2 * Variables[2]);

                AnswerTable.Add(real + im);
                AnswerTable.Add(real - im);
            }
        }

        private void ThirdDegreeEquation()
        {
            this.Variables[2] = this.Variables[2] / this.Variables[3];
            this.Variables[1] = this.Variables[1] / this.Variables[3];
            Variables[0] = Variables[0] / this.Variables[3];

            var q = (Math.Pow(this.Variables[2], 2) - 3 * this.Variables[1]) / 9;
            var r = (2 * Math.Pow(this.Variables[2], 3) - 9 * this.Variables[2] * this.Variables[1] + 27 * Variables[0]) / 54;

            if (Math.Pow(r, 2) < Math.Pow(q, 3))
            {
                var t = Math.Acos(r / Math.Sqrt(Math.Pow(q, 3))) / 3;
                var x1 = -2 * Math.Sqrt(q) * Math.Cos(t) - this.Variables[2] / 3;
                var x2 = -2 * Math.Sqrt(q) * Math.Cos(t + (2 * Math.PI / 3)) - this.Variables[2] / 3;
                var x3 = -2 * Math.Sqrt(q) * Math.Cos(t - (2 * Math.PI / 3)) - this.Variables[2] / 3;

                AnswerTable.Add(x1);
                AnswerTable.Add(x2);
                AnswerTable.Add(x3);
            }
            else
            {
                var A = -Math.Sign(r) * Math.Pow(Math.Abs(r) + Math.Sqrt(Math.Pow(r, 2) - Math.Pow(q, 3)), (1.0 / 3.0));
                var B = (A == 0) ? 0.0 : q / A;

                var x1 = (A + B) - this.Variables[2] / 3;

                if (A == B)
                {
                    var x2 = -A - this.Variables[2] / 3;
                    AnswerTable.Add(x1);
                    AnswerTable.Add(x2);
                }
                else
                {
                    var x2 = -(A + B) / 2 - (this.Variables[2] / 3) + (Complex.ImaginaryOne * Math.Sqrt(3) * (A - B) / 2);
                    var x3 = -(A + B) / 2 - (this.Variables[2] / 3) - (Complex.ImaginaryOne * Math.Sqrt(3) * (A - B) / 2);

                    AnswerTable.Add(x1);
                    AnswerTable.Add(x2);
                    AnswerTable.Add(x3);
                }
            }
        }

        private void FourthDegreeEquation()
        {
            double p, q, r, b1, c1, d1, p1, q1, Q, del;
            this.Variables[3] = this.Variables[3] / this.Variables[4];
            this.Variables[2] = this.Variables[2] / this.Variables[4];
            this.Variables[1] = this.Variables[1] / this.Variables[4];
            Variables[0] = Variables[0] / this.Variables[4];
            this.Variables[4] = 1;

            p = (8 * this.Variables[2] - 3 * Math.Pow(this.Variables[3], 2)) / 8;
            q = (8 * this.Variables[1] + Math.Pow(this.Variables[3], 3) - 4 * this.Variables[3] * this.Variables[2]) / 8;
            r = (16 * Math.Pow(this.Variables[3], 2) * this.Variables[2] - 64 * this.Variables[3] * this.Variables[1] - 3 * Math.Pow(this.Variables[3], 4) + 256 * Variables[0]) / 256;
            b1 = 2 * p;
            c1 = Math.Pow(p, 2) - 4 * r;
            d1 = -Math.Pow(q, 2);
            p1 = (3 * c1 - Math.Pow(b1, 2)) / 3;
            q1 = (2 * Math.Pow(b1, 3) - 9 * b1 * c1 + 27 * d1) / 27;
            Q = Math.Pow(p1 / 3, 3) + Math.Pow(q1 / 2, 2);
            Complex QQ, U, V, e1, e2, x1, x2, x3, y1, y2, y3, y4, pp1 = 0, pp2 = 0, pp3 = 0, pp4 = 0;
            Complex z1, z2, z3, j;

            j = Complex.ImaginaryOne;
            if (Q < 0)
            {
                double x11, x22, x33;
                e1 = new Complex(-0.5, Math.Sqrt(3) / 2);
                e2 = Complex.Conjugate(e1);
                QQ = Complex.Sqrt(Q);
                del = q1 / 2;
                U = Complex.Pow(QQ - del, 1 / 3.0);
                V = Complex.Conjugate(U);
                z1 = U + V;
                z2 = e1 * U + e2 * V;
                z3 = e2 * U + e1 * V;
                x11 = z1.Real - b1 / 3;
                x22 = z2.Real - b1 / 3;
                x33 = z3.Real - b1 / 3;
                x1 = Complex.Sqrt(x11);
                x2 = Complex.Sqrt(x22);
                x3 = Complex.Sqrt(x33);
                if ((x1 * x2 * x3).Real < 0 | q < 0) { x1 = -x1; }
                if ((x1 * x2 * x3).Real > 0 | q > 0) { x1 = -x1; }
                y1 = 0.5 * (x1 + x2 + x3);
                y2 = 0.5 * (x1 - x2 - x3);
                y3 = 0.5 * (-x1 + x2 - x3);
                y4 = 0.5 * (-x1 - x2 + x3);
                pp1 = y1 - this.Variables[3] / 4;
                pp2 = y2 - this.Variables[3] / 4;
                pp3 = y3 - this.Variables[3] / 4;
                pp4 = y4 - this.Variables[3] / 4;
            }
            if (Q > 0)
            {
                Complex x11, x22, x33;
                U = -q1 / 2;
                V = Complex.Sqrt(Q);
                z1 = Complex.Pow(((U) + V), 1 / 3.0) + Complex.Pow((U - V), 1 / 3.0);
                z2 = -0.5 * (Complex.Pow((U + V), 1 / 3.0) + Complex.Pow((U - V), 1 / 3.0)) + j * Math.Sqrt(3) * 0.5 * (Complex.Pow((U + V), 0.3333333333333) - Complex.Pow((U - V), 0.3333333333333333));
                z3 = Complex.Conjugate(z2);
                x11 = z1 - b1 / 3;
                x22 = z2 - b1 / 3;
                x33 = z3 - b1 / 3;
                x1 = Complex.Sqrt(x11);
                x2 = Complex.Sqrt(x22);
                x3 = Complex.Sqrt(x33);
                if ((x1 * x2 * x3).Real < 0 | q < 0) { x1 = -x1; }
                if ((x1 * x2 * x3).Real > 0 | q > 0) { x1 = -x1; }
                y1 = 0.5 * (x1 + x2 + x3);
                y2 = 0.5 * (x1 - x2 - x3);
                y3 = 0.5 * (-x1 + x2 - x3);
                y4 = 0.5 * (-x1 - x2 + x3);
                pp1 = y1 - this.Variables[3] / 4;
                pp2 = y2 - this.Variables[3] / 4;
                pp3 = y3 - this.Variables[3] / 4;
                pp4 = y4 - this.Variables[3] / 4;
            }
            if (Q == 0)
            {
                double x11, x22, x33;
                z1 = -Math.Pow(-(q / 2), 1 / 3.0);
                z2 = 2 * Math.Pow(-(q / 2), 1 / 3.0);
                x11 = z1.Real - b1 / 3;
                x22 = z2.Real - b1 / 3;
                x33 = 0;
                x1 = Complex.Sqrt(x11);
                x2 = Complex.Sqrt(x22);
                x3 = Complex.Sqrt(x33);
                if ((x1 * x2 * x3).Real < 0 | q < 0) { x1 = -x1; }
                if ((x1 * x2 * x3).Real > 0 | q > 0) { x1 = -x1; }
                y1 = 0.5 * (x1 + x2 + x3);
                y2 = 0.5 * (x1 - x2 - x3);
                y3 = 0.5 * (-x1 + x2 - x3);
                y4 = 0.5 * (-x1 - x2 + x3);
                pp1 = y1 - this.Variables[3] / 4;
                pp2 = y2 - this.Variables[3] / 4;
                pp3 = y3 - this.Variables[3] / 4;
                pp4 = y4 - this.Variables[3] / 4;
            }
            AnswerTable.Add(pp1);
            AnswerTable.Add(pp2);
            AnswerTable.Add(pp3);
            AnswerTable.Add(pp4);
        }

        private void FifthDegreeEquation()
        {

        }
    }

}
