
using System;
class TicketNode
{
    public int TicketId;
    public string CustomerName;
    public string MovieName;
    public string SeatNumber;
    public DateTime BookingTime;
    public TicketNode Next;

    public TicketNode(int ticketId, string customerName, string movieName, string seatNumber)
    {
        TicketId = ticketId;
        CustomerName = customerName;
        MovieName = movieName;
        SeatNumber = seatNumber;
        BookingTime = DateTime.Now;
        Next = this;
    }
}

class TicketReservation
{
    private TicketNode last;
    private int count;

    public void AddTicket(int ticketId, string customerName, string movieName, string seatNumber)
    {
        TicketNode newTicket = new TicketNode(ticketId, customerName, movieName, seatNumber);
        if (last == null)
        {
            last = newTicket;
        }
        else
        {
            newTicket.Next = last.Next;
            last.Next = newTicket;
            last = newTicket;
        }
        count++;
    }

    public void RemoveTicket(int ticketId)
    {
        if (last == null) return;

        TicketNode current = last.Next;
        TicketNode prev = last;
        do
        {
            if (current.TicketId == ticketId)
            {
                if (current == last && current.Next == last) last = null;
                else
                {
                    prev.Next = current.Next;
                    if (current == last) last = prev;
                }
                count--;
                return;
            }
            prev = current;
            current = current.Next;
        } while (current != last.Next);
    }

    public void DisplayTickets()
    {
        if (last == null)
        {
            Console.WriteLine("no tickets booked");
            return;
        }
        TicketNode current = last.Next;
        do
        {
            Console.WriteLine(current.TicketId + "\t" + current.CustomerName + "\t" + current.MovieName + "\t" + current.SeatNumber + "\t" + current.BookingTime);
            current = current.Next;
        } while (current != last.Next);
    }

    public void SearchTicket(string query)
    {
        if (last == null)
        {
            Console.WriteLine("no tickets found");
            return;
        }
        TicketNode current = last.Next;
        do
        {
            if (current.CustomerName == query || current.MovieName == query)
            {
                Console.WriteLine(current.TicketId + "\t" + current.CustomerName + "\t" + current.MovieName + "\t" + current.SeatNumber + "\t" + current.BookingTime);
                return;
            }
            current = current.Next;
        } while (current != last.Next);
        Console.WriteLine("ticket not found");
    }

    public void CountTickets()
    {
        Console.WriteLine("total booked tickets: " + count);
    }
}

class Program
{
    static void Main()
    {
        TicketReservation system = new TicketReservation();
        system.AddTicket(1, "lallu", "matru bijli ka mandola", "A1");
        system.AddTicket(2, "bablu", "nosferatu", "B2");

        system.DisplayTickets();
        system.CountTickets();

        system.RemoveTicket(1);
        system.DisplayTickets();
        system.CountTickets();

        system.SearchTicket("matru bijli ka mandola");
        system.SearchTicket("nosferatu");
    }
}



