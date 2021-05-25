﻿using MySql.Data.EntityFramework;
using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;

namespace classwork8
{

    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class OrderContext : DbContext
    {
        public OrderContext() : base("OrderDataBase")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<OrderContext>());
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<commodity> commodities { get; set; }
        public DbSet<customer> Customer { get; set; }
    }
}