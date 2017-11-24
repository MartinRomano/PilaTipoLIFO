using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack miStack = new Stack(); // LIFO (Last In First Out) - Pila

            // Agregando elementos
            miStack.Push("Primer Elemento Ingresado");
            miStack.Push("Segundo Elemento Ingresado");
            miStack.Push("Tercer Elemento Ingresado");
            miStack.Push("Cuarto Elemento Ingresado");

            // Iteracion del stack
            foreach (string martinStack in miStack)
                Console.WriteLine("-> {0}", martinStack);
            Console.WriteLine("------------------------");

            // Metodo Pop (Toma el primer valor y lo quita)
            Console.WriteLine(miStack.Pop()+" quitado por metodo Pop");

            foreach (string martinStack in miStack)
                Console.WriteLine("-> {0}", martinStack);

            // Metodo Peek (Observa el primer valor pero no lo quita)
            Console.WriteLine(miStack.Peek() + " observado por Peek");

            foreach (string martinStack in miStack)
                Console.WriteLine("-> {0}", martinStack);

            // Cantidad de elementos 
            Console.WriteLine("El stack contiene "+miStack.Count+" elementos.");

            Console.ReadKey();
        }
    }
}
