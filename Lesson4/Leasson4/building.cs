using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leasson4
{
    internal class Building
    {
        public static Guid GenerateNumberBuild { get; set; }
        private Guid NumberBuilding { get; }
        private float HeightHouseMetres { get; set; }
        private int NumberOfFloors { get; set; }
        private int NumberOfApartments { get; set; }
        private int Entrances { get; set; }

        internal Building(float HeightHouseMetres, int NumberOfFloors, int NumberOfApartments, int Entrances)
        {
            NumberBuilding = CreateNumberBuild();
            this.HeightHouseMetres = HeightHouseMetres;
            this.NumberOfFloors = NumberOfFloors;
            this.NumberOfApartments = NumberOfApartments;
            this.Entrances = Entrances;
        }

        internal Guid CreateNumberBuild()
        {
            return GenerateNumberBuild = Guid.NewGuid();
        }

        internal void SetHeightHouseMetres()
        {
            HeightHouseMetres = HeightHouseMetres;
        }

        internal void SetNumberOfFloors(int Changes)
        {
            NumberOfFloors = Changes;
        }

        internal void SetNumberOfApartments(int Changes)
        {
            NumberOfApartments = Changes;
        }

        internal void SetEntrances(int Changes)
        {
            Entrances = Changes;
        }

        internal void PrintInfoBuilding()
        {
            Console.WriteLine("Номер дома - " + NumberBuilding);
            Console.WriteLine("Высота - " + HeightHouseMetres);
            Console.WriteLine("Количество этажей - " + NumberOfFloors);
            Console.WriteLine("Количество квартир - " + NumberOfApartments);
            Console.WriteLine("Количество подъездов - " + Entrances);
            Console.WriteLine("Высота этажа - " + HeightHouseMetres/ NumberOfFloors);
            Console.WriteLine("Количество квартир в подъезде - " + CalculationOfApartmentsInTheEntrance());
            Console.WriteLine("Количество квартир на этаже - " + CalculationOfApartmentsInTheStoreys());
            Console.WriteLine();
            Console.WriteLine("Нажмите клавишу, чтобы продолжить...");
            Console.ReadKey();
        }

        internal double CalculationOfApartmentsInTheEntrance()
        {
            double result = NumberOfApartments / Entrances;
            if (NumberOfApartments % Entrances > 1)
            {
                result += 0.1;
            }
            return result;
        }

        internal int CalculationOfApartmentsInTheStoreys()
        {
            int result;
            result = (int)CalculationOfApartmentsInTheEntrance() / NumberOfFloors;

            return result;
        }



    }
}

/*Реализовать класс для описания здания (уникальный номер здания, высота, этажность, количество квартир, подъездов). +
Поля сделать закрытыми, предусмотреть методы для заполнения полей и получения значений полей для печати.  +
Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества квартир на этаже и т.д. +
Предусмотреть возможность, чтобы уникальный номер здания генерировался программно. +
Для этого в классе предусмотреть статическое поле, которое бы хранило последний использованный номер здания, и предусмотреть метод, который увеличивал бы значение этого поля. +
 * 
 */