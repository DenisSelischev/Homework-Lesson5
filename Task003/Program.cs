Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandomNumbers(numbers);
Console.WriteLine("В этом массиве: ");
PrintNumbers(numbers);

int sum = 0;

for (int i = 0; i < numbers.Length; i++)
    sum = numbers.Max() - numbers.Min();

Console.WriteLine($"Максимальное число = {numbers.Max()}");
Console.WriteLine($"Минимальное число = {numbers.Min()}");
Console.WriteLine($"{numbers.Max()} - {numbers.Min()} = {sum}");

void RandomNumbers(int[] numbers)
{
    for (int j = 0; j < numbers.Length; j++)

        numbers[j] = new Random().Next(-9, 10);
}

void PrintNumbers(int[] numbers)
{
    for (int k = 0; k < numbers.Length; k++)

        Console.Write(numbers[k] + " ");
    Console.WriteLine();

}