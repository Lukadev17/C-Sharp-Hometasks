namespace homeTask_1
{
    public class Message
    {
        private string title;
        private string description;

        public Message(string title, string description)
        {
            this.title = title;
            this.description = description;
        }

        public string Title
        {
            get => title;
            set => title = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }
    }
}