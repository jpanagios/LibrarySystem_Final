using LibrarySystem.Models;
using LibrarySystem.Services;

namespace LibrarySystem.Controllers
{
    public class LibraryController
    {
        private readonly RentalService _rentalService = new RentalService();

        public void RentItem(Member member, Publication item)
        {
            _rentalService.RentItem(member, item);
        }

        public void ReturnItem(Member member, Publication item)
        {
            _rentalService.ReturnItem(member, item);
        }
    }
}
