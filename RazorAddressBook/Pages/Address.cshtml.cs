using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorAddressBook.Pages
{
    [BindProperties]
    public class Address : PageModel
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public List<string> AddressList { get; set; } = new List<string>();

        private readonly ILogger<Address> _logger;
        public Address(ILogger<Address> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            string fullAddress = $"{StreetAddress} {City} {State} {Zipcode}";
            AddressList.Add(fullAddress);
            return Page();
        }


    }
}