﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestfulAPInetCore.Models;

namespace RestfulAPInetCore.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly RestfulAPInetCore.Models.AppDbContextContext _context;

        public IndexModel(RestfulAPInetCore.Models.AppDbContextContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; }

        public async Task OnGetAsync()
        {
            Game = await _context.Game.ToListAsync();
        }
    }
}
