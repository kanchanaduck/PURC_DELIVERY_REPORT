using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using api_purdelivery.Repository;

namespace api_purdelivery.Repository
{
    public class Repository<TDbContext> : IRepository where TDbContext : DbContext
    {
        protected TDbContext _dbContext;
        private IConfiguration _configuration;
        public Repository(TDbContext dbcontext, IConfiguration configuration)
        {
            _dbContext = dbcontext;
            _configuration = configuration;
        }
                public HashSalt EncryptPassword(string password)
        {
            // using System.Security.Cryptography;
            // using Microsoft.AspNetCore.Cryptography.KeyDerivation;
            byte[] salt = new byte[128 / 8]; // Generate a 128-bit salt using a secure PRNG
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            string encryptedPassw = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8
            ));
            return new HashSalt { Hash = encryptedPassw, Salt = salt };
        }

        public bool VerifyPassword(string enteredPassword, byte[] salt, string storedPassword)
        {
            string encryptedPassw = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: enteredPassword,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8
            ));
            return encryptedPassw == storedPassword;
        }

    }
}

public class HashSalt
{
    public string Hash { get; set; }
    public byte[] Salt { get; set; }
}