using LibrarySystem.Models;

namespace LibrarySystem.Services
{
    public class RentalService
    {
        public void RentItem(Member member, Publication item)
        {
            if (!item.IsRented && member.IsActive)
            {
                member.RentItem(item);
            }
        }

        public void ReturnItem(Member member, Publication item)
        {
            member.ReturnItem(item);
        }
    }
}
