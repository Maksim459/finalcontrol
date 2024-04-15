class Numbers
{
    public void Divide()
    {
        int num1 = 5;
        int num2 = 1;
        int num3;
        try 
        { 
         num3=num1/num2;
            Console.WriteLine(num3);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Ошибка:деление на 0,{ex}");
        }
        
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Numbers numbers = new Numbers();
        numbers.Divide();
    }
}