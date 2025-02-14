using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine(" BENVENUTO NEL CALCOLATORE DELL'IMPOSTA DA VERSARE");
            Console.WriteLine("==================================================\n");


            Console.Write("Inserisci il nome del Contribuente: ");
            string nome = Console.ReadLine();

            Console.Write("Inserisci il cognome del Contribuente: ");
            string cognome = Console.ReadLine();

            DateTime dataDiNascita;
            while (true)
            {
                Console.Write("Inserisci la data di nascita (gg-mm-yyyy): ");
                if (DateTime.TryParse(Console.ReadLine(), out dataDiNascita))
                {
                    break;
                }
                Console.WriteLine("Data non valida, riprova.");
            }

            char sesso;
            while (true)
            {
                Console.Write("Inserisci il sesso (M/F): ");
                if (char.TryParse(Console.ReadLine().ToUpper(), out sesso) && (sesso == 'M' || sesso == 'F'))
                {
                    break;
                }
                Console.WriteLine("Sesso non valido, inserisci M o F.");
            }

            Console.Write("Inserisci il codice fiscale: ");
            string codiceFiscale = Console.ReadLine();

            Console.Write("Inserisci il comune di residenza: ");
            string comuneResidenza = Console.ReadLine();

            decimal redditoAnnuale;
            while (true)
            {
                Console.Write("Inserisci il reddito annuale (separare i centesimi con una virgola): ");
                if (decimal.TryParse(Console.ReadLine(), out redditoAnnuale) && redditoAnnuale > 0)
                {
                    break;
                }
                Console.WriteLine("Reddito non valido, riprova.");
            }

            Contribuente contribuente = new Contribuente(nome, cognome, dataDiNascita, codiceFiscale, sesso, comuneResidenza, redditoAnnuale);

            Console.WriteLine("\n==================================================");
            Console.WriteLine(" RIEPILOGO DATI CONTRIBUENTE ");
            Console.WriteLine("==================================================");
            Console.WriteLine(contribuente);
            Console.WriteLine("\n==================================================");

            Console.Write("\nVuoi calcolare l'imposta per un altro contribuente? (S/N): ");
            string risposta = Console.ReadLine().ToUpper();
            if (risposta != "S")
            {
                Console.WriteLine("Chiusura del programma...");
                break;
            }
        }
    }
}
