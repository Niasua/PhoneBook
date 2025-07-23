using Spectre.Console;
using System.ComponentModel.DataAnnotations;

namespace PhoneBook.UI;

public class Menu
{
    public static ContactService contactService { get; set; } = new();
    public void Show()
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
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

                    exit = true;

                    break;
            }
        }
    }

    private static void AddContact()
    {
        while (true)
        {
            AnsiConsole.MarkupLine("[green]Add Contact [red](Type 'zzz' to return to menu)[/][/]\n");

            AnsiConsole.MarkupLine("[green]Name:[/]");
            var name = Console.ReadLine();
            if (name.ToLower() == "zzz") break;
            if (string.IsNullOrEmpty(name)) continue;

            AnsiConsole.MarkupLine("\n[green]Email:[/]");
            var email = Console.ReadLine();
            if (email.ToLower() == "zzz") break;
            if (!Validator.Validator.IsValidEmail(email))
            {
                AnsiConsole.MarkupLine("[red]Invalid email format![/]");
                continue;
            }

            AnsiConsole.MarkupLine("\n[green]Phone Number:[/]");
            var pNumber = Console.ReadLine();
            if (pNumber.ToLower() == "zzz") break;
            if (!Validator.Validator.IsValidPhone(pNumber))
            {
                AnsiConsole.MarkupLine("[red]Invalid phone number! Use only digits, dashes, or spaces.[/]");
                continue;
            }

            var contact = new Models.Contact
            {
                Name = name,
                Email = email,
                PhoneNumber = pNumber
            };

            if (contactService.AddContact(contact))
            {
                AnsiConsole.MarkupLine("[green]Contact succesfully added![/]");
                AnsiConsole.MarkupLine("[grey]Press any key to return to menu...[/]");
                Console.ReadKey();
                break;   
            }
            else
            {
                AnsiConsole.MarkupLine("[red]Contact cannot be added![/]");
            }
        }
    }
    private static void ViewContacts()
    {
        throw new NotImplementedException();
    }
    private static void EditContact()
    {
        throw new NotImplementedException();
    }
    private static void DeleteContact()
    {
        throw new NotImplementedException();
    }
}
