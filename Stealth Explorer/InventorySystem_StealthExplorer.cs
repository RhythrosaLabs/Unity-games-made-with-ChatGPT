
using UnityEngine;
using System.Collections.Generic;

public class InventorySystem : MonoBehaviour
{
    private Dictionary<string, int> inventory = new Dictionary<string, int>();

    // Example method to add an item to the inventory
    public void AddItem(string item, int quantity)
    {
        if (inventory.ContainsKey(item))
        {
            inventory[item] += quantity;
        }
        else
        {
            inventory.Add(item, quantity);
        }
    }

    // Example method to use an item from the inventory
    public bool UseItem(string item, int quantity)
    {
        if (inventory.ContainsKey(item) && inventory[item] >= quantity)
        {
            inventory[item] -= quantity;
            return true; // Item used successfully
        }
        return false; // Item not used
    }
}
