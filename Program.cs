using System;
using LibrarySystem.Models;
using LibrarySystem.Controllers;
using LibrarySystem.Views;

namespace LibrarySystem
{
    class Program
    {
        static void Main()
        {
            var libraryController = new LibraryController();
            var libraryView = new LibraryView();

            
            var member = new Member { Name = "Dimitris Panagios" };
            member.Activate();

            var book = new TextBook { Title = "C# in a nutsell", Author = "Dimitris Panagios", Editor = "Editor A" };
            var magazine = new TextBook { Title = "Science Monthly", Author = "Alice Smith", Editor = "Editor B" };

            
            libraryController.RentItem(member, book);
            libraryController.RentItem(member, magazine);

            
            libraryView.DisplayMemberInfo(member);
            libraryView.DisplayRentalStatus(book);

            
            libraryController.ReturnItem(member, book);
            libraryView.DisplayRentalStatus(book);

            Console.ReadLine();
        }
    }
}
