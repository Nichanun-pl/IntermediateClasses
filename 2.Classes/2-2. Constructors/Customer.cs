namespace Customer
{
    public class Customer
    {
        public int Id;
        public string Name;

        public Customer()
        {

        }

        public Customer(int Id)
        {
            this.Id = Id;
        }

        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
