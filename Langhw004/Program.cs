// Показать все четные от 1 до N

Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

for(int i=1;i<=n;i=i+1)
{
    if(i % 2 == 0)
    Console.Write(i + ",");
}
