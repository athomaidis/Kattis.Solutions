using System;
using System.IO;

namespace Kattis.FunHouse
{
    public static class Program
    {
        private static void Main()
        {
            KattisIO.Scanner scan = new KattisIO.Scanner();

            byte houseID = 1;

            while(true)
            {
                byte columns = scan.NextByte();
                System.Diagnostics.Debug.WriteLine("Columns =" + columns);
                byte rows = scan.NextByte();
                System.Diagnostics.Debug.WriteLine("Rows =" + rows);

                if (columns == 0 && rows == 0)
                {
                    break;
                }

                char[,] topView = new char[rows,columns];
                System.Diagnostics.Debug.WriteLine(topView);
                byte entranceRow = 0;
                byte entranceCol = 0;

                for (byte row = 0; row < rows; row++)
                {
                    char[] currentRow = Console.ReadLine().Trim().ToCharArray();
                    System.Diagnostics.Debug.WriteLine(currentRow);

                    for (byte column = 0; column < columns; column++) // locate entrance
                    {
                        topView[row, column] = currentRow[column];
                        if (topView[row, column] == '*')
                        {
                            entranceRow = row;
                            entranceCol = column;
                        }
                    }
                }

                int direction = 0;

                if (entranceRow == 0)
                {
                    direction = 2; // south
                } else if (entranceRow == (rows-1))
                {
                    direction = 1; // north
                } else if (entranceCol == 0)
                {
                    direction = 1; // east
                } else if (entranceCol == (columns-1))
                {
                    direction = 3; // west
                }

                int[] directionRow = { -1, 0, 1, 0 };
                int[] directionCol = { 0, 1, 0, -1 };

                int newRow = (int)entranceRow;
                int newCol = (int)entranceCol;

                while (topView[newRow,newCol] != 'x')
                {
                    newRow += directionRow[direction];
                    newCol += directionCol[direction];

                    if (topView[newRow,newCol] == '/')
                    {
                        if (direction == 0 || direction == 2)
                        {
                            direction++;
                        } else
                        {
                            direction--;
                        }
                    } else if (topView[newRow,newCol] == '\\')
                    {
                        if (direction == 0 || direction == 2)
                        {
                            direction = (direction + 3) % 4;
                        } else
                        {
                            direction = (direction + 1) % 4;
                        }
                    }
                }

                topView[newRow, newCol] = '&'; //indicate exit
                Console.WriteLine("HOUSE " + houseID);
                houseID++;
                for (byte row = 0; row < rows; row++)
                {
                    for (byte column = 0; column < columns; column++)
                    {
                        Console.Write(string.Format("{0}", topView[row, column]));
                    }
                    Console.Write(Environment.NewLine);
                }
            }
        }
    }

    public static class KattisIO
    {
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
            private string[] tokens = new string[0];
            private int pos;
            private readonly StreamReader reader;

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
                { return null; }
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
                return PeekNext() != null;
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
            public byte NextByte()
            {
                return byte.Parse(Next());
            }

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
}