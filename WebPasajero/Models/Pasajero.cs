using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPasajero.Models
{
    public class Pasajero
    {
        [Key]
        public int PasajeroId { get; set; }

        [Display(Name = "First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        public Pasajero() { }

        public Pasajero(string firstName, string lastName, DateTime birthdate, string city)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthdate;
            this.City = city;
        }
    }
}

