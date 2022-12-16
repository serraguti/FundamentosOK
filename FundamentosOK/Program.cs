using System;
namespace FundamentosOK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metodo MAIN");
            //METODO PRINCIPAL DE EJECUCION
            //REALIZAMOS LA LLAMADA A LOS METODOS 
            //QUE DESEEMOS.
            //PositivoNegativo();
            //NumeroMayorMenor();
            //DiaNacimientoSemana();
            //EjemploBucles();
            //ConjeturaCollatz();
            NumerosPares();
        }

        static void NumerosPares()
        {
            Console.WriteLine("Introduzca un inicio: ");
            string dato = Console.ReadLine();
            int inicio = int.Parse(dato);
            Console.WriteLine("Introduzca un número final");
            dato = Console.ReadLine();
            int fin = int.Parse(dato);
            for (int i = inicio; i <= fin; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void ConjeturaCollatz()
        {
            Console.WriteLine("Introduzca número");
            string dato = Console.ReadLine();
            int numero = int.Parse(dato);
            while (numero != 1)
            {
                if (numero % 2 == 0)
                {
                    //PAR
                    numero = numero / 2;
                }
                else
                {
                    //IMPAR
                    numero = numero * 3 + 1;
                }
                Console.WriteLine(numero);
            }
        }

        static void EjemploBucles()
        {
            int contador = 1;
            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador += 1;
            }

            //EJEMPLO BUCLE INVERSO
            for (int i = 10; i > 0; i--) {
                Console.WriteLine(i);
            }
        }

        static void DiaNacimientoSemana()
        {
            Console.WriteLine("Introduzca el día");
            string dato = Console.ReadLine();
            int dia = int.Parse(dato);
            Console.WriteLine("Introduzca mes");
            dato = Console.ReadLine();
            int mes = int.Parse(dato);
            Console.WriteLine("Introduzca el año");
            dato = Console.ReadLine();
            int anyo = int.Parse(dato);
            if (mes == 1)
            {
                mes = 13;
                anyo -= 1;
            }else if (mes == 2)
            {
                mes = 14;
                anyo -= 1;
            }
            int op1 = ((mes + 1) * 3) / 5;
            int op2 = anyo / 4;
            int op3 = anyo / 100;
            int op4 = anyo / 400;
            int op5 = dia + (mes * 2) + anyo + op1 + op2 - op3 + op4 + 2;
            int op6 = op5 / 7;
            int resultado = op5 - (op6 * 7);
            if (resultado == 0)
            {
                Console.WriteLine("SABADO");
            }
            else if (resultado == 1)
            {
                Console.WriteLine("DOMINGO");
            }
            else if (resultado == 2)
            {
                Console.WriteLine("LUNES");
            }
            else if (resultado == 3)
            {
                Console.WriteLine("MARTES");
            }
            else if (resultado == 4) {
                Console.WriteLine("MIERCOLES");
            }else if (resultado == 5)
            {
                Console.WriteLine("JUEVES");
            }else if (resultado == 6)
            {
                Console.WriteLine("VIERNES");
            }
            else
            {
                Console.WriteLine("RESULTADO INCORRECTO " + resultado);
            }
        }

        static void NumeroMayorMenor()
        {
            //DECLARAMOS TRES VARIABLES
            int mayor = 0, menor = 0, intermedio = 0;
            Console.WriteLine("Introduzca número 1:");
            string dato = Console.ReadLine();
            int numero1 = int.Parse(dato);
            Console.WriteLine("Introduzca número 2:");
            dato = Console.ReadLine();
            int numero2 = int.Parse(dato);
            Console.WriteLine("Introduzca número 3:");
            dato = Console.ReadLine();
            int numero3 = int.Parse(dato);
            if (numero1 >= numero2 && numero1 >= numero3)
            {
                mayor = numero1;
            }else if (numero2 >= numero1 && numero2 >= numero3)
            {
                mayor = numero2;
            }
            else
            {
                mayor = numero3;
            }
            if (numero1 <= numero2 && numero1 <= numero3)
            {
                menor = numero1;
            }else if (numero2 <= numero1 && numero2 <= numero3)
            {
                menor = numero2;
            }
            else
            {
                menor = numero3;
            }
            int suma = numero1 + numero2 + numero3;
            intermedio = suma - mayor - menor;
            Console.WriteLine("Mayor: " + mayor);
            Console.WriteLine("Menor: " + menor);
            Console.WriteLine("Intermedio: " + intermedio);
        }

        //CREAMOS NUESTROS PROPIOS METODOS
        static void PositivoNegativo()
        {
            Console.WriteLine("Programa positivo negativo cero");
            //PEDIMOS UNA VARIABLE Y LA RECUPERAMOS COMO STRING
            string dato = Console.ReadLine();
            //CONVERTIMOS EL DATO STRING EN INT
            int numero = int.Parse(dato);
            if (numero > 0)
            {
                Console.WriteLine("Positivo");
            }
            else if (numero == 0) {
                Console.WriteLine("Cero");
            }
            else
            {
                Console.WriteLine("Negativo");
            }
        }
    }
}

