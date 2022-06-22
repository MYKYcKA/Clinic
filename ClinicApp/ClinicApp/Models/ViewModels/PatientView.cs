using System;

namespace ClinicApp.Models.ViewModels
{
    public class PatientView
    {
        public int Id { get; set; }
        public int AddressId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Street { get; set; }
        public short House { get; set; }
        public string City { get; set; }
        public Nullable<short> Apartment { get; set; }

        public Patient ToPatient()
        {
            return new Patient {Id = this.Id, Name = this.Name, Surname = this.Surname,AddressId = this.AddressId };
        }

        public Address ToAddress()
        {
            return new Address {Id = this.AddressId, House = this.House, City = this.City, Apartment = this.Apartment, Street = this.Street};
        }
    }
}
