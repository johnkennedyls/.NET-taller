﻿using System;
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

        public IndexModel(TallerRPC.Data.TallerRPCContext context)
        {
            _context = context;
        }

        public IList<Account> Account { get;set; }

        public async Task OnGetAsync()
        {
            Account = await _context.Account.ToListAsync();
        }
    }
}
