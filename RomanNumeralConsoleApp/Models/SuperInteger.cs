namespace RomanNumeralConsoleApp.Models
{
    public class SuperInteger
    {
        /// <summary>Returns the equivalent roman number to integer</summary>
        /// <param name="romanNumber">Roman number</param>
        /// <returns>Integer</returns>
        public static int ConvertToDecimal(string romanNumber)
        {
            int integer = 0;

            for (int i = 0; i < romanNumber.Length; i++)
            {
                int firstEnd = GetEquivalentRoman(romanNumber[i]);

                if (i + 1 < romanNumber.Length)
                {
                    int secondEnd = GetEquivalentRoman(romanNumber[i + 1]);

                    if (firstEnd >= secondEnd)
                    {
                        integer = integer + firstEnd;
                    }
                    else
                    {
                        integer = integer + secondEnd - firstEnd;
                        i++;
                    }
                }
                else
                {
                    integer = integer + firstEnd;
                    i++;
                }
            }

            return integer;
        }

        /// <summary>Returns the equivalent roman number to integer</summary>
        /// <param name="romanNumber">Roman number</param>
        /// <returns>Integer</returns>
        private static int GetEquivalentRoman(char romanNumber) => romanNumber switch
        {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => -1
        };
    }
}