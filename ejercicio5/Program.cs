namespace ConsoleApp1
{
    internal class Class1
    {
        static void Main(string[] args)
        {

            int A = 21;
            int B = 32;
            int C = 12;
            int D = 41;

            B = C;
            C = A;
            A = D;
            D = B;


            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
            Console.WriteLine(D);
            Console.ReadKey();

        }
    }
}
