﻿
using System;
using System.Numerics;

namespace lab11
{
    class Program
    {
        static void Main()
        {
            int correct = 0;

            do
            {
                Console.WriteLine("Вычислим корни кубического уравнения ");
                Console.WriteLine("Ax^3+Bx^2+Cx+D=0 ");
                Console.Write("A=");
                double A;
                while (!Double.TryParse(Console.ReadLine(), out A))
                {
                    Console.WriteLine("Ошибка ввода! Введите число A\nA= ");
                }
                if (A == 0) { Console.WriteLine("Wrong input");break; }
   
                Console.Write("B=");
                double B;
                while (!Double.TryParse(Console.ReadLine(), out B))
                {
                    Console.WriteLine("Ошибка ввода! Введите число B\nB=");
                }
                if (B == 0) { Console.WriteLine("Wrong input"); break; }

                Console.Write("C=");
                double C;
                while (!Double.TryParse(Console.ReadLine(), out C))
                {
                    Console.WriteLine("Ошибка ввода! C\nC=");
                }
                if (C == 0) { Console.WriteLine("Wrong input"); break; }

                Console.Write("D=");
                double D;
                while (!Double.TryParse(Console.ReadLine(), out D))
                {
                    Console.WriteLine("Ошибка ввода! D\nD=");
                }
                if (D == 0) { Console.WriteLine("Wrong input"); break; }


                Console.Clear();
                Console.WriteLine("A={0} B={1} C={2} D={3}", A, B, C, D);

                Console.Write("\nДелим все коэфиценты на А:");
                B /= A;
                C /= A;
                D /= A;
                A = 1;
                Console.WriteLine("\nA={0}\t B={1}\t C={2}\t D={3}\n ", A, B, C, D);

                double Q = (Math.Pow(B, 2.0) - (3 * C)) / 9.0;
                double R = ((2 * Math.Pow(B, 3.0)) - (9 * B * C) + (27 * D)) / 54.0;
                double S = Math.Pow(Q, 3) - Math.Pow(R, 2);

                Console.WriteLine("Q={0} \t R={1} \t S={2}\n ", Q, R, S);

                if (S > 0)
                {
                    double fi = Math.Acos(R / Math.Sqrt(Math.Pow(Q, 3.0))) / 3.0;
                    double x1 = -2 * Math.Sqrt(Q) * Math.Cos(fi) - (B / 3.0);
                    Console.WriteLine("\nПервый корень x1= {0} ", x1);
                    double x2 = -2 * Math.Sqrt(Q) * Math.Cos(fi + ((2 * Math.PI) / 3.0)) - (B / 3.0);
                    Console.WriteLine("Второй корень x2= {0} ", x2);
                    double x3 = -2 * Math.Sqrt(Q) * Math.Cos(fi - ((2 * Math.PI) / 3.0)) - (B / 3.0);
                    Console.WriteLine("Третий корень x3= {0} ", x3);
                }

                int znakR;

                if (R < 0) { znakR = -1; }
                else if (R > 0) { znakR = 1; }
                else { znakR = 0; };

                if (S < 0 && Q > 0)
                {
                    double value1 = (Math.Abs(R) / Math.Sqrt(Math.Abs(Math.Pow(Q, 3))));
                    if (value1 < 0) Console.WriteLine("ERROR...");
                    else
                    {
                        double value2 = (value1 + Math.Sqrt(Math.Pow(value1, 2) - 1));
                        double Arch = Math.Log(value2, Math.E);
                        double fi = Arch / 3.0;
                        double ch = (Math.Pow(Math.E, fi) + Math.Pow(Math.E, -fi)) / 2.0;
                        double value3 = Math.Sqrt(Q) * ch;
                        double x1 = -2 * znakR * value3 - (B / 3.0);

                        Console.WriteLine("\nПервый корень x1= {0} ", x1);

                        double x2 = (znakR * Math.Sqrt(Q) * Math.Cosh(fi)) - (B / 3.0);
                        double x3 = Math.Sqrt(3) * Math.Sqrt(Q) * Math.Sinh(fi);

                        Complex complex = new Complex(x2, x3);//конструктор (двухмерная декартовая система координат)
                        double rl = complex.Real;
                        double im = complex.Imaginary;
                        Console.WriteLine("Второй корень x2= {0} + {1} * i ", rl, im);
                        Console.WriteLine("Третий корень x3= {0} - {1} * i ", rl, im);
                    }
                }

                else if (S < 0 && Q < 0)
                {
                    double value1 = (Math.Abs(R) / Math.Sqrt(Math.Abs(Math.Pow(Q, 3))));
                    double value2 = (value1 + Math.Sqrt(Math.Pow(value1, 2) + 1));
                    double Arsh = Math.Log(value2, Math.E);
                    double fi = Arsh / 3.0;
                    double sh = (Math.Pow(Math.E, fi) - Math.Pow(Math.E, -fi)) / 2.0;
                    double value3 = Math.Sqrt(Math.Abs(Q)) * sh;
                    double x1 = -2 * znakR * value3 - (B / 3.0);

                    Console.WriteLine("\nПервый корень x1= {0} ", x1);

                    double x2 = (znakR * Math.Sqrt(Math.Abs(Q)) * Math.Sinh(fi)) - (B / 3.0);
                    double x3 = Math.Sqrt(3) * Math.Sqrt(Math.Abs(Q)) * Math.Cosh(fi);

                    Complex complex = new Complex(x2, x3);//конструктор (двухмерная декартовая система координат)
                    double rl = complex.Real;
                    double im = complex.Imaginary;
                    Console.WriteLine("Второй корень x2= {0} + {1} * i ", rl, im);
                    Console.WriteLine("Третий корень x3= {0} - {1} * i ", rl, im);
                }

                else if (S < 0 && Q == 0)
                {
                    double x1 = -Math.Pow(D - (Math.Pow(B, 3) / 27.0) - (B / 3.0), 1 / 3.0);

                    Console.WriteLine("\nПервый корень x1= {0} ", x1);

                     double x2 = -(B + x1) / 2.0;
                     double x3 = Math.Sqrt(Math.Abs(((B - 3 * x1) * (B + x1)) - 4 * C)) / 2.0;

                    Complex complex = new Complex(x2, x3);//конструктор (двухмерная декартовая система координат)
                    double rl = complex.Real;
                    double im = complex.Imaginary;
                    Console.WriteLine("Второй корень x2= {0} + {1} * i ", rl, im);
                    Console.WriteLine("Третий корень x3= {0} - {1} * i ", rl, im);
                }

                if (S == 0)
                {
                    double x1 = (-2 * Math.Pow(R, 1 / 3.0)) - (B / 3.0);
                    Console.WriteLine("\nПервый корень x1= {0} ", x1);
                    double x2 = (Math.Pow(R, 1 / 3.0)) - (B / 3.0);
                    Console.WriteLine("Второй корень x2= {0} ", x2);
                }

                Console.Write("\nЧтобы продолжить нажмите 1\n ");
                correct = Convert.ToInt32(Console.ReadLine());
                if (correct == 1) Console.Clear();
            } while (correct == 1);

        }

    }

}