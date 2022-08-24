using ArraysEListas;

class Program
{
    static void Main(string[] args)
    {
        #region Arrays
        var numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var numbersCopy = new int[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbersCopy[i] = numbers[i];
        }

        Console.WriteLine("Impressão numbersCopy: ");
        foreach (var n in numbersCopy)
        {
            Console.WriteLine(n);
        }

        var numbersString = "0 1 2 3 4 5 6 7 8 9";
        var numbersSplit = numbersString.Split(" ");
        var numbersConvertedFromInt = Array.ConvertAll(numbersSplit, Convert.ToInt32);

        Console.WriteLine("Impressão numbersConvertedFromInt : ");
        foreach (var n in numbersConvertedFromInt)
        {
            Console.WriteLine(n);
        }

        #endregion

        #region List
        var list = new List<int> { 0, 1, 2, 3, 4 };
        var listFromArray = new List<int>(numbers);

        list.Add(5);
        list.AddRange(new List<int> { 6, 7 });
        list.AddRange(new int[] { 8, 9 });

        var count = list.Count;
        var contains14 = list.Contains(14);
        var contains2 = list.Contains(2);

        Console.WriteLine("Lista Reversa: ");
        list.Reverse();
        list.ForEach(l => Console.WriteLine(l));

        Console.WriteLine("Lista Ordenada: ");
        list.Sort();
        list.ForEach(l => Console.WriteLine(l));

        list.Remove(4);
        list.RemoveAll(l => l > 5);

        //list.Clear(); remove todos os elementos da lista

        #endregion

        #region Linq
        var students = new List<Student>
        {
            new Student(1, "Luis", "12345", 100),
            new Student(2, "Roberto", "754545", 35),
            new Student(3, "Bianca", "87545", 85),
            new Student(4, "Helena", "78555", 70),
            new Student(5, "Luis", "44444", 75)
         };

        var any = students.Any();
        var any100 = students.Any(s => s.Grade == 100);

        var single = students.Single(s => s.Id == 1);
        var singleOrDefault = students.SingleOrDefault(s => s.Document == "12345");

        var first = students.First(s => s.FullName == "Luis");
        var firstOrDefault = students.FirstOrDefault(s => s.Grade == 0);

        var orderByGrade = students.OrderBy(s => s.Grade);

        var approvedStudents = students.Where(s => s.Grade >= 70);

        var grades = students.Select(s => s.Grade);
        var phoneNumbers = students.SelectMany(s => s.PhoneNumbers);

        var sum = students.Sum(s => s.Grade);
        var min = students.Min(s => s.Grade);
        var max = students.Max(s => s.Grade);
        var qtd = students.Count;

        Console.ReadKey();

        #endregion
    }
}