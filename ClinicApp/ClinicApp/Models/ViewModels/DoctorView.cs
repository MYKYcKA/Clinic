using System;

namespace ClinicApp.Models.ViewModels
{
    public class DoctorView
    {
        public int Id { get; set; }
        public int AddressId { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public string Specialization { get; set; }
        public string Street { get; set; }
        public short House { get; set; }
        public string City { get; set; }
        public Nullable<short> Apartment { get; set; }

        public Doctor ToDoctor()
        {
            return new Doctor { Name = this.Name, MiddleName = this.MiddleName, Surname = this.Surname, Specialization = this.Specialization,AddressId = this.AddressId};
        }

        public Address ToAddress()
        {
            return new Address { House = this.House, City = this.City, Apartment = this.Apartment, Street = this.Street };
        }
    }
}
