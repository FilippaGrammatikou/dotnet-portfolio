using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LINQ_TicketProgram
{
    internal enum TicketStatus
    {
        Open, Ongoing, Closed
    }
    internal class Ticket
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public TicketStatus Status { get; set; }
        public DateTime dOC { get; set; }
        public Ticket(int id, string name, TicketStatus status, DateTime CreatedAt)
        {
            Id = id;
            Name = name;
            Status = status;
            dOC = CreatedAt;
        }
    }
}