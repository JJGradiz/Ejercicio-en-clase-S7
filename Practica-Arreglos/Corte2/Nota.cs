using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte2
{
    public class Nota
    {
        public int[] notas = new int[10];
        public static int pos = 0;

        public bool AgregarNota(int n)
        {
            if (pos < 10)
            {
                notas[pos++] = n;
                return true;
            }
            
            return false;
        }

        public String Show()
        {
            string datos = "";

            for (int i = 0; i < pos; i++)
            {
                for (int j = i+1; j < pos; j++)
                {
                    if (notas[j] > notas[i])
                    {
                        int temp = notas[i];
                        notas[i] = notas[j];
                        notas[j] = temp;
                    }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                datos += notas[i] + ", ";
            }   

            return datos;
        }
    }
}
