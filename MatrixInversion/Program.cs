using System;
using System.IO;

namespace MatrixInversion
{
    class Program
    {
        static void Main(string[] args)
        {  
            Scanner scan = new Scanner();
            byte caseNumber = 0;
            int a;
            int b;
            int c;
            int d;
   
            while(true)
            {
                a = scan.NextInt();
                b = scan.NextInt();
                c = scan.NextInt();
                d = scan.NextInt();

                int determinant = (a * d) - (b * c);

                if (determinant != 0)
                {
                    int newA = d * determinant;
                    int newB = (-1) * b * determinant;
                    int newC = (-1) * c * determinant;
                    int newD = a * determinant;

                    Console.WriteLine($"Case {++caseNumber}:");
                    Console.WriteLine($"{newA} {newB}");
                    Console.WriteLine($"{newC} {newD}");

                }

                Console.ReadKey();
            }
        }
    }

    public class NoMoreTokensException : Exception
    {
        public NoMoreTokensException() : base()
        {
        }

        public NoMoreTokensException(string message) : base(message)
        {
        }

        public NoMoreTokensException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public class Tokenizer
    {
        string[] tokens = new string[0];
        private int pos;
        StreamReader reader;

        public Tokenizer(Stream inStream)
        {
            var bs = new BufferedStream(inStream);
            reader = new StreamReader(bs);
        }

        public Tokenizer() : this(Console.OpenStandardInput())
        {
            // Nothing more to do
        }

        private string PeekNext()
        {
            if (pos < 0)
                // pos < 0 indicates that there are no more tokens
                return null;
            if (pos < tokens.Length)
            {
                if (tokens[pos].Length == 0)
                {
                    ++pos;
                    return PeekNext();
                }
                return tokens[pos];
            }
            string line = reader.ReadLine();
            if (line == null)
            {
                // There is no more data to read
                pos = -1;
                return null;
            }
            // Split the line that was read on white space characters
            tokens = line.Split(null);
            pos = 0;
            return PeekNext();
        }

        public bool HasNext()
        {
            return (PeekNext() != null);
        }

        public string Next()
        {
            string next = PeekNext();
            if (next == null)
                throw new NoMoreTokensException();
            ++pos;
            return next;
        }
    }


    public class Scanner : Tokenizer
    {

        public int NextInt()
        {
            return int.Parse(Next());
        }

        public long NextLong()
        {
            return long.Parse(Next());
        }

        public float NextFloat()
        {
            return float.Parse(Next());
        }

        public double NextDouble()
        {
            return double.Parse(Next());
        }
    }


    public class BufferedStdoutWriter : StreamWriter
    {
        public BufferedStdoutWriter() : base(new BufferedStream(Console.OpenStandardOutput()))
        {
        }
    }
}