using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CIDM3312_lAB10.Pages
{
    public class formModel : PageModel
    {
        private readonly ILogger _log;
        public formModel(ILogger <formModel> log)
        {
            _log=log;
        }
        public void OnGet()
        {

        }
        public void OnPost()
            {
                   _log.LogInformation("HTTP Post Request");
 
            }

    }
}
