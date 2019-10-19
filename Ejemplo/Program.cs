using System;

namespace Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona rodri = new Persona("Jorge Rodriguez", 67);

            // Pepito cobra la jubilacion
            rodri.cobrar(8000);

            // Pepito paga Netflix
            rodri.pagar(500);

            // Muestra el saldo restante de pepito
            rodri.verSaldo();

            Persona flor= new Persona("Pepito Flores", 67);

            // Jorge hace ejercicio gastando 70 de energia
            flor.hacerEjercicio(70);

            // Jorge duerme un par de horas recuperando 30 de energia
            flor.dormir(30);

            // Muestra la energia de Jorge
            flor.verEnergia();

            Console.ReadLine();

        }
    }
}
