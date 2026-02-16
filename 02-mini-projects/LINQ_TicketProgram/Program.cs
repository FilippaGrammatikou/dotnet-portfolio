using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LINQ_TicketProgram;

public static class Program
{
    public static void Main()
    {
        var tickets = Ticket_DB.GetTicketData();

        var openTickets = tickets.Where(t => t.Status == "Open").ToList();

        Console.WriteLine("The current Open tickets are: ");
        Console.WriteLine($"COUNT: {openTickets.Count}");
        Console.WriteLine();

        foreach (var ticket in openTickets)
        {
            Console.WriteLine($"{ticket.Id}: {ticket.Name}");
        }

        Console.ReadKey();
    }
}