// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Vvedite chislo:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite stepen': ");
int num2 = Convert.ToInt32(Console.ReadLine());

double pow = Math.Pow(num1,num2);
Console.WriteLine(pow);



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Vvedite Chislo: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while(num>0)
{
    num=sum + num%10;
    num = num/10;
    

}
Console.WriteLine(sum);






// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

int[]array = GetArray(8);
Console.WriteLine(string.Join(",", array));

int[] GetArray(int size)
{
    int[] result = new int [size];
    for(int i = 0; i<size; i++)
    {
        result[i] = new Random().Next(0,100);
    }
    return result;
}