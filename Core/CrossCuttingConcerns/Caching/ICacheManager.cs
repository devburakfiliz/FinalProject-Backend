using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key); // T döndürücez t herşey olabilir generic methot BEN SANA BİR KEY VEREYIM SEN O KEY KARSILIGINDAN BELLEKTEN DATA GETİR
        object Get(string key); // Bellek olmayan versiyonu .
        void Add(string key, object value,int duration); //gelecek data bir obje olacak bu yüzden herşeyi buraya atayabiliriz  duration  cach de ne kadar duracak dakıka saat cinsinden.
        bool IsAdd(string key); // bu methot veri cache de varmı yokmu dıye bakar  verinin veritabanından mı cache den gelecegını mı anlamak ıcın 
        void Remove(string key); //cashe den ucurma ben sana bır key versem cache den ucururumusun
        void RemoveByPettern(string pattern); //Parametrik olanlardada ismi getle başlayanları isminde category olanları vs gibi. başı sonu onemlı degıl ıcınde  .... olanlar gibi

    }
}
