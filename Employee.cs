namespace CatWorx.BadgeMaker
{
    class Employee
    {
        private string FirstName;
        private string LastName;
        private int Id;
        private string PhotoUrl;

        // Constructor function
        public Employee(string firstName, string lastName, int id, string photoUrl)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            PhotoUrl = photoUrl;
        }

        // Return first and last name
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        // Return ID
        public int GetId()
        {
            return Id;
        }

        // Return photo URL
        public string GetPhotoUrl()
        {
            return PhotoUrl;
        }

        // Return company name
        public string GetCompanyName()
        {
            return "Cat Worx";
        }
    }
}