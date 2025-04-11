using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int sum = 0;

        for (int i = 1; i <= 50; i++)
        {
            if (i % 4 == 0 || i % 6 == 0)
            {
                sum += i;
            }
        }

        Console.WriteLine("The sum of all multiples of 4 or 6 from 1 to 50 is: " + sum);
    }
}
///Pseudo code
///Start
///Set sum = 0
///FOR i = 1 to 50 DO
///    IF i MOD 4 == 0 OR i MOD 6 == 0 THEN
///        sum = sum + i
///    ENDIF
///ENDFOR
///Display "Total sum: " + sum
///End
