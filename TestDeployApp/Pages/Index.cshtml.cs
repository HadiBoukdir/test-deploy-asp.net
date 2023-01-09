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
        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("User-Agent", "MyApp");
            var response = await client.GetAsync("https://api.github.com/repos/hadiboukdir/test-deploy-asp.net/tags");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                Tags = JArray.Parse(json)
                    .Select(x => x["name"].ToString())
                    .ToList();

                LatestTag = Tags.OrderByDescending(x => x).FirstOrDefault();
            }

        }
    }

}