using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebRazor.Model;
using WebRazor.Repository;

namespace WebRazor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IUser _user;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger , IUser user)
        {
            _logger = logger;
            _user = user;
        }

        public IList<User> Users { get;set; }
        public void OnGet()
        {
            Users = _user.users().ToList();

        }
    }
}