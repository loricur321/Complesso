using System;

namespace curzi.lorenzo._4H.Complesso
{
    class Program
    {
        class Complesso
        {
            public double reale;           //parte reale del numero
            public double immaginario;     //parte immaginaria del numero


            public Complesso(double a, double b)
            {
                reale = a;
                immaginario = b;
            }

            //public void StampaNumero()
            //{
            //    Console.WriteLine($"Il numero complesso è: {reale} + {immaginario}i");
            //}


            public void Addizione(Complesso W1, Complesso W2)
            {
                reale = W1.reale + W2.reale;
                immaginario = W1.immaginario + W2.immaginario;
            }

            public void Sottrazione(Complesso W1, Complesso W2)
            {
                reale = W1.reale - W2.reale;
                immaginario = W1.immaginario - W2.immaginario;
            }

            public void Moltiplicazione(Complesso W1, Complesso W2)
            {
                reale = (W1.reale * W2.immaginario) - (W1.immaginario * W2.immaginario);
                immaginario = (W1.immaginario * W2.reale) + (W2.immaginario * W1.reale);
            }

            public void Divisione(Complesso W1, Complesso W2)
            {
                reale = ((W1.reale * W2.reale) + (W1.immaginario * W2.immaginario)) / (Math.Pow(W2.reale, 2) + Math.Pow(W2.immaginario, 2));
                immaginario = ((W1.immaginario * W2.reale) - (W1.reale * W2.immaginario)) / (Math.Pow(W2.reale, 2) + Math.Pow(W2.immaginario, 2));
            }
        }



        static void Main(string[] args)
        {
            //Si vuole realizzare un programma con l'interfaccia console che esegua le 4 operazioni arirmetiche sui numeri complessi.
            //Il funzionamento consiste nell'inserire i due operandi, scegliere l'operazione desiderata(attraverso un semplice menù a video) e infine dare il risultato.

            Console.WriteLine("Programma complesso di Lorenzo Curzi, 4H");

            double reale1; //parte reale del primo numero
            double immaginaria1; //parte immagianria del primo numero
            do
            {
                Console.WriteLine("Inserire la parte reale del primo numero complesso:");    
                string strReale1 = Console.ReadLine();
                double.TryParse(strReale1, out reale1);
            } while (reale1 < 0);

            do
            {
                Console.WriteLine("Inserire la parte immaginaria del primo numero complesso:");
                string strImmaginaria1 = Console.ReadLine();
                double.TryParse(strImmaginaria1, out immaginaria1);
            } while (immaginaria1 < 0);


            double reale2; //parte reale del secondo numero
            double immaginaria2; //parte immagianria del secondo numero
            do
            {
                Console.WriteLine("Inserire la parte reale del secondo numero complesso:");
                string strReale2 = Console.ReadLine();
                double.TryParse(strReale2, out reale2);
            } while (reale2 < 0);

            do
            {
                Console.WriteLine("Inserire la parte immaginaria del secondo numero complesso:");
                string strImmaginaria2 = Console.ReadLine();
                double.TryParse(strImmaginaria2, out immaginaria2);
            } while (immaginaria2 < 0);



            Complesso Z1 = new Complesso(reale1, immaginaria1);
            Complesso Z2 = new Complesso(reale2, immaginaria2);

            int n = 0; //operazione da eseguire

            while(true)//ciclo per chiedere l'operazione da eseguire
            {
                Console.WriteLine("Che operazione si desidera svolegere?");
                Console.WriteLine("1: addizione");
                Console.WriteLine("2: sottrazione");
                Console.WriteLine("3: moltiplicazione");
                Console.WriteLine("4: divisione");

                string strN = Console.ReadLine(); //richiedo il numero

                int.TryParse(strN, out n);

                if(n == 1 || n == 2 || n == 3 || n == 4)
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Numero sbagliato! Assciurarsi di selezionare la operazione desiderata");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            Complesso risultato = new Complesso(0, 0);

            //a seconda della scelta dell'utente chiamo la funzione richiesta
            if(n == 1)
            {
                risultato.Addizione(Z1, Z2);
            }
            else if(n == 2)
            {
                risultato.Sottrazione(Z1, Z2);
            }
            else if(n == 3)
            {
                risultato.Moltiplicazione(Z1, Z2);
            }
            else
            {
                risultato.Divisione(Z1, Z2);
            }


            Console.WriteLine($"Il risultato è: {risultato.reale} + {risultato.immaginario}i");

        }
    }
}
