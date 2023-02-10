using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "ÜRÜN EKLENDİ";

        public static string ProductNamwInValid = "ÜRÜN İSMİ GEÇERSİZ";

        public static string MaintenanceTime = "Sistem bakımda";

        public static string ProductsListed="Ürünler listelendi.";

        public static string ProductCountOfCategoryError = "Kategori limiri dolu max 10 ürün";

        public static string ProductNameExists = "Aynı isimde product mevcut";

        public static string CategoryLimitExceded = "Category Limiti aşıldı";
    }
}
