﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string Maintenancetime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string UnitPriceInvalid = "Ürün Fiyatı yanlış";
        public static string ProductCountOfCategoryError = "Bir Kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists="Bu İsimde Başka Bir Ürün Var";
        public static string CategoryLimitExceded="Categori Limiti Aşıldığı İçin yeni Ürün Eklenemiyor";
        public static string AuthorizationDenied="Yetkiniz Yok";
    }
}
