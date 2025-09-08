using System;
using System.ComponentModel.Design;
//Мне пришлось изменить своим привычкам ибо я обычно все что только можно сокращаю (result - r, answer - a) а тут такие переменные
namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;
            //тут просто случаи "True" рассматриваю. Мб есть проще варианты но я их не вижу
            // code here
            if (a > 0 && b > 0)
                answer = true;
            else if (a < 0 && b < 0)
                answer = true;
            else if (a == 0 && b == 0)
                answer = true;
            // end
            return answer;
        }

        public bool Task2(double d)
        {
            bool answer = false;
            // code here
            if (Math.Abs(d - Math.Round(d)) > 0.0001)
                //тут я отнимаю целую часть числа (round) от числа чтобы найти имеет ли чиселко микрочиселко в себе
                answer = true;
            // end
            return answer;
        }

        public bool Task3(int a, int b)
        {
            bool answer = false;
            // code here
            if (b != 0 && (a % b == 0))
                //скобочки в скобочках я оставила на память ибо у меня ошибка почему-то выходила что бы я ни делала а после перезагрузки вижуал студио её не было
                answer = true;
            // end
            return answer;
        }

        public double Task4(double d, double f, double g)
        {
            double answer = 0;
            //Здесь вроде все понятно, опять рассматриваем варианты просто
            // code here
            double absD = Math.Abs(d);
            double absF = Math.Abs(f);
            double absG = Math.Abs(g);

            if (absD >= absF && absD >= absG)
                answer = d;
            else if (absF >= absD && absF >= absG)
                answer = f;
            else
                answer = g;
            // end
            return answer;
        }

        public double Task5(double x)
        {
            double answer = 0;
            //я не знаю можно ли тут запихнуть как-то систему уравнений в одну строку через какую-то функцию поэтому иду по-простому
            // code here
            if (x > -1 && x <= 0)
                answer = x + 1;
            else if (x <= -1)
                answer = 0;
            else if (x > 0)
                answer = 1;
            // end
            return answer;
        }

        public bool Task6(double circleS, double squareS)
        //r = √(S/π). - радиус круга
        // плозадь квадрата - а^2
        // Чтобы проверить будет ли кружок в квадрате (Я сначала хотела через касательные а потом поняла что можно мозг себе с пустого места не делать и по-человечески решить)
        // я проверяю диаметр кружка . Если он меньше\равен стороны\е квадрата то всё супер
        {
            bool answer = false;
            // code here
            double circleDiameter = 2 * Math.Sqrt(circleS / Math.PI);
            double squareSide = Math.Sqrt(squareS);

            if (circleDiameter <= squareSide)
                answer = true;
            // end
            return answer;
        }

        public double Task7(double d, double f)
        {
            double answer = 0;
            // code here
            if (Math.Abs(d) < Math.Abs(f))
                if (d > 0)
                    answer = -1;
                else
                    answer = 0;
            else
                if (f > 0)
                answer = 1;
            else
                answer = 0;

            // end
            return answer;
        }

        public bool Task8(int a, int b, int c)
        {
            bool answer = false;
            // code here
            int hA = a / 2;
            int hB = b / 2;
            int hC = c / 2;

            int VsegoA = hA + hB + hC;
            int VsegoB = hA + hB + hC + 1;

            if ((VsegoA >= 3 && VsegoA % 3 == 0) || (VsegoB >= 3 && VsegoB % 3 == 0))
                answer = true;
            else
                answer = false;
            // проба 1 (я не учла с перераспределением момент поэтому не работает)
            //// Проверяем, что во всех мешках хотя бы по 1 монете
            //if (hA >= 1 && hB >= 1 && hC >= 1)

            //    // Уже норм?
            //    if (hA == hB && hB == hC)
            //        answer = true;
            //    // Если не норм то смотрим с учетом алиментов на младшего
            //    else if (hA == hB && hB == hC + 1)
            //        answer = true;


            // end
            return answer;
        }
    }
}

