// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bubble Sort");
int[] source = { 1, 8, 7, 5, 6, 4 };
int temp = 0;
for (int i = 0; i < source.Length; i++)
{
    for (int j = 0; j < source.Length - i - 1; j++)
    {
        if (source[j] > source[j + 1])
        {
            temp = source[j + 1];
            source[j + 1] = source[j];
            source[j] = temp;
        }
    }
}
Console.WriteLine("Sorted : " + string.Join(',', source));
Console.ReadLine();
