using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json.Linq;

namespace TestDeployApp.Pages;

public class IndexModel : PageModel
{
    public string LatestTag { get; set; }
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
        Tags = new List<string>();
    }
    public IList<string> Tags { get; set; }
    public async Task OnGetAsync()
    {
        LatestTag = Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
    }

}
