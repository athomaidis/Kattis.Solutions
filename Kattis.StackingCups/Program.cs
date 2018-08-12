using System;
using System.Collections.Generic;
using static Kattis.Shared.KattisIO;

namespace Kattis.StackingCups
{
    class Program
    {
        static void Main(string[] args)
        {
            Scanner scanner = new Scanner();

            int numberOfCups = scanner.NextInt();
            List<Cup> cups = new List<Cup>();

            for (int i = 1; i <= numberOfCups; i++)
            {
                
            }

        }

        public class Cup
        {
            private String color;
            private int radius;

            public Cup(String color, int radius)
            {
                this.color = color;
                this.radius = radius;
            }
        }
    }
}

/*
 * List<Cup> cups = new ArrayList<>();

        while (numCups-- > 0) {
            String[] values = reader.readLine().split(" ");

            if (values[0].matches("\\d+")) {
                cups.add(new Cup(values[1], Integer.parseInt(values[0]) / 2));
            } else {
                cups.add(new Cup(values[0], Integer.parseInt(values[1])));
            }
        }

        Collections.sort(cups, (Cup c1, Cup c2) -> Integer.compare(c1.radius, c2.radius));

        cups.forEach((c) -> {
            System.out.println(c.color);
        });
*/