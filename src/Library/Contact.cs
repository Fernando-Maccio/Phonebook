namespace Library
{
    public class Contact
    {
        public Contact(string name, string id, string phone)
        {
            this.Name = name;
            this.Id = id;
            this.Phone = phone;
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public string Phone { get; set; }
    }
}