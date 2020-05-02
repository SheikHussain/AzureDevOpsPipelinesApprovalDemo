using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace PipelinesApprovalDemo.Pages
{
  public class IndexModel : PageModel
  {
    private readonly ILogger<IndexModel> _logger;
    public string MyEnvironment;

    public IndexModel(ILogger<IndexModel> logger)
    {
      _logger = logger;
    }

    public void OnGet()
    {
      MyEnvironment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

      if (String.IsNullOrEmpty(MyEnvironment))
      {
        MyEnvironment = "(unknown)";
      }

    }
  }
}
