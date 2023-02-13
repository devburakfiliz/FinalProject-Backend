using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims); // kullanıcı sıfre ve ıd gırdıgınde  apiye yolladı ilgılı kullanıcı ıcın verı tabanında kullanıcı clıamlarını bulup json web token uretıp onu yollayacak

    }
}
