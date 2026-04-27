using System;
using System.Collections.Generic;

namespace Galaxies
{
    /// <summary>
    /// Главный класс программы, выводящий список галактик и их характеристики.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в приложение. Создаёт список галактик и выводит их параметры в консоль.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            List<Galaxy> theGalaxies = new List<Galaxy>
            {
                new Galaxy() { Name = "Tadpole", MegaLightYears = 400, GalaxyType = new GType('S', 'B') },
                new Galaxy() { Name = "Pinwheel", MegaLightYears = 25, GalaxyType = new GType('S', 'U') },
                new Galaxy() { Name = "Milky Way", MegaLightYears = 0, GalaxyType = new GType('S', 'B') },
                new Galaxy() { Name = "Andromeda", MegaLightYears = 3, GalaxyType = new GType('S', 'B') }
            };

            foreach (Galaxy theGalaxy in theGalaxies)
            {
                Console.WriteLine(theGalaxy.Name + "  " + theGalaxy.MegaLightYears + ", " + theGalaxy.GalaxyType.MyGType);
            }

            Console.ReadKey();
        }
    }

    /// <summary>
    /// Описывает галактику с её именем, расстоянием и типом.
    /// </summary>
    public class Galaxy
    {
        /// <summary>Название галактики.</summary>
        public string Name { get; set; }

        /// <summary>Расстояние от Земли в мегасветовых годах.</summary>
        public int MegaLightYears { get; set; }

        /// <summary>Тип галактики (морфологическая классификация).</summary>
        public GType GalaxyType { get; set; }
    }

    /// <summary>
    /// Тип галактики, состоящий из основной категории и подтипа.
    /// </summary>
    public class GType
    {
        /// <summary>Основной тип галактики (например, 'S' — спиральная).</summary>
        public char MainType { get; }

        /// <summary>Подтип галактики (например, 'B' — с перемычкой).</summary>
        public char SubType { get; }

        /// <summary>
        /// Создаёт новый экземпляр типа галактики.
        /// </summary>
        /// <param name="type">Основная категория галактики.</param>
        /// <param name="subType">Подкатегория галактики.</param>
        public GType(char type, char subType)
        {
            MainType = type;
            SubType = subType;
        }

        /// <summary>
        /// Возвращает читаемое описание типа галактики.
        /// </summary>
        public string MyGType
        {
            get
            {
                if (MainType == 'S')
                {
                    switch (SubType)
                    {
                        case 'B':
                            return "Spiral Barred";
                        case 'U':
                            return "Spiral";
                        default:
                            break;
                    }
                }
                return "Other";
            }
        }
    }
}
