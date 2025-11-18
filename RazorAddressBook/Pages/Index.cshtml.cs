using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorAddressBook.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public string firstName { get; set; }
    [BindProperty]
    public string lastName { get; set; }
    [BindProperty]
    public List<string> Names { get; set; } = new List<string>();
    public void OnGet()
    {

    }

    public IActionResult OnPost()
    {
        if (!string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName))
        {
            string fullName = $"{firstName} {lastName}";
            Names.Add(fullName);
        }
        return Page();
    }
}
