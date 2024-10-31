using System;
using LibrarySystem.Models;

namespace LibrarySystem.Views
{
    public class LibraryView
    {
        public void DisplayMemberInfo(Member member)
        {
            Console.WriteLine($"Member: {member.Name}");
            Console.WriteLine("Rented Items:");
            foreach (var item in member.RentedItems)
            {
                Console.WriteLine($"- {item.Title} by {item.Author}");
            }
        }

        public void DisplayRentalStatus(Publication item)
        {
            string status = item.IsRented ? "currently rented" : "available";
            Console.WriteLine($"{item.Title} is {status}.");
        }
    }
}
