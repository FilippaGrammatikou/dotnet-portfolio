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

        var openTickets = tickets.Where(t => t.Status == TicketStatus.Open).ToList();
        Console.WriteLine("The current Open tickets are: ");
        Console.WriteLine($"COUNT: {openTickets.Count}");
        Console.WriteLine();

        foreach (var ticket in openTickets)
        {
            Console.WriteLine($"{ticket.Id}: {ticket.Name}");
        }
        Console.WriteLine();
        Console.WriteLine();

        //New print result
        var latestFirst = tickets.OrderByDescending(t => t.dOC);
        Console.WriteLine("The top 3 latest tickets are: ");
        Console.WriteLine();

        foreach(var ticket in latestFirst.Take(3)) // only picks 3 results
        {
            Console.WriteLine($"{ticket.Id}: {ticket.dOC} {ticket.Status} - {ticket.Name}");
        }
        Console.WriteLine();
        Console.WriteLine();

        //Ticket Summaries
        var ticketSummary = tickets
            .Select(t => (Id: t.Id, Name: t.Name, AgeDays: (DateTime.Today - t.dOC).Days))
            .OrderByDescending(x => x.AgeDays).ToList();
        Console.WriteLine("Summaries(DOC descending based): ");
        foreach (var ticket in ticketSummary)
        {
            Console.WriteLine($"#{ticket.Id} - {ticket.AgeDays} Days Ago - {ticket.Name}");
        }
        Console.WriteLine();
        Console.WriteLine();

        //Existing or Missing tickets check
        /* var maybeTicket = FindById(tickets, 999);
        if (maybeTicket != null)
        {
            Console.WriteLine($"Find maybeTicket: FOUND #{maybeTicket.Id} - {maybeTicket.Name}");
        }
        else
        {
            Console.WriteLine("Find maybeTicket: NOT FOUND");
        }*/

        //Better coding practice
        var ticketLookup = FindById(tickets, 999);
        Console.WriteLine( ticketLookup != null
            ? $"Find Ticket: FOUND #{ticketLookup.Id} - {ticketLookup.Name}" 
            : "Find Ticket:  NOT FOUND");
        Console.WriteLine();
        Console.WriteLine();

        //Query: tickets of the last 7 days
        var recentTickets = tickets
            .Where(t => t.dOC >= DateTime.Today.AddDays(-7))
            .ToList();

        Console.WriteLine("Recent Tickets (Last 7 Days): ");
        foreach(var ticket in recentTickets)
        {
            Console.WriteLine($"#{ticket.Id} {ticket.dOC: dd/MM/yyyy} {ticket.Status} - {ticket.Name}");
        }
        Console.WriteLine();
        Console.WriteLine();

        //Query: Group By Status and print counts
        var countsByStatus = tickets
            .GroupBy(t => t.Status)
            .Select(g => new {Status = g.Key, Count = g.Count() })
            .ToList();

        Console.WriteLine("Count by Status: ");
        foreach (var ticket in countsByStatus)
        {
            Console.WriteLine($"#{ticket.Status}: ({ticket.Count})");
        }

        Console.ReadKey();
    }

    //FirstOrDefault
    static Ticket? FindById(List<Ticket> tickets, int id)
    {
        return tickets.FirstOrDefault(t => t.Id == id);
    }
}