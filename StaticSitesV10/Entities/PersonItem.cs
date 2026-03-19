using System;

namespace StaticSitesV10.Entities
{
    public class PersonItem
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string UserName { get; set; }

        public Guid Id { get; set; }

        public string IdString { get { return Id.ToString(); } }
    }
}
