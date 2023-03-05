Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArray(numbers);
Console.WriteLine("В массиве: ");
PrintArray(numbers);
int sum = 0;


for (int i = 1; i < numbers.Length; i=i+2)
    sum = sum + numbers[i];

    Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

void FillArray(int[] numbers)
{
    for(int j = 0; j < numbers.Length; j++)
        {
            numbers[j] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    for(int k = 0; k < numbers.Length; k++)
        {
            Console.Write(numbers[k] + " ");
        }
    Console.WriteLine();
}