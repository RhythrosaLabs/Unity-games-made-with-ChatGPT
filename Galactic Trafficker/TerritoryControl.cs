
using UnityEngine;
using System.Collections.Generic;

public class TerritoryControl : MonoBehaviour
{
    // Dictionary to keep track of controlled territories
    private Dictionary<string, bool> territories = new Dictionary<string, bool>();

    void Start()
    {
        // Initialize territories
        // Example: territories.Add("TerritoryName", false);
    }

    // Example method to take control of a territory
    public void TakeControl(string territoryName)
    {
        if (territories.ContainsKey(territoryName))
        {
            territories[territoryName] = true;
        }
    }

    // Example method to lose control of a territory
    public void LoseControl(string territoryName)
    {
        if (territories.ContainsKey(territoryName))
        {
            territories[territoryName] = false;
        }
    }

    // Method to check control status of a territory
    public bool IsControlled(string territoryName)
    {
        return territories.ContainsKey(territoryName) && territories[territoryName];
    }
}
