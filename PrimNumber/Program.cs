// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter Number");
int source = int.Parse(Console.ReadLine());
int count = 0;
for(int i = 1; i<=source;i++)
{
    if (source % i == 0)
    {
        count ++;
    }
}
if(count == 2)
{
    Console.WriteLine("Prime Number :" + source);
}
else
{
    Console.WriteLine("Not a Prime Number");
}
Console.ReadLine();