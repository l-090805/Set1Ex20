namespace Set1Ex20
{
    internal class Program
    {
        private static void Fractie()
        {
            Console.Write("introduceti un numar m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar n: ");
            int n = int.Parse(Console.ReadLine());

            int parteInt = m / n;
            int parteFrac = m % n;
            Console.Write($"{parteInt},");

            int cifra, rest;
            List<int> cifre = new List<int>();
            List<int> resturi = new List<int>();

            resturi.Add(parteFrac);
            bool periodic = false;

            do
            {
                cifra = parteFrac * 10 / n;
                cifre.Add(cifra);
                rest = parteFrac * 10 % n;

                if (!resturi.Contains(rest))
                {
                    resturi.Add(rest);
                }
                else
                {
                    periodic = true;
                    break;
                }

                parteFrac = rest;

            }
            while (rest != 0);

            if (!periodic)
            {
                foreach(var item in cifre)
                {
                    Console.Write(item);
                }
            }
            else
            {
                for(int i = 0; i < cifre.Count; i++)
                {
                    if (resturi[i] == rest)
                    {
                        Console.Write("(");
                    }
                    Console.Write(i);
                }
                Console.Write(")");
            }
        }
        static void Main(string[] args)
        {
            Fractie();
        }
    }
}
