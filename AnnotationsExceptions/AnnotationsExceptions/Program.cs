using NLog;
using System;
using System.Collections.Generic;
namespace AnnotationsExceptions
{
    delegate bool Sravnenie(string s1, string s2);
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            logger.Trace("logger.Trace");
            logger.Debug("logger.Debug");
            logger.Info("logger.Info");
            logger.Warn("logger.Warn");
            logger.Error("logger.Error");
            logger.Fatal("logger.Fatal");
            List<AbstractCar> Cars = new List<AbstractCar>
            {
               new HondaCivic(),
               new RenaultLogan(),
               new LadaPriora()
            };
            Console.WriteLine("Марки атомобилей:");
            Console.WriteLine();
            Cars.Sort();
            foreach (AbstractCar car in Cars)
            {
                Console.WriteLine(car.Model());
            }
            Console.WriteLine();
            Console.WriteLine("Введите марку автомобиля, информацию о котором вы хотели бы узнать:");
            string st = Console.ReadLine();
            bool flag = false;
            foreach (AbstractCar car in Cars)
            {
                string car1 = car.Model();
                try
                {
                    string userStr = st.Substring(0, car1.Length);
                    Sravnenie sr = (s1, s2) => s1 == s2;
                    if (sr(userStr, car1))
                    {

                        {
                            flag = true;
                            Console.WriteLine("Это - " + car.Model());
                            Console.WriteLine(car.EngineCapacity());
                            Console.WriteLine(car.BodyType());
                            Console.WriteLine(car.CarDrive());
                        }
                    }
                }
                catch (Exception) { }
                finally
                {
                    if (!flag)
                        Console.WriteLine("это не " + car1);
                }
            }
            if (flag == false)
                Console.WriteLine("Не верно введена марка");
            Console.ReadKey();
        }
    }
}
