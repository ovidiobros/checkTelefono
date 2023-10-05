using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public static class Telefono
{

    public static string Check(string[] input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            string telefono = input[i];

            if ((telefono.StartsWith("+39") && telefono.Length == 13) ||
                (telefono.StartsWith("0039") && telefono.Length == 14) ||
                (telefono.StartsWith("3") && telefono.Length == 10) 
                )
            {
                return telefono;
            }
        }

        return "";
      


     }

      



    }
    
    
