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
                answer = x + 0;
            else if (x > 0)
                answer = x + 1;
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


    //Я потратила примерно час на то чтоб разобраться почему у меня выскакивает ошибка (Форумы не помогли) с отсутствием мейн сигмента (Я пихала его везде где могла) пока не засунула в конец
    public class Program
    {
        static void Main(string[] args)
        {
            Blue blue = new Blue();

            Console.Write("Task1: Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Task1: Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (blue.Task1(a, b))
                Console.WriteLine("имеют одинаковые знаки или оба равны нулю");
            else
                Console.WriteLine("имеют разные знаки");

            Console.WriteLine("\nTask2:Проверка дробной части:");
            Console.Write("Введите вещественное чиселко: ");
            double d = Convert.ToDouble(Console.ReadLine());

            if (blue.Task2(d))
                Console.WriteLine("Чиселко имеет дробную часть :3");
            else
                Console.WriteLine("Число не имеет дробной части :(");

            Console.WriteLine("\nTask3:Проверка делимости одного числа на другое:");
            Console.Write("\nВведите число a: ");
            int numA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b: ");
            int numB = Convert.ToInt32(Console.ReadLine());
            if (blue.Task3(numA, numB))
                Console.WriteLine("Делится");
            else
                Console.WriteLine("Не делится");

            Console.WriteLine("\nTask4: Какое из чисел больше по модулю");
            Console.Write("\nВведите число d: ");
            double numD = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nВведите число f: ");
            double numF = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nВведите число g: ");
            double numG = Convert.ToDouble(Console.ReadLine());
            double result4 = blue.Task4(numD, numF, numG);
            Console.WriteLine($"Наибольшее по модулю: {result4}");

            Console.WriteLine("\nTask5: Штучка с функцией (лишь бы я всё правильно поняла)");
            Console.Write("\nВведите число x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double result5 = blue.Task5(x);
            Console.WriteLine("y(x) = " + result5);

            Console.WriteLine("\nTask6: Поместиться ли круг в квадрат");
            Console.Write("\nВведите площадь круга: ");
            double cirS = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nВведите площадь квадрата: ");
            double squS = Convert.ToDouble(Console.ReadLine());
            if (blue.Task6(cirS, squS) == true)
                Console.WriteLine("Да, помещается");
            else Console.WriteLine("Нет, не помещается");


            Console.WriteLine("\nTask7: Выполняется ли с 2 числами табличка");
            Console.Write("\nВведите первое число: ");
            double dd = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nВведите второе число: ");
            double ff = Convert.ToDouble(Console.ReadLine());
            double result7 = blue.Task7(dd, ff);
            Console.WriteLine(result7);


            Console.WriteLine("\nTask8: Может ли король поделить монетки?");
            Console.Write("\nВведите сколько максимально у первого сына: ");
            int AA = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите сколько максимально у второго сына: ");
            int BB = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите сколько максимально у третьего сына: ");
            int CC = Convert.ToInt32(Console.ReadLine());
            if (blue.Task8(AA, BB, CC))
                Console.Write("Может");
            else
                Console.Write("не может");

            Console.ReadKey();

        }
    }
}

//Электрик разочаровался в жизни, потому что его никто не ценил. А он всю жизнь только и делал, что искал контакты...
