using System.Collections.Generic;

namespace LibrarySystem.Models
{
    public class Member
    {
        public string Name { get; set; }
        public bool IsActive { get; private set; }
        public List<Publication> RentedItems { get; private set; } = new List<Publication>();

        public void Activate() => IsActive = true;
        public void Deactivate() => IsActive = false;

        public void RentItem(Publication item)
        {
            if (IsActive && !item.IsRented)
            {
                item.Rent();
                RentedItems.Add(item);
            }
        }

        public void ReturnItem(Publication item)
        {
            if (RentedItems.Contains(item))
            {
                item.Return();
                RentedItems.Remove(item);
            }
        }
    }
}
