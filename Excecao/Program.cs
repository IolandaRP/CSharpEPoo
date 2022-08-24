class Program
{
    static void Main(string[] args)
    {
        var seteString = "sete";
        string valorNull = null;
        var longValue = long.MaxValue.ToString();

        try 
        {
            //var formatException = int.Parse(seteString);
            //var argumentNullException = int.Parse(valorNull);
             var overflowException = int.Parse(longValue);
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Format Exception : {ex.Message}"); 
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine($"Argument Null Exception : {ex.Message}");
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"Overflow Exception : {ex.Message}");
        }

        finally
        {
            Console.WriteLine("Esse código sempre será executado.");
        }

        Console.ReadKey();
    }
}
