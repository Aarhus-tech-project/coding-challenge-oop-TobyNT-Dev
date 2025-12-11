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

        public Wieldable baseMelee = new Fists(5);

        public Wieldable? heldWeapon = null;

        private Random rnd = new Random();
        

        //temporary "dummy" method for displaying the player information
        public void StartUpdateCharacterLoop()
        {
            // on start set base melee weapon as fists
            Use(baseMelee);
            BloatCharacterInventory();
            Printer.UpdateStats(this, "");
            while (true)
            {
                //open the inventory
                if (Console.ReadKey().Key == ConsoleKey.I)
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

                //Un-Equip Items
                if (Console.ReadKey().Key == ConsoleKey.Delete)
                {
                    Printer.UpdateStats(this, "");

                    Console.SetCursorPosition(0, 15);
                    Console.WriteLine("Press Key to unequip: [A] Armor, [C] Cosmetic Outfit, [W] Weapon");

                    ConsoleKey key = Console.ReadKey(true).Key;
                    
                    Loot? itemSelected = null;
                    switch (key)
                    {
                        case ConsoleKey.Escape:
                            Printer.UpdateStats(this, "");
                            break;

                        case ConsoleKey.A:
                            itemSelected = UnEquip("armor");
                            break;

                        case ConsoleKey.C:
                            itemSelected = UnEquip("cosmetic");
                            break;

                        case ConsoleKey.W:
                            itemSelected = UnEquip("weapon");
                            break;
                    }
                    if (itemSelected != null)
                    {
                        Printer.UpdateStats(this, $"{itemSelected.Name} was unequipped, and placed in the inventory.");
                    }
                    else
                    {
                        Printer.UpdateStats(this, "");
                    }
                }
            }
        }

        //add lots of loot to the inventory
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
        public Loot UnEquip(string toUnequip)
        {
            Loot? itemUnequipped = null;
            if (toUnequip == "armor" && armorWorn != null)
            {
                if (armorWorn == cosmeticApparel)
                {
                    itemUnequipped = armorWorn;

                    cosmeticApparel = null;
                    inventory.Add(armorWorn);
                    armorWorn = null;
                }
                else
                {
                    itemUnequipped = armorWorn;


                    inventory.Add(armorWorn);
                    armorWorn = null;
                }
            }
            if (toUnequip == "cosmetic" && cosmeticApparel != null)
            {
                if (cosmeticApparel == armorWorn)
                {
                    itemUnequipped = cosmeticApparel;


                    armorWorn = null;
                    inventory.Add(cosmeticApparel);
                    cosmeticApparel = null;
                }
                else
                {
                    itemUnequipped = cosmeticApparel;


                    inventory.Add(cosmeticApparel);
                    cosmeticApparel = null;
                }
            }
            if (toUnequip == "weapon" && heldWeapon != null)
            {
                itemUnequipped = heldWeapon;


                inventory.Add(heldWeapon);
                heldWeapon = null;

                Use(baseMelee);
            }
            return itemUnequipped;
        }
    }
}