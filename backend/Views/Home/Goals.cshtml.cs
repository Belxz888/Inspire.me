using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace testwebap.Views;

public class goalsModel : PageModel
{
    private readonly ILogger<goalsModel> _logger;

    public goalsModel(ILogger<goalsModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

