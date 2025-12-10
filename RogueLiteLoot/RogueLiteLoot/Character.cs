using System;
using System.Collections.Generic;
using System.Text;
using RogueLiteLoot.LootItems;
using RogueLiteLoot.LootItems.Consumables;
using RogueLiteLoot.LootItems.Valuables;
using RogueLiteLoot.LootItems.Wearables;
using RogueLiteLoot.LootItems.Wieldables;

namespace RogueLiteLoot
{

    //character class, could be enemy, friendly, player.
    public class Character
    {
        public string name = "Gandalf";

        public List<Loot> inventory = new List<Loot>();

        public int strength = 1;
        public int healthPoints = 100;

        public int goldCoins = 0;

        public int armor = 0;
        public Loot? armorWorn = null;
        public int fashionRating = 0;
        public Loot? cosmeticApparel = null;

        public int meleeDamage = 0;
        public int rangedDamage = 0;
        public int magicDamage = 0;

        public Wieldable? heldWeapon = null;

        private Random rnd = new Random();
        

        //temporary "dummy" method for displaying the player information
        public void StartUpdateCharacterLoop()
        {
            BloatCharacterInventory();
            Printer.UpdateStats(this, "");
            while (true)
            {
                //open inventory
                if(Console.ReadKey().Key == ConsoleKey.I)
                {
                    Printer.ShowInventory(this);

                    ConsoleKey key = Console.ReadKey(true).Key;

                    // "dummy" temporary switch for handling inventory input
                    switch (key)
                    {
                        case ConsoleKey.Escape:
                            Printer.UpdateStats(this, "");
                            break;

                        case ConsoleKey.D0:
                        case ConsoleKey.NumPad0:
                            Use(inventory[0]);
                            break;

                        case ConsoleKey.D1:
                        case ConsoleKey.NumPad1:
                            Use(inventory[1]);
                            break;

                        case ConsoleKey.D2:
                        case ConsoleKey.NumPad2:
                            Use(inventory[2]);
                            break;

                        case ConsoleKey.D3:
                        case ConsoleKey.NumPad3:
                            Use(inventory[3]);
                            break;

                        case ConsoleKey.D4:
                        case ConsoleKey.NumPad4:
                            Use(inventory[4]);
                            break;

                        case ConsoleKey.D5:
                        case ConsoleKey.NumPad5:
                            Use(inventory[5]);
                            break;

                        case ConsoleKey.D6:
                        case ConsoleKey.NumPad6:
                            Use(inventory[6]);
                            break;

                        case ConsoleKey.D7:
                        case ConsoleKey.NumPad7:
                            Use(inventory[7]);
                            break;

                        case ConsoleKey.D8:
                        case ConsoleKey.NumPad8:
                            Use(inventory[8]);
                            break;

                        case ConsoleKey.D9:
                        case ConsoleKey.NumPad9:
                            Use(inventory[9]);
                            break;
                    }

                }
            }
        }

        private void BloatCharacterInventory()
        {
            inventory.Add(new HealingPotion(rnd.Next(1, 16)));
            inventory.Add(new Steak(rnd.Next(1, 4)));
            inventory.Add(new GlowingTalisman(rnd.Next(450, 580)));
            inventory.Add(new MithrilOreNugget(rnd.Next(240, 370)));
            inventory.Add(new JesterSuit(1));
            inventory.Add(new DwarvenSteelArmor(84));
            inventory.Add(new PaddedRingmail(55, 16));
            inventory.Add(new ElvenGreatsword(52));
            inventory.Add(new OrcishLongbow(18));
            inventory.Add(new TomeOfFireball(27));

        }

        public void Use(Loot loot)
        {
            string status = loot.ApplyEffect(this);

            Printer.UpdateStats(this, status);
        }
    }
}