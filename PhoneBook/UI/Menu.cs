using Spectre.Console;
using System.ComponentModel.DataAnnotations;

namespace PhoneBook.UI;

public static class Menu
{
    public static void ShowMenu()
    {
        var option = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .Title("[blue]Phone Book Menu[/]")
            .AddChoices(new[]
            {
                "Add Contact", "View Contacts", "Edit Contact","Delete Contact", "Exit"
            }));

        switch (option)
        {
            case "Add Contact":

                AddContact();

                break;

            case "View Contacts":

                ViewContacts();

                break;

            case "Edit Contact":

                EditContact();

                break;

            case "Delete Contact":

                DeleteContact();

                break;

            case "Exit":

                break;
        }
    }

    private static void DeleteContact()
    {
        throw new NotImplementedException();
    }

    private static void EditContact()
    {
        throw new NotImplementedException();
    }

    private static void ViewContacts()
    {
        throw new NotImplementedException();
    }

    private static void AddContact()
    {
        throw new NotImplementedException();
    }
}
