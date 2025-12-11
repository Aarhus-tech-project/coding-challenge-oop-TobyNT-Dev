using RogueLiteLoot.LootItems;
using RogueLiteLoot.LootItems.Wearables;
using RogueLiteLoot.LootItems.Wieldables;
namespace RogueLiteLoot
{
    public static class Printer
    {
        public static void UpdateStats(Character character, string customItemText)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"Name: {character.name}");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine($"Health points: {character.healthPoints}");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine($"Strength: {character.strength}");
            Console.SetCursorPosition(0, 3);
            Console.WriteLine($"Armor Worn: {(character.armorWorn == null ? "none" : character.armorWorn.Name)} ({character.armor} armor)");
            Console.SetCursorPosition(0, 4);
            Console.WriteLine($"Cosmetic Outfit: {(character.cosmeticApparel == null ? "none" : character.cosmeticApparel.Name)} ({character.fashionRating} fashion rating)");
            Console.SetCursorPosition(0, 5);
            Console.WriteLine($"Held Weapon: {(character.heldWeapon == null ? "none" : character.heldWeapon.Name)}");
            Console.SetCursorPosition(0, 6);
            Console.WriteLine($"Melee Damage: {character.meleeDamage}");
            Console.SetCursorPosition(0, 7);
            Console.WriteLine($"Ranged Damage: {character.rangedDamage}");
            Console.SetCursorPosition(0, 8);
            Console.WriteLine($"Magic Damage: {character.magicDamage}"); 
            Console.SetCursorPosition(0, 9);
            Console.WriteLine($"Inventory has {character.inventory.Count()} items!");
            Console.SetCursorPosition(0, 10);
            Console.WriteLine($"Wallet Contains {character.goldCoins} Gold Coins!");
            Console.SetCursorPosition(0, 12);
            Console.WriteLine($"{customItemText}");
            Console.SetCursorPosition(0, 15);
            Console.WriteLine($"Press [I] to open {character.name}'s inventory");
            Console.SetCursorPosition(0, 16);
            Console.WriteLine($"Press [Delete] to unequip an item.");
        }
        public static void ShowInventory(Character character)
        {
            Console.Clear();
            int inventoryLength = character.inventory.Count;
            for (int i = 0; i < inventoryLength; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine($"{i}) {character.inventory[i].Name} ({character.inventory[i].Action})");
            }
            Console.SetCursorPosition(0, 15);
            Console.WriteLine("Press a number-key to use that item");
        }
    }
}
