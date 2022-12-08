Console.WriteLine("Введите первое число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int P = Convert.ToInt32(Console.ReadLine());
if ((N % P) == 0)
 Console.WriteLine("Кратно");
 else
 Console.WriteLine("Не кратно " + N%P);

