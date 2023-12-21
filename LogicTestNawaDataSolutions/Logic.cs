using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTestNawaDataSolutions
{
    public static class Logic
    {
        public static void BonusCalculator()
        {
            Console.Write("Input minimal point per hari: ");
            int minimalPointPerDay = int.Parse(Console.ReadLine());

            int totalWeeks = 4;
            int workDaysPerWeek = 5;
            int totalStars = 0;
            bool isEligibleForBonus = true;

            for (int week = 1; week <= totalWeeks; week++)
            {
                Console.WriteLine($"Inputan task tiap hari/minggu untuk minggu ke-{week} (pisahkan dengan spasi):");
                string[] dailyPointsInput = Console.ReadLine().Split(' ');
                int weeklyPoints = 0;

                for (int day = 0; day < workDaysPerWeek; day++)
                {
                    int dailyPoints = int.Parse(dailyPointsInput[day]);
                    if (dailyPoints < minimalPointPerDay)
                    {
                        Console.WriteLine("Karyawan tidak memenuhi minimal point per hari.");
                        isEligibleForBonus = false;
                        break;
                    }
                    weeklyPoints += dailyPoints;
                }

                if (weeklyPoints >= 25)
                {
                    totalStars++;
                }
                else
                {
                    if (weeklyPoints < 25)
                    {
                        totalStars = Math.Max(0, totalStars - 1);
                    }
                    isEligibleForBonus = false;
                }
            }

            if (isEligibleForBonus && totalStars == totalWeeks)
            {
                Console.WriteLine("Karyawan berhak mendapatkan bonus.");
            }
            else
            {
                Console.WriteLine("Karyawan tidak berhak mendapatkan bonus.");
            }

            Console.WriteLine($"{totalStars} Bintang");
        }

    }
}
