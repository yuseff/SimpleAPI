using System.Collections.Generic;

namespace SimpleAPI.Domain.Models
{
    public class Sport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Athlete> Athletes { get; set; } = new List<Athlete>();
    }
}