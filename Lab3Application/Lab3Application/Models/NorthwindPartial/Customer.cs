using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3Application.Models.Northwind
{
    [MetadataType(typeof(CustomerMetaData))]
    public partial class Customer { }
    public partial class CustomerMetaData
    {
        [Required]
        public string CustomerID { get; set; }

        [Display(Name = "Company")]
        [Required]
        public string CompanyName { get; set; }

        [Required]
        [Display(Name = "Comtact")]
        public string ContactName { get; set; }

        [Required]
        public string ContactTitle { get; set; }

        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Region { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }
    }
}