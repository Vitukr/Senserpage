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
                    "Конвекция",
                    "Гриль",
                    "Разморозка",
                    "Термостат, °С - 280",
                    "Мощность, кВт - 1,6",
                    "Таймер, мин - 90",
                    "Автоотключение",
                    "Кол-во режимов приготовления - 5",
                    "Резиновый уплотнитель (полная изоляция)",
                    "Комплектация: 2 лотка + 1 решётка",
                    "Объём, л - 46",
                    "Двойное стекло духовки",
                    "Внутренне покрытие - эмаль лёгкой очистки",
                    "Цвет: красно-чёрный",
                    "Габариты (ВхШхГ), см: 36 х 62 х 47",
                    "Страна производства - Турция",
                    "Гарантия - 12 месяцев"
                },
                ImageLinks = new List<string>(){
                    "/images/senser1.jpg",
                    "/images/senser11.jpg",
                    "/images/senser12.jpg",
                    "/images/senser13.jpg",
                    "/images/senser14.jpg",
                    "/images/senser15.jpg"
                },
                IsOpened = false
            }); ;

            list.Add(new Good()
            {
                Name = "MF 46E24 BEIGE RUSTIC",
                Price = 3299,
                Attributes = new List<string>(){
                    "Конвекция",
                    "Гриль",
                    "Разморозка",
                    "Термостат, °С - 280",
                    "Мощность, кВт - 1,6",
                    "Таймер, мин - 90",
                    "Автоотключение",
                    "Кол-во режимов приготовления - 5",
                    "Резиновый уплотнитель (полная изоляция)",
                    "Комплектация: 2 лотка + 1 решётка",
                    "Объём, л - 46",
                    "Двойное стекло духовки",
                    "Внутренне покрытие - эмаль лёгкой очистки",
                    "Цвет: красно-чёрный",
                    "Габариты (ВхШхГ), см: 36 х 62 х 47",
                    "Страна производства - Турция",
                    "Гарантия - 12 месяцев"
                },
                ImageLinks = new List<string>(){
                    "/images/senser2.jpg",
                    "/images/senser21.jpg",
                    "/images/senser22.jpg",
                    "/images/senser23.jpg",
                    "/images/senser24.jpg",
                    "/images/senser25.jpg"
                },
                IsOpened = false
            });

            list.Add(new Good()
            {
                Name = "MF 46E24 MATT BURGUNDY",
                Price = 2599,
                Attributes = new List<string>(){
                    "Конвекция", 
                    "Гриль",
                    "Разморозка",
                    "Термостат, °С - 280",
                    "Мощность, кВт - 1,6",
                    "Таймер, мин - 90",
                    "Автоотключение",
                    "Кол-во режимов приготовления - 5",
                    "Резиновый уплотнитель (полная изоляция)",
                    "Комплектация: 2 лотка + 1 решётка",
                    "Объём, л - 46",
                    "Внутренне покрытие - эмаль лёгкой очистки",
                    "Цвет: красно-чёрный",
                    "Габариты (ВхШхГ), см: 36 х 62 х 47",
                    "Страна производства - Турция",
                    "Гарантия - 12 месяцев"
                },
                ImageLinks = new List<string>(){
                    "/images/senser3.jpg",
                    "/images/senser31.jpg",
                    "/images/senser32.jpg",
                    "/images/senser33.jpg",
                    "/images/senser34.jpg",
                    "/images/senser35.jpg"
                },
                IsOpened = false
            });

            list.Add(new Good()
            {
                Name = "MF 46E24 MATT BLACK",
                Price = 2599,
                Attributes = new List<string>(){
                    "Конвекция",
                    "Гриль",
                    "Разморозка",
                    "Термостат, °С - 280",
                    "Мощность, кВт - 1,6",
                    "Таймер, мин - 90",
                    "Автоотключение",
                    "Кол-во режимов приготовления - 5",
                    "Резиновый уплотнитель (полная изоляция)",
                    "Комплектация: 2 лотка + 1 решётка",
                    "Объём, л - 46",
                    "Внутренне покрытие - эмаль лёгкой очистки",
                    "Цвет: красно-чёрный",
                    "Габариты (ВхШхГ), см: 36 х 62 х 47",
                    "Страна производства - Турция",
                    "Гарантия - 12 месяцев"
                },
                ImageLinks = new List<string>(){
                    "/images/senser4.jpg",
                    "/images/senser41.jpg",
                    "/images/senser42.jpg",
                    "/images/senser43.jpg",
                    "/images/senser44.jpg",
                    "/images/senser45.jpg"
                },
                IsOpened = false
            });

            list.Add(new Good()
            {
                Name = "MF 46E24 GREY",
                Price = 2599,
                Attributes = new List<string>(){
                    "Конвекция",
                    "Гриль",
                    "Разморозка",
                    "Термостат, °С - 280",
                    "Мощность, кВт - 1,6",
                    "Таймер, мин - 90",
                    "Автоотключение",
                    "Кол-во режимов приготовления - 5",
                    "Резиновый уплотнитель (полная изоляция)",
                    "Комплектация: 2 лотка + 1 решётка",
                    "Объём, л - 46",
                    "Внутренне покрытие - эмаль лёгкой очистки",
                    "Цвет: красно-чёрный",
                    "Габариты (ВхШхГ), см: 36 х 62 х 47",
                    "Страна производства - Турция",
                    "Гарантия - 12 месяцев"
                },
                ImageLinks = new List<string>(){
                    "/images/senser5.jpg",
                    "/images/senser51.jpg",
                    "/images/senser52.jpg",
                    "/images/senser53.jpg",
                    "/images/senser54.jpg",
                    "/images/senser55.jpg"
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
