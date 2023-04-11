using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruxLab
{
    public class CountOfValidPasswords
    {
        public static void Counter()
        {
            string file = "C:\\CruxLab.txt";
            string[] fileLines = File.ReadAllLines(file);
            int validCount = 0;
            foreach (string line in fileLines)
            {
                string[] lineParts = line.Split(':');
                string[] requirementsSymbols = lineParts[0].Split(' ');
                string[] rangeParts = requirementsSymbols[1].Split('-');
                char requiredChar = requirementsSymbols[0][0];
                int minCount = int.Parse(rangeParts[0]);
                int maxCount = int.Parse(rangeParts[1]);
                string password = lineParts[1].Trim();
                int count = password.Count(c => c == requiredChar);
                if (count >= minCount && count <= maxCount)
                {
                    validCount++;
                }
            }
            Console.WriteLine("Valid passwords: " + validCount);
        }
    }
}
