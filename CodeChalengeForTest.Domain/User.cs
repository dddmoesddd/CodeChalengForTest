namespace CodeChalengeForTest.Domain
{
    public class User : BaseEntity
    {
        public User()
        {
            
        }
        public string FirstName { get;  set; }
        public string LastName { get; set; }
        public string Phone { get;  set; }
        public string Email { get;  set; }
        public string UserName { get;  set; }
        public string Password { get;  set; } 
        public Address Address { get;  set; }

        public User(string firstName, string lastName, string phone, string email, string userName, string password, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            UserName = userName;
            Password = password;
            Address = address;
        }

        public void UpdatePassword(string newPassword)
        {
            Password = newPassword; // hash outside in app layer
        }
    }

}
