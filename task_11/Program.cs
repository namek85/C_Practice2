Random random = new Random();
int number = random.Next (99,1000); //579
Console.WriteLine("Случайное число = {0} ", number);
int a = number / 100;
int b = number % 10;

Console.WriteLine("{0}{1}", a, b);
