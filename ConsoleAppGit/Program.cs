namespace ConsoleAppGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dado d=new Dado();
            int valore = d.lanciaDado();
            Console.WriteLine(valore);
        }
    }
}
