using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace secrets
{
    public partial class Customers
    {
        public Customers()
        {
            Invoices = new HashSet<Invoices>();
        }

        public long CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public long? SupportRepId { get; set; }

        public virtual Employees SupportRep { get; set; }
        public virtual ICollection<Invoices> Invoices { get; set; }
    }
}
