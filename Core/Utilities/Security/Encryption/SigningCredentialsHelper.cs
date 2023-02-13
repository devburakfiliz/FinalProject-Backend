using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper // hangı anahtar hangı algorıtma
    {
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey) // bizim ıcın json web token servislerini web apinin kullanacagı json web tokenlerının olusturulması ıcın kullanıcı adı parola sızın bır sısteme gırebılmenız ıcın elıonızde olanlardır
        {
            return new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha512Signature);  // bu anahtarı kullan algorıtma olarakta güvenlık algorıtmalarındah hmac512singuture yı kullan
        } 
    }
}
