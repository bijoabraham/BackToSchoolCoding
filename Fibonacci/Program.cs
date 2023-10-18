// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter Number");
int count = int.Parse(Console.ReadLine());
long prevNumber = -1;
long nextNumber = 1;
for(int i = 0; i <= count; i++)
{
    long sum = prevNumber + nextNumber;
    Console.WriteLine(sum);
    prevNumber = nextNumber;
    nextNumber = sum;
}
Console.ReadLine();



