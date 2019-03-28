using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CIDM3312_lAB10.Pages
{
    public class formModel : PageModel
    {
         private readonly ILogger _log;
        
        [BindProperty]
        [Display(Name="First Name")]
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string FirstName {get;set;}
         
        [BindProperty]
        [Display(Name="Last Name")]
        [Required]
        [StringLength(60, MinimumLength = 3)]

        public string LastName {get;set;}

        [BindProperty]
        [Display(Name="Credit Card Number")]
        [Required]
        [CreditCard]
        [StringLength(20)]
        public string Credit_card_Number{get;set;}
        
       public formModel(ILogger <IndexModel> log)
        {
            _log=log;
        }
        public void OnGet()
        {

        }
        public void OnPost()
            {
                   _log.LogInformation(FirstName);
                   _log.LogInformation(LastName);
                   _log.LogInformation(Credit_card_Number);

 
            }
            

    }
}
