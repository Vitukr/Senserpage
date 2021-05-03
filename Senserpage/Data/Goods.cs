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
                Price = 3499,
                PriceAction = 3149,
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
                    "/images/MF 46E24 Matt Black Rustic_1_1000.jpg",
                    "/images/MF 46E24 Matt Black Rustic_2_1000.jpg",
                    "/images/MF 46E24 Matt Black Rustic_3_1000.jpg",
                    "/images/MF 46E24 Matt Black Rustic_4_1000.jpg",
                    "/images/MF 46E24 Matt Black Rustic_5_1000.jpg",
                    "/images/MF 46E24 Matt Black Rustic_6_1000.jpg",
                },
                ImageLinksSmall = new List<string>(){
                    "/images/MF 46E24 Matt Black Rustic_1_400.jpg",
                    "/images/MF 46E24 Matt Black Rustic_2_100.jpg",
                    "/images/MF 46E24 Matt Black Rustic_3_100.jpg",
                    "/images/MF 46E24 Matt Black Rustic_4_100.jpg",
                    "/images/MF 46E24 Matt Black Rustic_5_100.jpg",
                    "/images/MF 46E24 Matt Black Rustic_6_100.jpg",
                },
                IsOpened = false
            }); 

            list.Add(new Good()
            {
                Name = "MF 46E24 BEIGE RUSTIC",
                Price = 3499,
                PriceAction = 3149,
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
                    "/images/MF 46E24 Beige Rustic_1_1000.jpg",
                    "/images/MF 46E24 Beige Rustic_2_1000.jpg",
                    "/images/MF 46E24 Beige Rustic_3_1000.jpg",
                    "/images/MF 46E24 Beige Rustic_4_1000.jpg",
                    "/images/MF 46E24 Beige Rustic_5_1000.jpg",
                    "/images/MF 46E24 Matt Black Rustic_6_1000.jpg",
                },
                ImageLinksSmall = new List<string>(){
                    "/images/MF 46E24 Beige Rustic_1_400.jpg",
                    "/images/MF 46E24 Beige Rustic_2_100.jpg",
                    "/images/MF 46E24 Beige Rustic_3_100.jpg",
                    "/images/MF 46E24 Beige Rustic_4_100.jpg",
                    "/images/MF 46E24 Beige Rustic_5_100.jpg",
                    "/images/MF 46E24 Matt Black Rustic_6_100.jpg",
                },
                IsOpened = false
            });

            list.Add(new Good()
            {
                Name = "MF 46E24 WOODEN",
                Price = 3499,
                PriceAction = 3149,
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
                    "/images/MF 46E24 Wooden_1_1000.jpg",
                    "/images/MF 46E24 Wooden_2_1000.jpg",
                    "/images/MF 46E24 Wooden_3_1000.jpg",
                    "/images/MF 46E24 Wooden_4_1000.jpg",
                    "/images/MF 46E24 Wooden_5_1000.jpg",
                    "/images/MF 46E24 Matt Black Rustic_6_1000.jpg",
                },
                ImageLinksSmall = new List<string>(){
                    "/images/MF 46E24 Wooden_1_400.jpg",
                    "/images/MF 46E24 Wooden_2_100.jpg",
                    "/images/MF 46E24 Wooden_3_100.jpg",
                    "/images/MF 46E24 Wooden_4_100.jpg",
                    "/images/MF 46E24 Wooden_5_100.jpg",
                    "/images/MF 46E24 Matt Black Rustic_6_100.jpg",
                },
                IsOpened = false
            });

            list.Add(new Good()
            {
                Name = "MF 46E24 BURGUNDY",
                Price = 2599,
                PriceAction = 2339,
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
                    "/images/MF 46E24 Burgundy_1_1000.jpg",
                    "/images/MF 46E24 Burgundy_2_1000.jpg",
                    "/images/MF 46E24 Burgundy_3_1000.jpg",
                    "/images/MF 46E24 Burgundy_4_1000.jpg",
                    "/images/MF 46E24 Burgundy_5_1000.jpg",
                    "/images/MF 46E24 Matt Black Rustic_6_1000.jpg",
                },
                ImageLinksSmall = new List<string>(){
                    "/images/MF 46E24 Burgundy_1_400.jpg",
                    "/images/MF 46E24 Burgundy_2_100.jpg",
                    "/images/MF 46E24 Burgundy_3_100.jpg",
                    "/images/MF 46E24 Burgundy_4_100.jpg",
                    "/images/MF 46E24 Burgundy_5_100.jpg",
                    "/images/MF 46E24 Matt Black Rustic_6_100.jpg",
                },
                IsOpened = false
            });

            list.Add(new Good()
            {
                Name = "MF 46E24 MATT BLACK",
                Price = 2599,
                PriceAction = 2339,
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
                    "/images/MF 46E24 Matt Black_1_1000.jpg",
                    "/images/MF 46E24 Matt Black_2_1000.jpg",
                    "/images/MF 46E24 Matt Black_3_1000.jpg",
                    "/images/MF 46E24 Matt Black_4_1000.jpg",
                    "/images/MF 46E24 Matt Black_5_1000.jpg",
                    "/images/MF 46E24 Matt Black Rustic_6_1000.jpg",
                },
                ImageLinksSmall = new List<string>(){
                    "/images/MF 46E24 Matt Black_1_400.jpg",
                    "/images/MF 46E24 Matt Black_2_100.jpg",
                    "/images/MF 46E24 Matt Black_3_100.jpg",
                    "/images/MF 46E24 Matt Black_4_100.jpg",
                    "/images/MF 46E24 Matt Black_5_100.jpg",
                    "/images/MF 46E24 Matt Black Rustic_6_100.jpg",
                },
                IsOpened = false
            });

            list.Add(new Good()
            {
                Name = "MF 46E24 GREY",
                Price = 2599,
                PriceAction = 2339,
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
                    "/images/MF 46E24 Grey_1_1000.jpg",
                    "/images/MF 46E24 Grey_2_1000.jpg",
                    "/images/MF 46E24 Grey_3_1000.jpg",
                    "/images/MF 46E24 Grey_4_1000.jpg",
                    "/images/MF 46E24 Grey_5_1000.jpg",
                    "/images/MF 46E24 Matt Black Rustic_6_1000.jpg",
                },
                ImageLinksSmall = new List<string>(){
                    "/images/MF 46E24 Grey_1_400.jpg",
                    "/images/MF 46E24 Grey_2_100.jpg",
                    "/images/MF 46E24 Grey_3_100.jpg",
                    "/images/MF 46E24 Grey_4_100.jpg",
                    "/images/MF 46E24 Grey_5_100.jpg",
                    "/images/MF 46E24 Matt Black Rustic_6_100.jpg",
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
        public decimal PriceAction { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
