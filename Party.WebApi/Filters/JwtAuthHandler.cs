using FirebaseAdmin.Auth;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Party.WebApi.Filters
{
	public static class SchemeName
	{
		public const string FirebaseAuthScheme = "FirebaseAuthScheme";
	}

	public class JwtAuthHandler : AuthenticationHandler<AuthenticationSchemeOptions>
	{
		public IServiceProvider ServiceProvider { get; set; }

		public JwtAuthHandler(
			IOptionsMonitor<AuthenticationSchemeOptions> options,
			ILoggerFactory logger,
			UrlEncoder encoder,
			ISystemClock clock, IServiceProvider serviceProvider
			) : base(options, logger, encoder, clock)
		{
			ServiceProvider = serviceProvider;
		}

		protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
		{

	
			if (!Request.Headers.TryGetValue("Authorization", out var authValues))
			{
				return AuthenticateResult.NoResult();
			}

			if (!AuthenticationHeaderValue.TryParse(authValues.FirstOrDefault(), out AuthenticationHeaderValue authHeaderValue))
			{
				return AuthenticateResult.NoResult();
			}

			if (!"Bearer".Equals(authHeaderValue.Scheme, StringComparison.OrdinalIgnoreCase))
			{
				return AuthenticateResult.NoResult();
			}

			FirebaseToken? firebaseUser = await VerifyFirebaseToken(authHeaderValue.Parameter);

			if (string.IsNullOrEmpty(firebaseUser?.Uid))
			{
				return AuthenticateResult.Fail("Firebase token authentication validation failed.");
			}

			var claims = new[] { new Claim(ClaimTypes.Name, firebaseUser?.Uid), new Claim(ClaimTypes.Email, firebaseUser?.Claims["email"]?.ToString()) };
			var identity = new ClaimsIdentity(claims, Scheme.Name);
			var principal = new ClaimsPrincipal(identity);
			var ticket = new AuthenticationTicket(principal, Scheme.Name);
			return AuthenticateResult.Success(ticket);
		}

		public static async Task<FirebaseToken?> VerifyFirebaseToken(string token)
		{
			try
			{
				return await FirebaseAuth.DefaultInstance.VerifyIdTokenAsync(token);
			}
			catch (Exception e) {
				var t = e;
					}
			return null;
		}

	}
}

