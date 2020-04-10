using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

//Дану для файлу

//0 1 2 3 4 5
//2 10 27 32 23 6

//0 1 2 3 4 5
//9 15 20 35 15 6

namespace MathStatisticsPirsonWindowsForms
{
    public partial class Form1 : Form
    {
        private List<int> Xi = new List<int>();
        private List<int> Ni = new List<int>();

        public Form1()
        {
            InitializeComponent();
            ReadFromFile();
            ToCheckHypothesis();
        }

        public void ReadFromFile()
        {
            string[] lines = File.ReadAllLines("../../read.txt");
            Xi = lines[0].Split(' ').Select(s => Convert.ToInt32(s)).ToList();
            Ni = lines[1].Split(' ').Select(s => Convert.ToInt32(s)).ToList();
        }

        public void FillData(List<int> c1, List<int> c2, List<double> probabilities)
        {
            for (int i = 0; i < c1.Count; i++)
            {
                dataGridView1.Rows.Add(c1[i], c2[i], probabilities[i]);
            }
        }
        
        public void FillData2(List<int> n, List<double> np)
        {
            for (int i = 0; i < n.Count; i++)
            {
                dataGridView2.Rows.Add(n[i], np[i]);
            }
        }

        public double FindXemp(List<int> ni, List<double> probabilities)
        {
            int n = Volume(ni);
            double res = 0;
            for (int i = 0; i < probabilities.Count; i++)
            {
                res += (Math.Pow(ni[i] - n * probabilities[i], 2)) / (n * probabilities[i]);
            }
            return res;
        }

        public int Volume(List<int> Ni)
        {
            int res = 0;
            for (int i = 0; i < Ni.Count; i++)
            {
                res += Ni[i];
            }
            return res;
        }

        public double Average(List<int> Xi, List<int> Ni)
        {
            double res = 0;
            for (int i = 0; i < Ni.Count; i++)
            {
                res += Xi[i] * Ni[i];
            }

            res = res / Volume(Ni);
            return res;
        }

        public List<double> FindProbabilities(int count, double num)
        {
            List<double> result = new List<double>();
            for (int i = 0; i < count; i++)
            {
                double propabil = Bernuli(i, count - 1, num);
                result.Add(propabil);
            }
            return result;
        }

        public int Factorial(double num)
        {
            int n = 1;
            for (int i = 1; i <= num; ++i)
            {
                n = n * i;
            }
            return n;
        }

        public double Bernuli(int k, int max, double p)
        {
            double q = 1 - p;
            double probabil = ((Factorial(max) / Factorial(max - k)) / Factorial(k)) * Math.Pow(p, k) * Math.Pow(q, max - k);
            return probabil;
        }

        public void ToCheckHypothesis()
        {
            int df = Xi.Count - 1;

            double alpha = 0.05;
            if (alphaTextBox.Text != String.Empty)
            {
                alpha = Convert.ToDouble(alphaTextBox.Text);
            }
            alphaTextBox.Text = alpha.ToString();

            double p;
            if (pTextBox.Text != String.Empty)
            {
                p = Convert.ToDouble(pTextBox.Text);
                label1.Text = "Параметр задано";
            }
            else
            {
                p = Average(Xi, Ni) / Xi.Max();
                pTextBox.Text = Math.Round(p, 3).ToString();
                df--;
                label1.Text = "Параметр вирахувано\n в програмі";
            }
            List<double> probabilities = FindProbabilities(Xi.Count, p);
            FillData(Xi, Ni, probabilities);

            int count = 0;
            while (ToGroup(Ni, probabilities))
            {
                ++count;
            }
            FillData2(Ni, probabilities);
            double xEmp = FindXemp(Ni, probabilities);
            xEmpTextBox.Text = Math.Round(xEmp, 3).ToString();

            df -= count;
            dfTextBox.Text = df.ToString();
            double xCrit = Math.Round(MathNet.Numerics.Distributions.ChiSquared.InvCDF(df, 1 - alpha), 3);
            xCritTextBox.Text = xCrit.ToString();

            if (xCrit < xEmp)
            {
                label2.Text = "Xcrit < Xemp";
                resultTextBox.Text = "Відхиляємо";
            }
            else
            {
                label2.Text = "Xcrit > Xemp";
                resultTextBox.Text = "Приймаємо";
            }

        }

        public bool ToGroup(List<int> Ni, List<double> p)
        {
            bool result = false;
            int n = Volume(Ni);
            for (int i = 0; i < Ni.Count; i++)
            {
                if (Ni[i] < 5 || n * p[i] < 10)
                {
                    result = true;
                    if (i == Ni.Count - 1)
                    {
                        Ni[i - 1] = Ni[i - 1] + Ni[i];
                        Ni.RemoveAt(i);
                        p[i - 1] = p[i - 1] + p[i];
                        p.RemoveAt(i);
                        break;
                    }
                    else
                    {
                        Ni[i + 1] = Ni[i + 1] + Ni[i];
                        Ni.RemoveAt(i);
                        p[i + 1] = p[i + 1] + p[i];
                        p.RemoveAt(i);
                        break;
                    }
                }
            }
            return result;
        }

        private void randomButtom_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            ReadFromFile();
            ToCheckHypothesis();
        }
    }
}
