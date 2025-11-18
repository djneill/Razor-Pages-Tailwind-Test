using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorAddressBook.Pages
{
    public class Address : PageModel
    {
        private readonly ILogger<Address> _logger;

        public Address(ILogger<Address> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}