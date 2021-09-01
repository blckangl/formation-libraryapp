using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Livre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateDeCreation { get; set; }
        public string Author { get; set; }

        public Livre()
        {
            this.DateDeCreation = DateTime.Now;
        }
    }
}
