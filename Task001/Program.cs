Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandomNumbers(numbers);
Console.WriteLine("В массиве: ");
PrintNumbers(numbers);
int count = 0;

for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void RandomNumbers(int[] numbers)
{
    for(int j = 0; j < numbers.Length; j++)
    {
        numbers[j] = new Random().Next(100,1000);
    }
}
void PrintNumbers(int[] numbers)
{
    for(int k = 0; k < numbers.Length; k++)
    {
        Console.Write(numbers[k] + " ");
    }
    Console.WriteLine();
}