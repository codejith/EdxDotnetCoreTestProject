﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestApp.Models
{
    [Table("address")]
    public partial class Address
    {
        public Address()
        {
            Customer = new HashSet<Customer>();
            Staff = new HashSet<Staff>();
            Store = new HashSet<Store>();
        }

        [Column("address_id")]
        public ushort AddressId { get; set; }
        [Required]
        [Column("address")]
        [StringLength(50)]
        public string Address1 { get; set; }
        [Column("address2")]
        [StringLength(50)]
        public string Address2 { get; set; }
        [Required]
        [Column("district")]
        [StringLength(20)]
        public string District { get; set; }
        [Column("city_id")]
        public ushort CityId { get; set; }
        [Column("postal_code")]
        [StringLength(10)]
        public string PostalCode { get; set; }
        [Required]
        [Column("phone")]
        [StringLength(20)]
        public string Phone { get; set; }
        [Column("last_update", TypeName = "timestamp")]
        public DateTimeOffset LastUpdate { get; set; }

        [ForeignKey("CityId")]
        [InverseProperty("Address")]
        public City City { get; set; }
        [InverseProperty("Address")]
        public ICollection<Customer> Customer { get; set; }
        [InverseProperty("Address")]
        public ICollection<Staff> Staff { get; set; }
        [InverseProperty("Address")]
        public ICollection<Store> Store { get; set; }
    }
}
