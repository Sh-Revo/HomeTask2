using System;

namespace HomeWork
{
    class Program
    {
        static double Task1(double a, double b)
        {
            if (a > b)
            {
                return (a + b);
            }
            else if (a == b)
            {
                return (a * b);
            }
            else
            {
                return (a - b);
            }
        }

        static int Task2(double x, double y)
        {
            if (x > 0 && y > 0)
            {
                return 1;
            }
            else if (x < 0 && y > 0)
            {
                return 2;
            }
            else if (x < 0 && y < 0)
            {
                return 3;
            }
            else
            {
                return 4;
            }
                
        }

        static string Task3(double A, double B, double C)
        {
            double min, max;

            if (A > B)
            {
                max = A;
                min = B;
            }
            else
            {
                max = B;
                min = A;
            }
            if (C > max)
            {
                max = C;
            }
            else if (C < min)
            {
                min = C;
            }
            double mid = A + B + C - max - min;

            return $"{min}, {mid}, {max}";
        }

        static string Task4(double a, double b, double c)
        {
            double D;
            double x1, x2;

            D = b * b - 4 * a * c;
            if (D < 0)
            {
                return "No results";
            }
            else
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
            }

            return $"x1 = {x1}, x2 = {x2}";
        }

        static string Task5(int number)
        {
            string sresult1 = "";
            string sresult2 = "";

            int result1 = (int)(number / 10);
            int result2 = number % 10;
            switch (result1)
            {
                case 1:
                    {
                        switch (result2)
                        {
                            case 0:
                                {
                                    sresult1 = "десять";
                                    return sresult1;
                                }
                            case 1:
                                {
                                    sresult1 = "одиннадцать";
                                    return sresult1;
                                }
                            case 2:
                                {
                                    sresult1 = "двенадцать";
                                    return sresult1;
                                }
                            case 3:
                                {
                                    sresult1 = "тринадцать";
                                    return sresult1;
                                }
                            case 4:
                                {
                                    sresult1 = "четырнадцать";
                                    return sresult1;
                                }
                            case 5:
                                {
                                    sresult1 = "пятнадцать";
                                    return sresult1;
                                }
                            case 6:
                                {
                                    sresult1 = "шестнадцать";
                                    return sresult1;
                                }
                            case 7:
                                {
                                    sresult1 = "семнадцать";
                                    return sresult1;
                                }
                            case 8:
                                {
                                    sresult1 = "восемнадцать";
                                    return sresult1;
                                }
                            case 9:
                                {
                                    sresult1 = "девятнадцать";
                                    return sresult1;
                                }
                            default: break;
                        }
                        break;
                    }
                case 2:
                    {
                        sresult1 = "двадцать";
                        break;
                    }
                case 3:
                    {
                        sresult1 = "тридцать";
                        break;
                    }
                case 4:
                    {
                        sresult1 = "сорок";
                        break;
                    }
                case 5:
                    {
                        sresult1 = "пятьдесят";
                        break;
                    }
                case 6:
                    {
                        sresult1 = "шестьдесят";
                        break;
                    }
                case 7:
                    {
                        sresult1 = "семьдесят";
                        break;
                    }
                case 8:
                    {
                        sresult1 = "восемьдесят";
                        break;
                    }
                case 9:
                    {
                        sresult1 = "девяносто";
                        break;
                    }
                default: break;
            }
            switch (result2)
            {
                case 1:
                    {
                        sresult2 = "один";
                        break;
                    }
                case 2:
                    {
                        sresult2 = "два";
                        break;
                    }
                case 3:
                    {
                        sresult2 = "три";
                        break;
                    }
                case 4:
                    {
                        sresult2 = "четыре";
                        break;
                    }
                case 5:
                    {
                        sresult2 = "пять";
                        break;
                    }
                case 6:
                    {
                        sresult2 = "шесть";
                        break;
                    }
                case 7:
                    {
                        sresult2 = "семь";
                        break;
                    }
                case 8:
                    {
                        sresult2 = "восемь";
                        break;
                    }
                case 9:
                    {
                        sresult2 = "девять";
                        break;
                    }
                default: break;
            }

            return $"{sresult1} {sresult2}";
        }

        static void Main()
        {
            double Task1Result = Task1(4, 1);
            int Task2Result = Task2(-4, 2);
            string Task3Result = Task3(4, 1, 3);
            string Task4Result = Task4(1, 2, 1);
            string Task5Result = Task5(43);

            Console.WriteLine(Task1Result);
            Console.WriteLine(Task2Result);
            Console.WriteLine(Task3Result);
            Console.WriteLine(Task4Result);
            Console.WriteLine(Task5Result);
        }
    }
}