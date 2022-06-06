using FlowerShop.Interfaces;
using FlowerShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    public class FlowerShop
    {
        public float Money { get; set; }
        public IRose Rose { get; set; }
        public IGladiola Gladiola { get; set; }
        public IHydrangeas Hydrangeas { get; set; }
        public FlowerShop()
        {
            Rose = new Rose();
            Gladiola = new Gladiola();
            Hydrangeas = new Hydrangeas();
            Money = 0;
            Shop();
        }

        public void Inventory()
        {
            Console.Clear();

            Console.WriteLine("                       Flower Shop Inventory\n\n");
            Console.WriteLine("Roses : " + Rose.Number);
            Console.WriteLine("\nGladiolus : " + Gladiola.Number);
            Console.WriteLine("\nHydrangeas : " + Hydrangeas.Number);
            Console.WriteLine("\nMoney : " + Money);

            BackFunction();
        }

        public void OutOfStock()
        {
            Console.Clear();
            Console.WriteLine("WE ARE SORRY! THAT IS OUT OF STOCK...");
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
            Shop();
        }

        public void Shop()
        {
            Console.WriteLine("                          Flower Shop\n\n");
            ShowBouquets();
            ShowFlowers();
            ShowMore();
            TakeAction();
        }

        public void ShowBouquets()
        {
            Console.WriteLine("                                                           Bouquets");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine(" 1.      BIG BOUQUET         -       330 LEI    [A] \n( 9 roses, 10 gladiolus and 3 hydrangeas )\n");
            Console.WriteLine(" 2.      MEDIUM BOUQUET      -       135 LEI    [B] \n( 6 roses and 5 gladiolus )\n");
            Console.WriteLine(" 3.      SMALL BOUQUET       -        50 LEI    [C] \n( 5 roses )\n\n");
        }

        public void ShowFlowers()
        {
            Console.WriteLine("                                                            Flowers");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine(" 4.      ROSE                -        10 LEI    [D] \n");
            Console.WriteLine(" 5.      GLADIOLA            -        15 LEI    [E] \n");
            Console.WriteLine(" 6.      HYDRANGEA           -        30 LEI    [F] \n\n");
        }

        public void ShowMore()
        {
            Console.WriteLine("                                                               More");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine(" 7.      INVENTORY                              [G] \n");
            Console.WriteLine(" 8.      FLOWERS SOLD IN ONE WEEK               [H] \n");
            Console.WriteLine(" 9.      EXIT                                   [I] \n\n");
        }

        public void TakeAction()
        {
            var response = Console.ReadLine();
            MakeAction(response);
        }

        public void MakeAction(string response)
        {
            switch (response)
            {
                case "A":
                    VerifyBigBouqhets();
                    break;
                case "B":
                    VerifyMediumBouquets();
                    break;
                case "C":
                    VerifySmallBouquets();
                    break;
                case "D":
                    VerifyRoseNumber(1);
                    break;
                case "E":
                    VerifyGladiolaNumber(1);
                    break;
                case "F":
                    VerifyHydrangeasNumber(1);
                    break;
                case "G":
                    Inventory();
                    break;
                case "H":
                    DecreaseFlowersSoldWeek();
                    break;
                case "I":
                    Environment.Exit(0);
                    break;
                case "a":
                    VerifyBigBouqhets();
                    break;
                case "b":
                    VerifyMediumBouquets();
                    break;
                case "c":
                    VerifySmallBouquets();
                    break;
                case "d":
                    VerifyRoseNumber(1);
                    break;
                case "e":
                    VerifyGladiolaNumber(1);
                    break;
                case "f":
                    VerifyHydrangeasNumber(1);
                    break;
                case "g":
                    Inventory();
                    break;
                case "h":
                    DecreaseFlowersSoldWeek();
                    break;
                case "i":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("WRONG ACTION! Please press again.");
                    TakeAction();
                    break;

            }

            Shop();
        }

        public void VerifyRoseNumber(int wanted)
        {
            if (Rose.Number < wanted)
            {
                OutOfStock();
            }
            else
            {
                SellRose(wanted);
            }
        }

        public void SellRose(int wanted)
        {
            Rose.Number -= wanted;
            Money += (wanted * Rose.Price);
        }

        public void VerifyGladiolaNumber(int wanted)
        {
            if (Gladiola.Number < wanted)
            {
                OutOfStock();
            }
            else
            {
                SellGladiola(wanted);
            }
        }

        public void SellGladiola(int wanted)
        {
            Gladiola.Number -= wanted;
            Money += (wanted * Gladiola.Price);
        }

        public void VerifyHydrangeasNumber(int wanted)
        {
            if (Hydrangeas.Number < wanted)
            {
                OutOfStock();
            }
            else
            {
                SellHydrangeas(wanted);
            }
        }

        public void SellHydrangeas(int wanted)
        {
            Hydrangeas.Number -= wanted;
            Money += (wanted * Hydrangeas.Price);
        }

        public void VerifyBigBouqhets()
        {
            VerifyRoseNumber(9);
            VerifyGladiolaNumber(10);
            VerifyHydrangeasNumber(3);
        }

        public void VerifyMediumBouquets()
        {
            VerifyRoseNumber(6);
            VerifyGladiolaNumber(5);
        }

        public void VerifySmallBouquets()
        {
            VerifyRoseNumber(5);
        }

        public void DecreaseFlowersSoldWeek()
        {
            Console.Clear();
            Console.WriteLine("              In a week the FlowerShop sells :\n\n");
            Console.WriteLine("     Name        : Pieces : Price\n");
            Console.WriteLine("---------------------------------------------------------\n");
            Console.WriteLine(" Big Bouquets    :  13    : 4290 LEI\n");
            Console.WriteLine(" Medium Bouquets :  10    : 1350 LEI\n");
            Console.WriteLine(" Small Bouquets  :  12    :  600 LEI\n");
            Console.WriteLine(" Roses           :  15    :  150 LEI\n");
            Console.WriteLine(" Gladiolus       :  10    :  150 LEI\n");
            Console.WriteLine(" Hydrangeas      :  25    :  750 LEI\n");
            Console.WriteLine("---------------------------------------------------------\n");
            Console.WriteLine(" Roses           : 252    : 2520 LEI\n");
            Console.WriteLine(" Gladiolus       : 190    : 2850 LEI\n");
            Console.WriteLine(" Hydrangeas      :  64    : 1920 LEI\n");
            Console.WriteLine("---------------------------------------------------------\n");
            Console.WriteLine("                 Total    : 7290LEI");

            BackFunction();
        }

        public void BackFunction()
        {
            Console.WriteLine("\n\n\nPress [B] to go back...");

            var response = Console.ReadLine();

            while (response != "B" && response != "b")
            {
                response = Console.ReadLine();
            }
            Console.Clear();
            Shop();
        }
    }
}
