﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Entity
{
    public partial class Customer
    {
        public Customer()
        {
            Appointment = new HashSet<Appointment>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string JobTitle { get; set; }
        public string City { get; set; }
        public string CompanyName { get; set; }
        public int? UserId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Appointment> Appointment { get; set; }
    }
}