using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Encryption
{
    public class SecurityKeyHelper  //şifreleme olan sıstemelerde bızım herşeyı bır byte array formatında verıyor olmamız lazım.
    {
        public static SecurityKey CreateSecurityKey(string securityKey) // bana bir tane securitykey degeri ver web api.appsetingdeki ben ona karsılıgını vereyım using system.IdendityModeltokendan gelıyor

        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey))  ;

        }
    }
}
