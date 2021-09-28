using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TallerRPC.Data;
using TallerRPC.Pages.Models;

namespace TallerRPC.Pages.Accounts
{
    public class IndexModel : PageModel
    {
        private readonly TallerRPC.Data.TallerRPCContext _context;

        [BindProperty(SupportsGet = true)]
        public static bool AccountSignedIn { get; set; }       
        [BindProperty(SupportsGet = true)]
        public bool AccountSigningOut { get; set; }
        [BindProperty(SupportsGet = true)]
        public string UserNameAccountToTry { get; set; }
        [BindProperty(SupportsGet = true)]
        public string AccountPasswordToTry { get; set; }
        [BindProperty(SupportsGet = true)]

        
        public Account UserSignedAccount { get; set; }
        

        public IndexModel(TallerRPC.Data.TallerRPCContext context)
        {
            _context = context;
        }

        public IList<Account> Account { get;set; }

        public async Task OnGetAsync()
        {
            Account = await _context.Account.ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (AccountSigningOut)
            {
                AccountSignedIn = false;
                UserSignedAccount = null;
            }
            else{
                UserSignedAccount = await _context.Account.FirstOrDefaultAsync(m => m.UserName == UserNameAccountToTry && m.Password == AccountPasswordToTry);

                if (UserSignedAccount == null){
                    return Page();
                }
                AccountSignedIn = true;
                Account = await _context.Account.ToListAsync();

            }
            return Page();
        }
    
}
}
