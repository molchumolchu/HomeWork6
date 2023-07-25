
            void FillArray(int[]numbers, int minValue, int maxValue)
            {
                maxValue ++;
                Random rnd = new Random();
                for (int i=0; i<numbers.Length; i++)
                {
                    numbers[i]=rnd.Next(minValue, maxValue);
                }
            }

            void Print(int [] numbers)

            {
                for (int i=0; i<numbers.Length; i++)
                {
                    Console.Write($"{numbers[i]} ");
                }
                Console.WriteLine();
            }
        
        int Input(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }

void Task41()
{
    // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    // 0, 7, 8, -2, -2 -> 2
    // -1, -7, 567, 89, 223-> 3
    int M = Input("Сколько чисел Вы хотите ввести? ");
    int n = 0;
    int count =0;
    while (n<M)
    {
       int k = Input($"число {n+1} = ");
       if(k>0) count++;
       n++;
    }
    Console.WriteLine($"Количество введенных положительных чисел {count} ");
}

void Task43()
{
    // Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
    // y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
    Console.WriteLine("Даны следующие функции 2-х прямых");
    Console.WriteLine("y = k1 * x + b1");
    Console.WriteLine("y = k2 * x + b2");
    double k1 = Input(" Введите k1 ");
    double b1 = Input(" Введите b1 ");
    double k2 = Input(" Введите k2 ");
    double b2 = Input(" Введите b2 ");
    double x = 0;
    x = Math.Round((b2-b1)/(k1-k2), 1);
    double y = 0; 
    y = k1 * x + b1;
    Console.WriteLine($"Линии пересекутся в точке ({x}, {y})");

}
Task43();
