// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter Number");
int length = int.Parse(Console.ReadLine());
fibonaci(-1, 1, 0, length);
void fibonaci(int a, int b, int c, int l){
    if (c <= l)
    {
        Console.WriteLine(a+b);
        fibonaci(b, a+b, c+1, l);
    }
}
