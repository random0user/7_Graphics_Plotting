using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ZedGraph;

namespace Lab3Gauss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ChartSetup();
        }

        double RightBorder, LeftBorder, Step;
        int NodesQuantity, AmountOfPoints;
        PointPairList IntegralList = new PointPairList();
        string Datafile = "..\\..\\datafile.txt";

        

        //Вычисление значения функции по точкам.
        public double Calculate(double x)
        {
            return (Math.Exp(-x)*Math.Sin(x)*x + x);
        }


        //ExtraLagr
        private double NLagrange(PointPairList listDots, int degree, double x)//Полином в форме Лагранжа
        {
            double result = 0;
            for(int i = 0; i<=degree; i++)
            {
                double multi = 1;
                for(int j=0; j <= degree ;j++)
                {
                    if (j != i)
                        multi *= (x - listDots[j].X) / (listDots[i].X - listDots[j].X);
                    else
                        continue;
                }
                result += listDots[i].Y*multi;
            }
            return result;
        }
        

        public double Integrate(int NodesQuantity, double a, double b)
        {
            double Value = 0, t = 0, W = 0;
            double C = (b - a) / 2.0;
            double D = (b + a) / 2.0;

            PointPairList n_list = new PointPairList();
            double x = a, st=0;

            switch (NodesQuantity)
            {
                case 2:

                    st = (b-a) / 3.0;
                    for (int i = 0; i < 4; i++)
                    {
                        n_list.Add(a + st * i, Calculate(a + st * i));
                    }
                   
                    n_list.Sort();

                    W = 1.0;
                    t = 0.577350269;
                    

                    W = 1.0;
                    t = 0.577350269;
                    Value += NLagrange(n_list, 3, D + C * t)*W;
                    Value += NLagrange(n_list, 3, D - C * t)*W;
                    break;

                case 3:
                    st = (b - a) / 5.0;
                    for(int i=0; i<6; i++)
                    {
                        n_list.Add(a+st*i, Calculate(a+st*i));
                    }
                    W = 0.555555556;
                    t = 0.774596669;

                    Value += NLagrange(n_list, 5, D + C * t) * W;
                    Value += NLagrange(n_list, 5, D - C * t) * W;
                    Value += NLagrange(n_list, 5, D - C * 0) * 0.88888888889;
                    break;
                case 4:

                    st = (b - a) / 7.0;
                    for (int i = 0; i < 8; i++)
                    {
                        n_list.Add(a + st * i, Calculate(a + st * i));
                    }
                    n_list.Sort();

                    W = 0.652145155;
                    t = 0.339981044;
                    Value += NLagrange(n_list, 7, D + C * t) * W;
                    Value += NLagrange(n_list, 7, D - C * t) * W;
                   
                    W = 0.347854845;
                    t = 0.861136312;
                    Value += NLagrange(n_list, 7, D + C * t) * W;
                    Value += NLagrange(n_list, 7, D - C * t) * W;
       
                    break;
                 
            }
            return Value * C;
        }

        private void tofile_Click(object sender, EventArgs e)
        {
            try
            {
                RightBorder = Convert.ToDouble(RightBorderText.Text);
                LeftBorder = Convert.ToDouble(LeftBorderText.Text);
                if (RightBorder <= LeftBorder)
                    throw new Exception("Граница справа должна быть больше границы слева");
                AmountOfPoints = Convert.ToInt32(AmountOfPointsText.Text);
                if (AmountOfPoints > 10000)
                    AmountOfPoints = 10000;
                Step = Math.Round((RightBorder - LeftBorder) / (AmountOfPoints - 1), 15, MidpointRounding.AwayFromZero);
                if (AmountOfPoints < 2)
                    throw new Exception("Нужно больше, чем 2 точки");
                StreamWriter Out = new StreamWriter(Datafile);
                double x = LeftBorder;
                for (int i = 1; i < AmountOfPoints; i++)
                {
                    Out.WriteLine(x + " " + Calculate(x));
                    x += Step;
                }
                Out.WriteLine(RightBorder + " " + Calculate(RightBorder));
                Out.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод данных");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка");
            }
        }

        private void plot_Click(object sender, EventArgs e)
        {
        try{
            IntegralList.Clear();
            GraphPane pane = zedGraphControl1.GraphPane;
            pane.XAxis.Scale.MinAuto = true;
            pane.XAxis.Scale.MaxAuto = true;
            pane.YAxis.Scale.MinAuto = true;
            pane.YAxis.Scale.MaxAuto = true;
            pane.CurveList.Clear();
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            int n = 0;
                if (Nodes_2.Checked)
                    NodesQuantity = 2;
                else if (Nodes_3.Checked)
                    NodesQuantity = 3;
                else if (Nodes_4.Checked)
                    NodesQuantity = 4;
            StreamReader IN = new StreamReader(Datafile);
            string FileData = IN.ReadToEnd();
            IN.Close();
            string[] OrderData = FileData.Split(' ', '\n');
            n = 0;
            for (int i = 0; i < OrderData.Length - 1; i += 2)
            {
                n++;
                IntegralList.Add(double.Parse(OrderData[i]), double.Parse(OrderData[i + 1]));
            }
            if (n < 2)
            {
                throw new ApplicationException("Степень интерполяции должна быть меньше количества точек.");
            }
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (IntegralList[i].X == IntegralList[j].X && IntegralList[i].Y != IntegralList[j].Y)
                    throw new ApplicationException("Зависимость многозначна");
                }
            }
            IntegralList.TrimExcess();
            IntegralList.Sort();


            Plot_Lagrange(NodesQuantity, IntegralList, pane);


            LineItem curve1 = pane.AddCurve("y(x)", IntegralList, Color.Black, SymbolType.None);
            curve1.Line.Width = 3;
            curve1.Line.Fill = new ZedGraph.Fill(Color.CadetBlue, Color.Blue, Color.LightSkyBlue, 0);
            pane.XAxis.Scale.Min = IntegralList[0].X;
            pane.XAxis.Scale.Max = IntegralList[IntegralList.Count - 1].X;
            pane.XAxis.Scale.BaseTic = IntegralList[0].X;
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            RightBorder = IntegralList[IntegralList.Count - 1].X;
            LeftBorder = IntegralList[0].X;
                double epsilon = 0.001, Iold = 0, Inew = 0;
           //     textBox1.Text = string.Format((0).ToString());
            Iold = Integrate(NodesQuantity, LeftBorder, RightBorder);
                double IntervalLength = Math.Abs(RightBorder - LeftBorder);
                for (int i = 2; i <= 512; i+=2)
                { 
                    Inew = 0;
                    double step = Math.Abs(IntervalLength / i);
                    for (int j = 0; j < i; j++)
                    {
                        Inew += Integrate(NodesQuantity, LeftBorder+j*step, LeftBorder + (1+j)*step);
                    }
                    if (Math.Abs((Inew - Iold) / Inew) < epsilon)
                    {
                        Inew = Iold;
                        textBox1.Text = string.Format(((int)i / 2).ToString());
                        break;
                    }
                    else
                        Iold = Inew;
                    
                }
                //IntegralValueText.Text = string.Format("{0:F6}", IntegralCalculate(IntegralList, AmountOfNodes));
                //IntegralValueText.Text = string.Format("{0:F6}", IntegralCircle(IntegralList, AmountOfNodes, LeftBorder, RightBorder));
                //IntegralValueText.Text = string.Format("{0:F6}", IntegralCalculate(LagrList,4));
#pragma warning disable CS1718 // Выполнено сравнение с той же переменной
                if (Iold != Iold)
#pragma warning restore CS1718 // Выполнено сравнение с той же переменной
                    IntegralValueText.Text = string.Format("{0:F6}", "Выход за пределы double");
                else
                IntegralValueText.Text = string.Format("{0:F6}",Iold);
            }
            catch (FileLoadException)
            {
                MessageBox.Show("Файл не найдён");
            }
            catch (FormatException)
            {
                MessageBox.Show("Данные в файле некорректны");
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message, "Ошибка");
            }
        }

        public void Plot_Lagrange(int AmountOfNodes, PointPairList IntegralList, GraphPane pane)
        {
            //Полином лагранжа построение
            PointPairList LagrList = new PointPairList();
            LagrList.Clear();
            PointPairList n_list = new PointPairList(); //Тут точки по которым строится полоином
            double step = (IntegralList[IntegralList.Count() - 1].X - IntegralList[0].X) / 100;
            double first = IntegralList[0].X;
            double last = IntegralList[IntegralList.Count()-1].X;
            double x = IntegralList[0].X;
            if (AmountOfNodes == 2)
            {
                //Полином 3 степени тогда -> 4 точки нужно
                double st = (last - first) / 3.0;
                for(int i=0; i<4; i++)
                {
                    n_list.Add(first+ st*i, Calculate(first + st*i));
                }
                //n_list.Add(last, Calculate(last));
                n_list.Sort();

                for (int i = 0; i <= 100; i++)
                {
                    LagrList.Add(x, NLagrange(n_list, 3, x));
                    x += step;
                }//
            }//
            else if (AmountOfNodes == 3)
            {
                double st = (last - first) / 5.0;
                for (int i = 0; i < 6; i++)
                {
                    n_list.Add(first + st * i, Calculate(first + st * i));
                }
                n_list.Sort();

                for (int i = 0; i <= 100; i++)
                {
                    LagrList.Add(x, NLagrange(n_list, 5, x));
                    x += step;
                }//
            }//
            else if (AmountOfNodes == 4)
            {
                double st = (last - first) / 7.0;
                for (int i = 0; i < 8; i++)
                {
                    n_list.Add(first + st * i, Calculate(first + st * i));
                }
                n_list.Sort();

                for (int i = 0; i <= 100; i++)
                {
                    LagrList.Add(x, NLagrange(n_list, 7, x));
                    x += step;
                }//
            }



            LineItem curve2 = pane.AddCurve("Интерполирующий полином", LagrList, Color.Magenta, SymbolType.None);
            curve2.Line.Width = 3;
            curve2.Line.Fill = new ZedGraph.Fill(Color.Yellow,Color.Tomato, Color.Orange, 45.0f);
        }


        private void LeftBorderText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != (char)8) && (e.KeyChar < (char)48 || e.KeyChar > (char)57) && (e.KeyChar != (char)44) && (e.KeyChar != (char)45))
            {
                { MessageBox.Show(this, "Некорректный символ"); }
                e.Handled = true;
            }
            if (e.KeyChar == (char)44)
            {
                if (LeftBorderText.Text.Contains(","))
                {
                    MessageBox.Show(this, "Одна запятая уже есть");
                    e.Handled = true;
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void RightBorderText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != (char)8) && (e.KeyChar < (char)48 || e.KeyChar > (char)57) && (e.KeyChar != (char)44) && (e.KeyChar != (char)45))
            {
                { MessageBox.Show(this, "Некорректный символ"); }
                e.Handled = true;
            }
            if (e.KeyChar == (char)44)
            {
                if (RightBorderText.Text.Contains(","))
                {
                    MessageBox.Show(this, "Одна запятая уже есть");
                    e.Handled = true;
                }
            }
        }

        private void AmountOfPointsText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != (char)8) && (e.KeyChar < (char)48 || e.KeyChar > (char)57))
            {
                { MessageBox.Show(this, "Некорректный символ"); }
                e.Handled = true;
            }
        }

        private void ChartSetup()
        {
            GraphPane pane = zedGraphControl1.GraphPane;
            pane.XAxis.Scale.MinAuto = true;
            pane.XAxis.Scale.MaxAuto = true;
            pane.YAxis.Scale.MinAuto = true;
            pane.YAxis.Scale.MaxAuto = true;
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            pane.XAxis.Title.Text = "X";
            pane.YAxis.Title.Text = "Y";
            pane.XAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.IsVisible = true;
            pane.XAxis.MajorGrid.IsZeroLine = false;
            pane.YAxis.MajorGrid.IsZeroLine = false;
            pane.XAxis.Scale.FontSpec.Size = 12;
            pane.YAxis.Scale.FontSpec.Size = 12;
        }
    }
}
