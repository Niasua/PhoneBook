using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using PhoneBook.Models;

namespace PhoneBook.Data;

public class PhoneBookContext : DbContext
{
    public DbSet<Contact> Contacts { get; set; }
    public string DbPath { get; set; }

    public PhoneBookContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "phone_book.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite($"Data source={DbPath}");
}
