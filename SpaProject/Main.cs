using Autofac;
using SpaProject.Data;
using SpaProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaProject
{
    public class Main
    {
        private readonly ILifetimeScope _ILifeTimeScope;
        private readonly IContainer _Icontainer;
        public Main()
        {
            _Icontainer = IocContainer.Configure();
            _ILifeTimeScope = _Icontainer.BeginLifetimeScope();
        }

        public void FirstTask()
        {
            var nullcheck = _ILifeTimeScope.Resolve<INullCheckDatabase>();
            try
            {
                IRead read;
                if (!nullcheck.CheckIfEmpty().Result)
                { 
                    read = new ReadFromFile(); 
                }
                else
                {
                    read = new ReadNoAgain();
                }
                    Console.WriteLine("1. Feladat");
                    Console.WriteLine("{0}", read.ReadAndSave().Result);
                
            }
            catch (Exception)
            {
                Console.WriteLine("Váratlan hiba történt!");
            }
        }
        public void SecondTask()
        {
            var second = _ILifeTimeScope.Resolve<IFirstAndLastCustomerRepository>();
            try
            {
                Console.WriteLine("\n2. Feladat");
                Console.WriteLine("Az első vendég {0}-kor lépett ki az öltözőből.", second.FirstCustomer().Result.ToString("H:mm:ss"));
                Console.WriteLine("Az utolsó vendég {0}-kor lépett ki az öltözőből.", second.LastCustomer().Result.ToString("H:mm:ss"));
            }
            catch (Exception)
            {
                Console.WriteLine("Váratlan hiba történt!");
            }
        }
        public void ThirdTask()
        {
            var third = _ILifeTimeScope.Resolve<IOnlyUsedOneDepartmentRepository>();
            try
            {
                Console.WriteLine("\n3. Feladat");
                Console.WriteLine("A fürdőben {0} vendég járt csak egy részlegen.", third.OnesUsed().Result);

            }
            catch (Exception)
            {
                Console.WriteLine("Váratlan hiba történt!");
            }
        }
        public void FourthTask()
        {
            var fourth = _ILifeTimeScope.Resolve<ILongestTimeInTheSpaRepository>();
            try
            {
                var customer = fourth.LongestTime();
                Console.WriteLine("\n4. Feladat");
                Console.WriteLine("A legtöbb időt eltöltő vendég:");
                Console.WriteLine("{0}. vendég {1}", customer.Result.CustomerNumber, customer.Result.AllTime);
            }
            catch (Exception)
            {
                Console.WriteLine("Váratlan hiba történt!");
            }
        }
        public void FifthTask()
        {
            var fifth = _ILifeTimeScope.Resolve<ITimeStatisticRepository>();
            try
            {
                Console.WriteLine("\n5. Feladat");
                Console.WriteLine("6-9 óra között {0} vendég", fifth.Getsixtonine().Result);
                Console.WriteLine("9-16 óra között {0} vendég", fifth.Getninetosixten().Result);
                Console.WriteLine("16-20 óra között {0} vendég", fifth.Getsixtentotwenty().Result);


            }
            catch (Exception)
            {
                Console.WriteLine("Váratlan hiba történt!");
            }
        }
        public void SixthTask()
        {
            var ss = _ILifeTimeScope.Resolve<ISaveSauna>();
            try
            {
                    ss.SaveItem();
                    Console.WriteLine("\n6. Feladat");
                    Console.WriteLine("Szauna statisztika mentve az adatbázisba!");
            }
            catch (Exception)
            {
                Console.WriteLine("Váratlan hiba történt!");
            }
        }
        public void SeventhTask()
        {
            var seventh = _ILifeTimeScope.Resolve<IDepartmentsStatisticRepository>();
            try
            {
                Console.WriteLine("\n7. Feladat");
                Console.WriteLine("Uszoda: {0}", seventh.GetSwimmingPoolStatistic().Result);
                Console.WriteLine("Szaunák: {0}", seventh.GetSaunaStatistic().Result);
                Console.WriteLine("Gyógyvizes medencék: {0}", seventh.GetMedicalWaterStatistic().Result);
                Console.WriteLine("Strand: {0}", seventh.GetStrandStatistic().Result);
            }
            catch (Exception)
            {
                Console.WriteLine("Váratlan hiba történt!");
            }
        }
    }
}
