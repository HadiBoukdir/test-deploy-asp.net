using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json.Linq;
using System.Reflection;

namespace TestDeployApp.Pages.sentinel;

public class IndexModel : PageModel
{
    public string LatestTag { get; set; }
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }
    public async Task OnGetAsync()
    {
        LatestTag = Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
    }

}