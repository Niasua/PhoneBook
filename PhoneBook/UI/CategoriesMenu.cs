using PhoneBook.Services;
using Spectre.Console;

namespace PhoneBook.UI;

public class CategoriesMenu
{
    public static ContactService contactService { get; set; } = new();
    public static CategoryService categoryService { get; set; } = new();

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
                    "Add Category", "View Categories", "Edit Categories","Delete Categories", "Back"
                }));

            switch (option)
            {
                case "Add Contact":

                    AddCategory();

                    break;

                case "View Contacts":

                    ViewCategories();

                    break;

                case "Edit Contact":

                    EditCategory();

                    break;

                case "Delete Contact":

                    DeleteCategory();

                    break;

                case "Exit":

                    exit = true;

                    break;
            }
        }
    }

    private void DeleteCategory()
    {
        throw new NotImplementedException();
    }

    private void EditCategory()
    {
        throw new NotImplementedException();
    }

    private void ViewCategories()
    {
        throw new NotImplementedException();
    }

    private void AddCategory()
    {
        throw new NotImplementedException();
    }
}
