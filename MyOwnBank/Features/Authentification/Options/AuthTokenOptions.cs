﻿namespace MyOwnBank.Features.Authentification.Options;

public class AuthTokenOptions
{
    public JwtOptions Jwt { get; set; } = new JwtOptions();

    public class JwtOptions
    {
        public string SigningKey { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public TimeSpan Expiration { get; set; }
    }
}
