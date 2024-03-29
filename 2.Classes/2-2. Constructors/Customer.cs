﻿using System.Collections.Generic;

namespace Customer
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int Id)
            : this()
        {
            this.Id = Id;
        }

        public Customer(int id, string name)
            :this(id)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
