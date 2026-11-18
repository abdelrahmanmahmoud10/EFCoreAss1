using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAss1.Entities
{
    internal class Book
    {
        public int Id { get; set; }
        public string ISBN { get; set; }

        public string Titel { get; set; }

        public decimal Price { get; set; }

        public int NumberOfPages { get; set; }

        public int PublicationYear { get; set; }

        public bool Isinstock { get; set; }

    }
}
