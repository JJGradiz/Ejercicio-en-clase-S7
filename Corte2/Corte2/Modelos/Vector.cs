using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Corte2.Modelos
{
    public class Vector
    {
        private const int TAMAÑO = 10;
        private int[] notas = new int[TAMAÑO];

        public int posicion { get; set; }
        public bool Agregar(int nota)
        {
            if (posicion < TAMAÑO)
            {
                notas[posicion] = nota;
                posicion++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public String Show()
                {
                    String datos = "";

                    for (int i = 0; i < posicion; i++)
                    {
                        for (int j = i + 1; j < posicion; j++)
                        {
                            if (notas[j] > notas[i])
                            {
                                int temp = notas[i];
                                notas[i] = notas[j];
                                notas[j] = temp;
                            }
                        }
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        datos = datos + notas[i] + " | ";
                    }
                    return datos;


        }

    }

}

