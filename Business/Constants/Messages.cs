using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Eklendi.";
        public static string Invalid = "İsim geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string Listed = "Listelendi.";
        public static string Deleted = "Silindi";
        public static string Updated = "Güncellendi";
        public static string CarImageLimitExceded = "Araba resmi 5'i geçemez";
        public static string CarImageAdded = "Araba resmi eklendi.";
        public static string CarImageDeleted = "Araba resmi silindi";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
    }
}
