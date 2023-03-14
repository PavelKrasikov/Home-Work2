// ввод данных
Console.WriteLine("Введите число: ");
 int a = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Таблица кубов чисел от 1 до " + a + ":");

 for (int i = 1; i <= a; i++)

    Console.WriteLine(i + " в кубе = " + Math.Pow(i,3));