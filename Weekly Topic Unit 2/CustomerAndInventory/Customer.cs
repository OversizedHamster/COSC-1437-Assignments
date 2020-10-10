
//Ethan Smith

namespace CustomerAndInventory
{
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsMember { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }

        public bool ValidateName()
        {
            if (FirstName.Length < 2)
                return false;

            if (LastName.Length < 2)
                return false;

            return true;
        }
    }
}
