// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a Number");
int source = int.Parse(Console.ReadLine());
int factorial = 1;
for(int i = source; i>0; i--)
{
    factorial = factorial * i;
}
Console.WriteLine("Factorial is :" + factorial);
Console.ReadLine();

