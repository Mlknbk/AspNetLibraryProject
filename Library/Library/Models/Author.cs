﻿using System.Collections.Generic;

namespace Library.Models
{
    public class Author:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}
