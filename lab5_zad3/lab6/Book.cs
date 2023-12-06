using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Interfaces
{
    public class Book: IEntity<int>, IHasCreationTime
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string PublishYear { get; set; }
    }
}
