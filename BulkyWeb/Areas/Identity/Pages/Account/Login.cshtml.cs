// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BeautiqueWeb.Areas.Identity.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<LoginModel> _logger;

        public LoginModel(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, ILogger<LoginModel> logger)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _logger = logger;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl ??= Url.Content("~/");

            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            if (ModelState.IsValid)
            {
                // 1. Знайти користувача за email
                var user = await _userManager.FindByEmailAsync(Input.Email);
                if (user == null)
                {
                    _logger.LogWarning("Login failed: Email not found.");
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page(); // Завершуємо, якщо email не знайдений
                }

                // 2. Перевірити пароль
                var result = await _userManager.CheckPasswordAsync(user, Input.Password);
                if (!result)
                {
                    _logger.LogWarning("Login failed: Invalid password.");
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page(); // Завершуємо, якщо пароль неправильний
                }

                // 3. Увійти в систему, якщо все вірно
                await _signInManager.SignInAsync(user, isPersistent: false);
                _logger.LogInformation("User logged in successfully.");

                return LocalRedirect(returnUrl); // Перехід на головну сторінку або задану
            }

            // Якщо модель не валідна, повертаємо сторінку з помилками
            return Page();
        }

    }
}

