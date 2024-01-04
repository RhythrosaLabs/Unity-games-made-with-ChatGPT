
using UnityEngine;
using System.Collections.Generic;

public class ResourceManagement : MonoBehaviour
{
    private Dictionary<string, int> resources = new Dictionary<string, int>();

    // Example method to add resources
    public void AddResource(string resourceName, int quantity)
    {
        if (resources.ContainsKey(resourceName))
        {
            resources[resourceName] += quantity;
        }
        else
        {
            resources.Add(resourceName, quantity);
        }
    }

    // Example method to use resources
    public bool UseResource(string resourceName, int quantity)
    {
        if (resources.ContainsKey(resourceName) && resources[resourceName] >= quantity)
        {
            resources[resourceName] -= quantity;
            return true; // Resource used successfully
        }
        return false; // Not enough resource or not found
    }
}
