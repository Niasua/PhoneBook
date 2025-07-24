using PhoneBook.Models;
using Spectre.Console;

namespace PhoneBook.UI;

public static class ContactDisplay
{
    public static void ShowContacts(List<Contact> contacts)
    {
        var table = new Table();
            table.Border(TableBorder.Rounded);
            table.AddColumn("[yellow]Name[/]");
            table.AddColumn("[blue]Email[/]");
            table.AddColumn("[green]Phone Number[/]");

        foreach (var contact in contacts)
        {
            table.AddRow(
                contact.Name.ToString(),
                contact.Email.ToString(),
                contact.PhoneNumber.ToString()
                );
        }

        AnsiConsole.Write(table);
    }

    public static void ShowContact(Contact contact)
    {
        var table = new Table();
        table.Border(TableBorder.Rounded);
        table.AddColumn("[yellow]Name[/]");
        table.AddColumn("[blue]Email[/]");
        table.AddColumn("[green]Phone Number[/]");

        table.AddRow(
            contact.Name.ToString(),
            contact.Email.ToString(),
            contact.PhoneNumber.ToString()
            );
        
        AnsiConsole.Write(table);
    }
}
