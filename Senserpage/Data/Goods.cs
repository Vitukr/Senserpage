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
            List<Good> list = new List<Good>();
            list.Add(new Good()
            {
                Name = "MF 46E24 BLACK RUSTIC",
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
                    "/images/MF 46E24 Matt Black Rustic -фронт.jpg",
                    "/images/MF 46E24 Matt Black Rustic -1.jpg",
                    "/images/MF 46E24 Matt Black Rustic -2.jpg",
                    "/images/MF 46E24 Matt Black Rustic -3.jpg",
                    "/images/MF 46E24 Matt Black Rustic -4.jpg",
                    "/images/MF 46E24 Matt Black Rustic -6.jpg"
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
                    "/images/MF 46E24 Beige Rustic -фронт.jpg",
                    "/images/MF 46E24 Beige Rustic -1.jpg",
                    "/images/MF 46E24 Beige Rustic -2.jpg",
                    "/images/MF 46E24 Beige Rustic -3.jpg",
                    "/images/MF 46E24 Beige Rustic -5.jpg",
                    "/images/MF 46E24 Beige Rustic -6.jpg"
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
                    "Колір: червона панель + чорні стінки",
                    "Габарити (ВхШхГ), см: 36 х 62 х 47",
                    "Країна виробництва - Туреччина",
                    "Гарантія - 12 місяців"
                },
                ImageLinks = new List<string>(){
                    "/images/MF 46E24 Burgundy -фронт.jpg",
                    "/images/MF 46E24 Burgundy -1.jpg",
                    "/images/MF 46E24 Burgundy -2.jpg",
                    "/images/MF 46E24 Burgundy -3.jpg",
                    "/images/MF 46E24 Burgundy -4.jpg",
                    "/images/MF 46E24 Burgundy -5.jpg"
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
                    "Колір: чорна панель + червоні стінки",
                    "Габарити (ВхШхГ), см: 36 х 62 х 47",
                    "Країна виробництва - Туреччина",
                    "Гарантія - 12 місяців"
                },
                ImageLinks = new List<string>(){
                    "/images/MF 46E24 Matt Black -фронт.jpg",
                    "/images/MF 46E24 Matt Black -1.jpg",
                    "/images/MF 46E24 Matt Black -2.jpg",
                    "/images/MF 46E24 Matt Black -3.jpg",
                    "/images/MF 46E24 Matt Black -5.jpg",
                    "/images/MF 46E24 Matt Black -6.jpg"
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
                    "/images/MF 46E24 Grey -фронт.jpg",
                    "/images/MF 46E24 Grey -1.jpg",
                    "/images/MF 46E24 Grey -2.jpg",
                    "/images/MF 46E24 Grey -3.jpg",
                    "/images/MF 46E24 Grey -5.jpg",
                    "/images/MF 46E24 Grey -6.jpg"
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
                    "/images/MF 46E24 Wooden_1.jpg",
                    "/images/MF 46E24 Wooden_2.jpg",
                    "/images/MF 46E24 Wooden_3.jpg",
                    "/images/MF 46E24 Wooden_4.jpg",
                    "/images/MF 46E24 Wooden_5.jpg",
                    "/images/MF 46E24 Wooden_6.jpg",
                    "/images/MF 46E24 Wooden_7.jpg",
                    "/images/MF 46E24 Wooden_8.jpg",
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
