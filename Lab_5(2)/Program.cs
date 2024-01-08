using Task2;

class Program
{
    public static void Main()
    {
        MyList<int> ml1 = new(1, 2, 3, 4);

        ml1.AddElem(5);
        ml1.Print();

    }
}