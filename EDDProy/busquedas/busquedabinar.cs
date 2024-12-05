using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.busquedas
{

    internal class busquedabinar
    {
        public static int[] A;


        public busquedabinar()
        {
        }

        public static int busqueda(int[] A, int dato, int inicio, int final)    //O(log n)
                                                                                // este metodo regresa el indice donde se encontro el numero buscado dentro de un arreglo ordenado  
        {
            if (inicio > final)                                            //O(1)
                                                                           //condicional  si inicio es mayor que final , es decir no se encontro el numero ya que se supero el ultimo indice   
            {
                return -1;                                                      //O(1)
            }

            int mitad = (inicio + final) / 2;
            // se crea el centro del arreglo        
            if (A[mitad] == dato)                                                                                                              // si en la mitad del arreglo es igual al numero buscado ,retorna el numero
            {
                return mitad;
            }

            else if (dato < A[mitad])                                             //O(1)
                                                                                  // sino  si ,el dato buscado es menor que la mitad                                                                           
            {
                return busqueda(A, dato, inicio, mitad - 1);                    //O(log n)
                                                                                // si es asi retorna el metodo busqueda , pero decrementando la mitad en uno         
            }
            else
            {

                return busqueda(A, dato, mitad + 1, final);                       //O(log n)
                                                                                  // sino retorna el metodo pero sumando uno ala mitad        
            }


        }

        // metodo que creaun arreglo con valores aleatorios no ordenados
        public static int[] crearlista(int tam)
        {
            Random rnd = new Random();

            int[] a = new int[tam];
            for (int i = 0; i < a.Length; i++)
            {


                a[i] = rnd.Next(1, 100);


            }

            return a;
        }




        public static void merge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int i = 0; i < n1; ++i)
            {
                L[i] = arr[l + i];
            }
            for (int j = 0; j < n2; ++j)
            {
                R[j] = arr[m + 1 + j];
            }

            int a = 0, b = 0;

            int k = l;
            while (a < n1 && b < n2)
            {
                if (L[a] <= R[b])
                {
                    arr[k] = L[a];
                    a++;
                }
                else
                {
                    arr[k] = R[b];
                    b++;
                }
                k++;
            }

            while (a < n1)
            {
                arr[k] = L[a];
                a++;
                k++;
            }

            while (b < n2)
            {
                arr[k] = R[b];
                b++;
                k++;
            }
        }
        // metodo que recibe un arreglo y ordena sus datos en orden asendente 
        public static void sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;

                sort(arr, l, m);
                sort(arr, m + 1, r);

                merge(arr, l, m, r);
            }
        }


    }


}






