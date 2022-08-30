using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInValid = "Ürün İsmi 2 karakterden az olamaz";
        public static string MaintenanceTime = "Sistem Kapalı";
        public static string ProductsListed = "Ürünler Listelendi";

        public static string ProductCountOfCategoryError = "Belirtilen kategori sınırını aştınız";

        public static string ProductNameAlreadyExists = "Aynı isimde ürün eklenemez";

        public static string CategoryLimitExceded = "Kategori Limiti Aşıldı";
        public static string AuthorizationDenied = "Yetkiniz Yok!";

        public static string UserRegistered = "Kullanıcı Başarıyla Kayıt Oldu!";

        public static string UserNotFound = "Kullanıcı Bulunamadı!";

        public static string PasswordError = "Hatalı Şifre";

        public static string SuccessfulLogin = "Giriş Başarılı";

        public static string UserAlreadyExists = "Kullanıcı Mevcut";
    }
}
