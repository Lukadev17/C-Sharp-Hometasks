namespace homeTask_1
{
    public class User
    {
        private string FirstName;
        private string LastName;
        private string Address;
        private  int ID;
        private static int idCounter = 0;

        public User(string firstName, string lastName, string address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.ID = idCounter++;
        }

        public string Firstname
        {
            get => FirstName;
            set => FirstName = value;
        }

        public string Lastname
        {
            get => LastName;
            set => LastName = value;
        }

        public string address
        {
            get => Address;
            set => Address = value;
        }

        public int Id
        {
            get => ID;
            set => ID = value;
        }

        public string  GetMessage(Message message)
        {
            return $"Subject: {message.Title}  Content: {message.Description}";
            
        }
    }
}