using System.Collections.Generic;

namespace SimpleAPI.Domain.Models
{
    public class Athlete
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public short QuantityInPackage { get; set; } // Seasons played?
        public EUnitOfMeasurement UnitOfMeasurement { get; set; }

        public int SportId { get; set; }
        public Sport Sport { get; set; }

        //public IEnumerable<string> Team { get; set; }

        public int Number { get; set; }

        public bool HallOfFameInductee { get; set; }

        public bool Alive { get; set; }
    }
}