using Senserpage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senserpage.Data
{
    public class Goods : IGoods
    {
        public static bool OpenCart { set; get; }

        //public bool GetOpenCart()
        //{
        //    return OpenCart;
        //}
        public List<Good> GetGoods()
        {
            List<Good> list = new();
            list.Add(new Good()
            {
                Name = "MF 46E24 MATT BLACK RUSTIC",
                Price = 3299,
                Attributes = new List<string>(){
                    "Конвекція",
                    "Гриль",
                    "Розморожування",
                    "Термостат, °С - 280",
                    "Потужність, кВт - 1,6",
                    "Таймер, мин - 90",
                    "Автовідключення",
                    "Кількість режимів приготування - 5",
                    "Гумовий ущільнювач (повна ізоляція)",
                    "Комплектація: 2 лотка + 1 решітка",
                    "Об’єм, л - 46",
                    "Подвійне скло духовки",
                    "Внутрішнє покриття - емаль легкої очистки",
                    "Колір: чорний, стиль ретро",
                    "Габарити (ВхШхГ), см: 36 х 62 х 47",
                    "Країна виробництва - Туреччина",
                    "Гарантія - 12 місяців"
                },
                ImageLinks = new List<string>(){
                    "/images/MF 46E24 Beige Rustic -1_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -2_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -3_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -4_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -5_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -6_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -7_1000.jpg",
                },
                ImageLinksSmall = new List<string>(){
                    "/images/MF 46E24 Beige Rustic -1_400.jpg",
                    "/images/MF 46E24 Beige Rustic -2_100.jpg",
                    "/images/MF 46E24 Beige Rustic -3_100.jpg",
                    "/images/MF 46E24 Beige Rustic -4_100.jpg",
                    "/images/MF 46E24 Beige Rustic -5_100.jpg",
                    "/images/MF 46E24 Beige Rustic -6_100.jpg",
                    "/images/MF 46E24 Beige Rustic -7_100.jpg",
                },
                IsOpened = false
            }); 

            list.Add(new Good()
            {
                Name = "MF 46E24 BEIGE RUSTIC",
                Price = 3299,
                Attributes = new List<string>(){
                    "Конвекція",
                    "Гриль",
                    "Розморожування",
                    "Термостат, °С - 280",
                    "Потужність, кВт - 1,6",
                    "Таймер, мин - 90",
                    "Автовідключення",
                    "Кількість режимів приготування - 5",
                    "Гумовий ущільнювач (повна ізоляція)",
                    "Комплектація: 2 лотка + 1 решітка",
                    "Об’єм, л - 46",
                    "Подвійне скло духовки",
                    "Внутрішнє покриття - емаль легкої очистки",
                    "Колір: бежевий, стиль ретро",
                    "Габарити (ВхШхГ), см: 36 х 62 х 47",
                    "Країна виробництва - Туреччина",
                    "Гарантія - 12 місяців"
                },
                ImageLinks = new List<string>(){
                    "/images/MF 46E24 Beige Rustic -1_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -2_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -3_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -4_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -5_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -6_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -7_1000.jpg",
                },
                ImageLinksSmall = new List<string>(){
                    "/images/MF 46E24 Beige Rustic -1_400.jpg",
                    "/images/MF 46E24 Beige Rustic -2_100.jpg",
                    "/images/MF 46E24 Beige Rustic -3_100.jpg",
                    "/images/MF 46E24 Beige Rustic -4_100.jpg",
                    "/images/MF 46E24 Beige Rustic -5_100.jpg",
                    "/images/MF 46E24 Beige Rustic -6_100.jpg",
                    "/images/MF 46E24 Beige Rustic -7_100.jpg",
                },
                IsOpened = false
            });

            list.Add(new Good()
            {
                Name = "MF 46E24 WOODEN",
                Price = 3299,
                Attributes = new List<string>(){
                    "Конвекція",
                    "Гриль",
                    "Розморожування",
                    "Термостат, °С - 280",
                    "Потужність, кВт - 1,6",
                    "Таймер, мин - 90",
                    "Автовідключення",
                    "Кількість режимів приготування - 5",
                    "Гумовий ущільнювач (повна ізоляція)",
                    "Комплектація: 2 лотка + 1 решітка",
                    "Об’єм, л - 46",
                    "Подвійне скло духовки",
                    "Внутрішнє покриття - емаль легкої очистки",
                    "Колір: передня панель під дерево + чорні стінки",
                    "Габарити (ВхШхГ), см: 36 х 62 х 47",
                    "Країна виробництва - Туреччина",
                    "Гарантія - 12 місяців"
                },
                ImageLinks = new List<string>(){
                    "/images/MF 46E24 Beige Rustic -1_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -2_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -3_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -4_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -5_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -6_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -7_1000.jpg",
                },
                ImageLinksSmall = new List<string>(){
                    "/images/MF 46E24 Beige Rustic -1_400.jpg",
                    "/images/MF 46E24 Beige Rustic -2_100.jpg",
                    "/images/MF 46E24 Beige Rustic -3_100.jpg",
                    "/images/MF 46E24 Beige Rustic -4_100.jpg",
                    "/images/MF 46E24 Beige Rustic -5_100.jpg",
                    "/images/MF 46E24 Beige Rustic -6_100.jpg",
                    "/images/MF 46E24 Beige Rustic -7_100.jpg",
                },
                IsOpened = false
            });

            list.Add(new Good()
            {
                Name = "MF 46E24 MATT BURGUNDY",
                Price = 2599,
                Attributes = new List<string>(){
                    "Конвекція",
                    "Гриль",
                    "Розморожування",
                    "Термостат, °С - 280",
                    "Потужність, кВт - 1,6",
                    "Таймер, мин - 90",
                    "Автовідключення",
                    "Кількість режимів приготування - 5",
                    "Гумовий ущільнювач (повна ізоляція)",
                    "Комплектація: 2 лотка + 1 решітка",
                    "Об’єм, л - 46",
                    "Одинарне скло духовки",
                    "Внутрішнє покриття - емаль легкої очистки",
                    "Колір: червона передня панель + чорні стінки",
                    "Габарити (ВхШхГ), см: 36 х 62 х 47",
                    "Країна виробництва - Туреччина",
                    "Гарантія - 12 місяців"
                },
                ImageLinks = new List<string>(){
                    "/images/MF 46E24 Beige Rustic -1_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -2_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -3_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -4_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -5_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -6_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -7_1000.jpg",
                },
                ImageLinksSmall = new List<string>(){
                    "/images/MF 46E24 Beige Rustic -1_400.jpg",
                    "/images/MF 46E24 Beige Rustic -2_100.jpg",
                    "/images/MF 46E24 Beige Rustic -3_100.jpg",
                    "/images/MF 46E24 Beige Rustic -4_100.jpg",
                    "/images/MF 46E24 Beige Rustic -5_100.jpg",
                    "/images/MF 46E24 Beige Rustic -6_100.jpg",
                    "/images/MF 46E24 Beige Rustic -7_100.jpg",
                },
                IsOpened = false
            });

            list.Add(new Good()
            {
                Name = "MF 46E24 MATT BLACK",
                Price = 2599,
                Attributes = new List<string>(){
                    "Конвекція",
                    "Гриль",
                    "Розморожування",
                    "Термостат, °С - 280",
                    "Потужність, кВт - 1,6",
                    "Таймер, мин - 90",
                    "Автовідключення",
                    "Кількість режимів приготування - 5",
                    "Гумовий ущільнювач (повна ізоляція)",
                    "Комплектація: 2 лотка + 1 решітка",
                    "Об’єм, л - 46",
                    "Одинарне скло духовки",
                    "Внутрішнє покриття - емаль легкої очистки",
                    "Колір: чорна передня панель + червоні стінки",
                    "Габарити (ВхШхГ), см: 36 х 62 х 47",
                    "Країна виробництва - Туреччина",
                    "Гарантія - 12 місяців"
                },
                ImageLinks = new List<string>(){
                    "/images/MF 46E24 Beige Rustic -1_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -2_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -3_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -4_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -5_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -6_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -7_1000.jpg",
                },
                ImageLinksSmall = new List<string>(){
                    "/images/MF 46E24 Beige Rustic -1_400.jpg",
                    "/images/MF 46E24 Beige Rustic -2_100.jpg",
                    "/images/MF 46E24 Beige Rustic -3_100.jpg",
                    "/images/MF 46E24 Beige Rustic -4_100.jpg",
                    "/images/MF 46E24 Beige Rustic -5_100.jpg",
                    "/images/MF 46E24 Beige Rustic -6_100.jpg",
                    "/images/MF 46E24 Beige Rustic -7_100.jpg",
                },
                IsOpened = false
            });

            list.Add(new Good()
            {
                Name = "MF 46E24 GREY",
                Price = 2599,
                Attributes = new List<string>(){
                    "Конвекція",
                    "Гриль",
                    "Розморожування",
                    "Термостат, °С - 280",
                    "Потужність, кВт - 1,6",
                    "Таймер, мин - 90",
                    "Автовідключення",
                    "Кількість режимів приготування - 5",
                    "Гумовий ущільнювач (повна ізоляція)",
                    "Комплектація: 2 лотка + 1 решітка",
                    "Об’єм, л - 46",
                    "Одинарне скло духовки",
                    "Внутрішнє покриття - емаль легкої очистки",
                    "Колір: сірий",
                    "Габарити (ВхШхГ), см: 36 х 62 х 47",
                    "Країна виробництва - Туреччина",
                    "Гарантія - 12 місяців"
                },
                ImageLinks = new List<string>(){
                    "/images/MF 46E24 Beige Rustic -1_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -2_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -3_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -4_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -5_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -6_1000.jpg",
                    "/images/MF 46E24 Beige Rustic -7_1000.jpg",
                },
                ImageLinksSmall = new List<string>(){
                    "/images/MF 46E24 Beige Rustic -1_400.jpg",
                    "/images/MF 46E24 Beige Rustic -2_100.jpg",
                    "/images/MF 46E24 Beige Rustic -3_100.jpg",
                    "/images/MF 46E24 Beige Rustic -4_100.jpg",
                    "/images/MF 46E24 Beige Rustic -5_100.jpg",
                    "/images/MF 46E24 Beige Rustic -6_100.jpg",
                    "/images/MF 46E24 Beige Rustic -7_100.jpg",
                },
                IsOpened = false
            });            

            return list;
        }

        public static List<CartGood> CartGoods { get; set; } = new List<CartGood>();        
    }

    public class CartGood : ICartGood
    {
        public string Name { get; set; }
        public string PhotoLink { get; set; }
        public int Number { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
