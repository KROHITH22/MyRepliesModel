using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

public class MyRepliesModel : PageModel
{
    [BindProperty]
    public string ReplyText { get; set; }

    public TicketDetails TicketDetails { get; private set; }

    public void OnGet(int ticketId)
    {
        // Replace this with your logic to fetch ticket details based on the ticketId.
        TicketDetails = GetTicketDetails(ticketId);
    }

    public IActionResult OnPost()
    {
        if (ModelState.IsValid)
        {
            // Process and store the user's reply.
            string reply = ReplyText;

            // Optionally, redirect the user to a confirmation page.
            return RedirectToPage("ReplySubmitted");
        }

        // If the reply is not valid, return to the page for further input.
        return Page();
    }

    private TicketDetails GetTicketDetails(int ticketId)
    {
        // Replace this with your logic to retrieve ticket details from your data source.
        // You should return an instance of TicketDetails based on the provided ticketId.
        throw new NotImplementedException();
    }
}

public class TicketDetails
{
    public string Subject { get; set; }
    public string QueryBody { get; set; }
    public DateTime DateCreated { get; set; }
}

