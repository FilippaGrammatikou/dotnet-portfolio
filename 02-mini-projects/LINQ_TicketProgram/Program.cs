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
        var latestFirst = tickets.OrderByDescending(t => t.dOC);

        Console.WriteLine("The current Open tickets are: ");
        Console.WriteLine($"COUNT: {openTickets.Count}");
        Console.WriteLine();

        foreach (var ticket in openTickets)
        {
            Console.WriteLine($"{ticket.Id}: {ticket.Name}");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        
        //New print result
        Console.WriteLine("The top 3 latest tickets are: ");
        Console.WriteLine()
            ;
        foreach(var ticket in latestFirst.Take(3)) // only picks 3 results
        {
            Console.WriteLine($"{ticket.Id}: {ticket.dOC} {ticket.Status} - {ticket.Name}");
        }


        Console.ReadKey();
    }
}