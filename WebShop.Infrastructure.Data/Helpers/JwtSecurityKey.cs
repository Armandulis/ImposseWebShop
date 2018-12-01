using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Infrastructure.Data.Helpers
{
    public class JwtSecurityKey
    {
        private static byte[] secretBytes = Encoding.UTF8.GetBytes("AsecretforHmacSha256");

        public static SymmetricSecurityKey Key()
        {

              return new SymmetricSecurityKey(secretBytes); 

        }
        
    }
}
