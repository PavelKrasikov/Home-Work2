Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = number / 10000 % 10; // First digit
int b = number / 1000 % 10; // Second digit
int c = number / 10 % 10; // Fours digit
int d = number % 10; // Five digit

if (a == d && b == c)
    Console.WriteLine("Число - полиндром");

else
    Console.WriteLine("Число - не полиндром");
    