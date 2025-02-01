namespace ConsoleAppGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dado d=new Dado();
            int valore1 = d.lanciaDado();
            int valore2 = d.lanciaDado();
            Console.WriteLine($"{valore1} {valore2}");
        }
    }
}
