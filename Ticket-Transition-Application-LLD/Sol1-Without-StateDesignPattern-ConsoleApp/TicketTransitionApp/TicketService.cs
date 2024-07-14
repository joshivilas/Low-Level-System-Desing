
using TicketTransition;

public class TicketService
{
    public Ticket createTicket(string description, User createdBy)
    {
        System.Console.WriteLine($"Creating ticket by user {createdBy.Name}, with details - {description} ");
        return new Ticket(description, createdBy);
    }

    public void ChangeTicketState(Ticket ticket, TicketState newState)
    {
        TicketState oldTicketState = ticket.TicketState;
        if (oldTicketState == TicketState.Analysis)
        {
            if (newState == TicketState.Analysis)
            {
                System.Console.WriteLine("Cant change to same state");
            }
            else if (newState == TicketState.Review)
            {
                System.Console.WriteLine($"{ticket.Description} moved from {ticket.TicketState} -> {newState}");
                ticket.TicketState = newState;
            }
            else if (newState == TicketState.Done)
            {
                System.Console.WriteLine($"{ticket.Description} moved from {ticket.TicketState} -> {newState}");
                ticket.TicketState = newState;
            }
        }
        else if (oldTicketState == TicketState.Review)
        {
            if (newState == TicketState.Review)
            {
                System.Console.WriteLine("Cant change to same state");
            }
            else if (newState == TicketState.Analysis)
            {
                System.Console.WriteLine($"{ticket.Description} moved from {ticket.TicketState} -> {newState}");
                ticket.TicketState = newState;
            }
            else if (newState == TicketState.Done)
            {
                System.Console.WriteLine($"{ticket.Description} moved from {ticket.TicketState} -> {newState}");
                ticket.TicketState = newState;
            }
        }
        else if (oldTicketState == TicketState.Done)
        {
            if (newState == TicketState.Done)
            {
                System.Console.WriteLine("Cant change to same state");
            }
            else if (newState == TicketState.Analysis)
            {
                System.Console.WriteLine($"{ticket.Description} moved from {ticket.TicketState} -> {newState}");
                ticket.TicketState = newState;
            }
            else if (newState == TicketState.Review)
            {
                System.Console.WriteLine($"{ticket.Description} moved from {ticket.TicketState} -> {newState}");
                ticket.TicketState = newState;
            }
        }
    }

}
