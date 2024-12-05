using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.busquedas
{

    internal class metodoshash
    {
        private static  int tam= 100; // Tamaño fijo de la tabla hash
        public int[] claves;
        public string[] valores;

        public metodoshash()
        {
            //this.claves = claves;
            //this.valores = valores;

            claves = new int[tam];
            valores = new string[tam];
            for (int i = 0; i < tam; i++)
            {
                claves[i] = -1; // Indicador de espacio vacío
            }
        }
      
        public int settam()
        {

            return tam;
        }


        // Función hash simple (modular)
        private int FuncionHash(int clave, int tamanioTabla)
        {
            return clave % tamanioTabla;
        }

        //Función hash polinomial para cadenas
        static int FuncionHashPolinomial(string clave, int tamanioTabla)
        {
            const int basePolinomial = 31; // Base comúnmente usada para funciones hash
            int hash = 0;

            for (int i = 0; i < clave.Length; i++)
            {
                // Convertir carácter a su valor ASCII y multiplicar por la potencia de la base
                hash = (hash * basePolinomial + clave[i]) % tamanioTabla;
            }

            // Asegurarse de que el resultado sea positivo
            return Math.Abs(hash);
        }

        // Función hash avanzada para números enteros
        //static long FuncionHashAvanzada(uint clave, int tamanioTabla)
        //{
        //    const int primo = 31; // Número primo para la mezcla
        //    const uint mezclaBits = 0x9E3779B9; // Constante "mágica" derivada de la proporción áurea
        //                                        //Se utiliza comúnmente en algoritmos hash para lograr una buena dispersión de bits.
        //    uint hash = clave;

        //    // Mezclar los bits
        //    hash ^= (hash >> 16);         // Mezclar los bits altos y bajos
        //    hash *= mezclaBits;          // Multiplicar por una constante mágica
        //    hash ^= (hash >> 13);         // Otro desplazamiento
        //    hash *= primo;               // Multiplicar por un número primo
        //    hash ^= (hash >> 16);         // Desplazamiento final

        //    // Asegurar que está dentro del rango de la tabla hash
        //    return Math.Abs(hash) % tamanioTabla;
        //}


        // Insertar clave y valor en la tabla
        public void Insertar(int clave, string valor)
        {
            int indice = FuncionHash(clave, tam);
            while (claves[indice] != -1) // Resolver colisiones mediante linealidad
            {
                indice = (indice + 1) % tam;
            }
            claves[indice] = clave;
            valores[indice] = valor;
           
        }

        // Buscar un valor por su clave
        public string Buscar(int clave)
        {
            int indice = FuncionHash(clave, tam);
            int inicio = indice;

            while (claves[indice] != -1)
            {
                if (claves[indice] == clave)
                {
                    return valores[indice];
                }
                indice = (indice + 1) % tam;

                // Si volvemos al punto de inicio, terminamos la búsqueda
                if (indice == inicio)
                {
                    break;
                }
            }
            return null; // No encontrado
        }


       
        
    }


}
