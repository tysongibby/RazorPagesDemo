﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorPagesUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty(SupportsGet = true)]
        public string City { get; set; }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(City))
            {
                City = "The Web";
            }

            // Get data from database to initialize page
        }

        //public void OnPost()
        //{

        //}
    }
}