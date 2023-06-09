using System;
using System.Collections.Generic;

namespace ТХИ4
{
    interface IPrint
    {
        void Print();
    }

    class AbstractCar
    {
        private string _Name;
        private int _Capacity;
        private double _Cost;


        public void SetName(string name) { _Name = name; }
        public void SetCapacity(int capacity) { _Capacity = capacity; }
        public void SetCost(double cost) { _Cost = cost; }

        public string GetName() { return _Name; }
        public int GetCapacity() { return _Capacity; }
        public double GetCost() { return _Cost; }
    }

    class Sedan : AbstractCar, IPrint
    {
        private string _Colour;
        public void SetColour(string colour) { _Colour = colour; }
        public string GetColour() { return _Colour; }
        public void Print()
        {
            Console.WriteLine($"Название: {GetName()}");
            Console.WriteLine($"Вместимость: {GetCapacity()}");
            Console.WriteLine($"Стоимость: {GetCost()}");
            Console.WriteLine($"Цвет: {GetColour()}");
        }
    }


    class Hatchback : AbstractCar, IPrint
    {
        private double _EnginePower;
        public void SetEnginePower(double engine_power) { _EnginePower = engine_power; }
        public double GetEnginePower() { return _EnginePower; }
        public void Print()
        {
            Console.WriteLine($"Название: {GetName()}");
            Console.WriteLine($"Вместимость: {GetCapacity()}");
            Console.WriteLine($"Стоимость: {GetCost()}");
            Console.WriteLine($"Мощность двигателя: {GetEnginePower()}");
        }
    }
    class Fleet
    {
        public List<AbstractCar> ListOfCars = new List<AbstractCar>();

        public void CostCount()
        {
            double totalCost = 0;
            foreach (AbstractCar p in ListOfCars)
            {
                totalCost += p.GetCost();
            }
            Console.WriteLine("Стоимость {0}:", totalCost);
        }
        public void ShowInfo(IPrint p)
        {
            p.Print();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Sedan();
            p1.SetName("Infiniti G25");
            p1.SetCapacity(4);
            p1.SetCost(820000);
            p1.SetColour("Черный");


            var p2 = new Hatchback();
            p2.SetName("Honda N-WGN");
            p2.SetCapacity(4);
            p2.SetCost(480000);
            p2.SetEnginePower(64);

            var p3 = new Sedan();
            p3.SetName("Hyundai Solaris");
            p3.SetCapacity(4);
            p3.SetCost(1160000);
            p3.SetColour("Синий");


            var p4 = new Hatchback();
            p4.SetName("Hatchback");
            p4.SetCapacity(4);
            p4.SetCost(1580000);
            p4.SetEnginePower(136);




            var listObject = new Fleet();
            listObject.ListOfCars.Add(p1);
            listObject.ListOfCars.Add(p2);
            listObject.ListOfCars.Add(p3);
            listObject.ListOfCars.Add(p4);


            foreach (IPrint p in listObject.ListOfCars)
            {
                listObject.ShowInfo(p);
                Console.WriteLine();
                Console.WriteLine();
            }

            listObject.CostCount();

            Console.ReadKey();
        }
    }
}
