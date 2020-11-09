using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_028.Models
{
    public partial class Gender
    {
        public Gender()
        {
            Costumer = new HashSet<Costumer>();
        }

        public int IdGender { get; set; }

        [Required(ErrorMessage = "Nama gender tidak boleh kosong")]
        public string NamaGender { get; set; }

        public ICollection<Costumer> Costumer { get; set; }
    }
}
