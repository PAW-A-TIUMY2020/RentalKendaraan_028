using System;
using System.Collections.Generic;

namespace RentalKendaraan_028.Models
{
    public partial class Gender
    {
        public Gender()
        {
            Costumer = new HashSet<Costumer>();
        }

        public int IdGender { get; set; }
        public string NamaGender { get; set; }

        public ICollection<Costumer> Costumer { get; set; }
    }
}
