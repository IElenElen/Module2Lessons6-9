using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace Module2Lessons_6_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operatory, Pętle, Instrukcje soku.");
            Console.WriteLine();
            Console.WriteLine("Cześć. Podaj liczbę przeczytanych książek w ostatnich 3 miesiącach.");
            Console.WriteLine();

            string? userResponse = Console.ReadLine();

            if (!int.TryParse(userResponse, out int numberOfBooks) || numberOfBooks <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("W ostatnich 3 miesiącach nie przeczytałeś żadnej książki.");
                return;
            }

            int totalPages = 0;            

            for (int i = 0; i < numberOfBooks; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Podaj liczbę przeczytanych stron danej książki lub naciśnij Enter,"
                    + " jeśli to już wszystkie przeczytane książki.");
                Console.WriteLine();

                string? userAnswerPagesOfEachBook = Console.ReadLine();

                if (string.IsNullOrEmpty(userAnswerPagesOfEachBook))
                {
                    break;
                }

                int.TryParse(userAnswerPagesOfEachBook, out int numberOfPages);

                if (numberOfPages <= 0) 
                {
                    Console.WriteLine();
                    Console.WriteLine("Błąd. Wprowadzono nieprawidlową liczbę stron. Popraw.");
                    i--;
                    continue;
                }

                if (numberOfPages < 51)
                {
                    Console.WriteLine();
                    Console.WriteLine("Pamiętaj, że książka ma więcej niż 50 stron. Liczby stron broszury nie wliczamy.");
                    continue;
                }
                totalPages += numberOfPages;
            }
            Console.WriteLine();
            Console.WriteLine($"Suma stron przeczytanych książek w ostatnich 3 miesiącach to: {totalPages}");
            Console.WriteLine();
        }
    }
}
