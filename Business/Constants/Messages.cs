using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages 
    {
        public static string ProductAdded = "Ürün eklendi!"; // publicler pascal case ile yazılır. 
        public static string ProductNameInvalid = "Ürün ismi geçersiz!";

        public static string ProductsListed = "Ürünler listelendi!";

        public static string MaintenanceTime = "Bakım saati!";
        public static string ProductCountOfCategoryError = "Bu kategoriye ait max 10 ürün eklenebilir!";
        public static string ProductNameAlreadyExists = "Bu isimde ürün zaten mevcut!";
        public static string CategoryListed = "Kategoriler listelendi!";
        public static string CategoryLimitExceded = "Kategori limiti aşıldı!";

    }
}
