using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Conststans
{
    public static class Message
    {
        public readonly static string UserNameOrEmailAndPasswordFailed = "Kullanıcı adı veya şifre hatalı";
        public readonly static string LoginSuccess = "Giriş başarılı";
        public readonly static string LoginFailed = "Giriş başarısız";
        public readonly static string UserCreateFailed = "Kullanıcı ekleme işlemi başarısız";
        public readonly static string UserNotFound = "Kullanıcı bulunamadı";
        public readonly static string CarrierConfigurationCreatedIsError = "Kargo konfigrasyonu oluşturma işlemi başarısır";
        public readonly static string CarrierConfigurationCreatedSuccess = "Kargo konfigrasyonu oluşturma işlemi başarılı";
        public readonly static string NotificationIsListed = "Bildirim listeleme işlemi başarılı";
        public readonly static string NotificationCreatedIsSuccess = "Bildirim oluşturma işlemi başarılı";
        public readonly static string NotificationCreatedIsFailed = "Aynı text'de bildirim olduğu için, işlem başarısız";
        public readonly static string NotificationRemoveIsSuccesss = "Bildirim silme işlemi başarılı.";
        public readonly static string NotificationRemoveIsFailed = "Veri tabanında böyle bir bildirim olmadığı için, işlem başarısız.";
        public readonly static string NotificationGetByIdIsSuccess = "Bildiri ekrana getirildi, işlem başarılı";
        public readonly static string NotificationGetByIdIsFailed = "Veri tabanında böyle bir bildiri yoktur.";
        public readonly static string CarrierConfigurationIsUpdatedSuccess = "Kargo konfigrasyonu güncelleme işlemi başarılı";
        public readonly static string CarrierConfigurationIsUpdatedFail = "Kargo konfigrasyonu güncelleme işlemi başarısız.";
        public readonly static string GetAllCarrierSuccess = "Kargolar başarıyla listelendi";

        public static string CarrierConfigurationDeletedIsError = "Kargo konfigrasyonu silme işlemi başarısız";
        public static string CarrierConfigurationDeletedIsSuccess = "Kargo konfigrasyonu silme işlemi başarılı";

        public static string GetListCarrierSuccess = "Kargo başarılı bir şekilde getirildi";

        public static string GetAllCarrierConfigurationSuccess = "Kargo konfigürasyonları başarılı bir şekilde getirildi";

        public static string GetAllOrderSuccess = "Siparişler başarılı bir şekilde getirildi";

        public static string AddedOrderIsSuccess = "Sipariş başarılı bir şekilde oluşturuldu";

        public static string CarrierConfigurationIsNotFound = "Kargo konfigürasyonu bulunamadı";

        public static string CarrierReportCreatedIsError = "Kargo raporu eklenemedi";

        public static string CarrierReportCreatedCreatedSuccess = "Kargo raporu eklendi";
    }
}
