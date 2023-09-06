using System.Security.Cryptography;

namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool play = true;
            string userInput;

            while( play )
            {
                Console.WriteLine("***** Menu *****");
                Console.WriteLine("Digita un numero da 1 a 10 per selezionare lo snack da eseguire. Digita 'exit' per uscire.");
                userInput = Console.ReadLine();
                
                switch (userInput)
                {
                    case "1":
                        //Snack 1: L’utente inserisce due numeri in successione.Il software stampa il maggiore.

                        int firstNumber;
                        int secondNumber;

                        Console.Write("Digita il primo numero: ");
                        firstNumber = int.Parse(Console.ReadLine());

                        Console.Write("Digita il secondo numero: ");
                        secondNumber = int.Parse(Console.ReadLine());

                        if (firstNumber > secondNumber)
                        {
                            Console.WriteLine($"Il numero maggiore è {firstNumber}");
                        }
                        else if (firstNumber < secondNumber)
                        {
                            Console.WriteLine($"Il numero maggiore è {secondNumber}");
                        }
                        else
                        {
                            Console.WriteLine("I numeri sono uguali!");
                        }
                        Console.WriteLine("");
                        break;
                    case "2":

                        //Snack 2 : L’utente inserisce due parole in successione.Il software stampa prima la parola più corta, poi la parola più lunga.

                        string firstWord;
                        string secondWord;

                        Console.WriteLine("Digita la prima parola");
                        firstWord = Console.ReadLine();
                        Console.WriteLine("Digita la seconda parola");
                        secondWord = Console.ReadLine();

                        if (firstWord.Length == secondWord.Length)
                        {
                            Console.WriteLine($"Le parole {firstWord} e {secondWord} hanno la stessa lunghezza.");
                        }
                        else
                        {
                            Console.WriteLine($"La parola più corta: {(firstWord.Length < secondWord.Length ? firstWord : secondWord)}");
                            Console.WriteLine($"La parola più lunga: {(firstWord.Length < secondWord.Length ? secondWord : firstWord)}");
                        }
                        Console.WriteLine("");
                        break;
                    case "3":

                        //Snack 3: Il software deve chiedere per 10 volte all’utente di inserire un numero.Il programma stampa la somma di tutti i numeri inseriti.

                        int userNumbersSum = 0;

                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine($"Inserisci il {i + 1} numero");
                            userNumbersSum += int.Parse(Console.ReadLine());
                        }

                        Console.WriteLine("La somma è : " + userNumbersSum);
                        Console.WriteLine("");
                        break;
                    case "4":

                        //Snack 4: Calcola la somma e la media dei numeri da 2 a 10.

                        int numbersCounter = 0;
                        int numbersSum = 0;

                        for (int i = 2; i <= 10; i++)
                        {
                            numbersSum += i;
                            numbersCounter++;
                        }

                        float numbersMean = (float)numbersSum / (float)numbersCounter;

                        Console.WriteLine($"La somma dei numeri da 2 a 10 vale {numbersSum}, la media vale {numbersMean}");

                        Console.WriteLine("");
                        break;
                    case "5":

                        //Snack 5: Il software chiede all’utente di inserire un numero.Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.
                        int userNumber;

                        Console.WriteLine("Digita un numero");

                        userNumber = int.Parse(Console.ReadLine());

                        Console.WriteLine(userNumber % 2 == 0 ? userNumber : (userNumber + 1));

                        Console.WriteLine("");
                        break;
                    case "6":

                        //Snack 6: In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.

                        string[] invitedGuests =
                        {
                            "Giorgio",
                            "Giada",
                            "Mario",
                            "Cristina",
                            "Francesco",
                            "Stefania"
                        };
                        string guestName;

                        Console.WriteLine("Controllo se sei in lista, come ti chiami?");

                        guestName = Console.ReadLine();

                        int invitedGuestsIndex = 0;
                        bool guestNameFound = false;

                        while (!guestNameFound && (invitedGuestsIndex == (invitedGuests.Length - 1)))
                        {

                            if (guestName == invitedGuests[invitedGuestsIndex])
                            {
                                Console.WriteLine("Trovato!");
                                guestNameFound = true;
                            }

                            invitedGuestsIndex++;
                        }

                        if (guestNameFound)
                        {
                            Console.WriteLine("Prego, puoi passare!");
                        }
                        else
                        {
                            Console.WriteLine("Mi spiace, non sei in lista.");
                            if (guestName == "Davide")
                            {
                                Console.WriteLine("Solo per questa volta chiudiamo un occhio ;)");
                            }

                        }

                        Console.WriteLine("");
                        break;
                    case "7":

                        //Snack 7: Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.

                        int[] numbersArray = new int[6];

                        for (int i = 0; i < numbersArray.Length; i++)
                        {
                            Console.WriteLine("Digita un numero da inserire");

                            userInput = Console.ReadLine();

                            userNumber = int.Parse(userInput);

                            if (userNumber % 2 != 0)
                            {
                                numbersArray[i] = userNumber;
                                Console.WriteLine("Inserito.");
                            }
                        }


                        Console.WriteLine("");
                        break;
                    case "8":

                        //Snack 8: Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.

                        int[] intNumbersArray =
                        {
                            5,
                            40,
                            23,
                            18,
                            85,
                            59,
                            27
                        };

                        int intNumbersSum = 0;

                        for (int i = 0; i < intNumbersArray.Length; i++)
                        {
                            if (i % 2 != 0)
                            {
                                intNumbersSum += intNumbersArray[i];
                            }
                        }

                        Console.WriteLine("La somma degli elementi in posizione dispari è: " + intNumbersSum);

                        Console.WriteLine("");
                        break;
                    case "9":

                        //Snack 9: Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.

                        int[] userNumbersArray = new int[50];
                        int userNumbersArrayIndex = 0;
                        userNumbersSum = 0;

                        while (userNumbersSum < 50 && userNumbersArrayIndex != 50)
                        {
                            Console.WriteLine("Digita un numero:");
                            userNumber = int.Parse(Console.ReadLine());
                            userNumbersArray[userNumbersArrayIndex] = userNumber;
                            userNumbersSum += userNumber;
                            userNumbersArrayIndex++;
                            Console.WriteLine("La somma attuale è: " + userNumbersSum);
                        }

                        Console.WriteLine("");
                        break;
                    case "10":

                        //Snack 10: Fai inserire un numero, che chiameremo N, all’utente.Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.Ogni volta che ne crei uno, stampalo a schermo.

                        Console.WriteLine("Digita un numero per decidere quanti array generare");
                        int N = int.Parse(Console.ReadLine());

                        for (int i = 0; i <= N; i++)
                        {
                            int[] randomNumbersArray = new int[10];

                            for (int j = 0; j < 10; j++)
                            {
                                randomNumbersArray[j] = new Random().Next(1, 101);
                            }

                            Console.Write($"{N}° Array: [");
                            for (int k = 0; k < 10; k++)
                            {
                                Console.Write($" {randomNumbersArray[k]} ");
                            }
                            Console.WriteLine("]");
                        }
                        Console.WriteLine("");
                        break;
                    case "exit":
                        Console.WriteLine("Alla prossima!");
                        play = false;

                        break;
                    default:
                        Console.WriteLine("Comando non riconosciuto.");
                        break;
                }
            }

        }
    }
}