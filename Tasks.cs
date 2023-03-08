using System;

public class Program
{
    public static void Main()
    {
        int studentTicketSold = 0;
        int standartTicketSold = 0;
        int kidsTicketSold = 0;
        int totalTicketsSold = 0;

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "Finish")
            {
                break;
            }
            string filmTitle = input;

            int seatsAvaible = int.Parse(Console.ReadLine());

            int ticketSoldForFilm = 0;

            while (ticketSoldForFilm < seatsAvaible)
            {
                string ticketType = Console.ReadLine();

                if (ticketType == "End")
                {
                    break;
                }

                ticketSoldForFilm++;
                totalTicketsSold++;

                if (ticketType == "student")
                {
                    studentTicketSold++;
                }
                else if (ticketType == "standart")
                {
                    standartTicketSold++;
                }
                else if (ticketType == "kid")
                {
                    kidsTicketSold++;
                }
            }
            double percFull = ticketSoldForFilm / (seatsAvaible * 1.00) * 100;
            System.Console.WriteLine($"{filmTitle} - {percFull:f2}% full.");
        }
        System.Console.WriteLine($"Total tickets: {totalTicketsSold}");

        double percsStudentTickets = studentTicketSold / (totalTicketsSold * 1.00) * 100;
        System.Console.WriteLine($"{percsStudentTickets:f2}% student tickets.");
        double percStandartTickets = standartTicketSold / (totalTicketsSold * 1.00) * 100;
        System.Console.WriteLine($"{percStandartTickets:f2}% standart tickets.");
        double percKidsTickets = kidsTicketSold / (totalTicketsSold * 1.00) * 100;
        System.Console.WriteLine($"{percKidsTickets:f2}% kids tickets.");
    }
}