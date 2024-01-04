
using UnityEngine;

public class UpgradeSystem : MonoBehaviour
{
    public int upgradePoints = 0;

    // Example method to upgrade the player's abilities or equipment
    public void Upgrade(string upgradeType)
    {
        if (upgradePoints > 0)
        {
            // Add logic for different types of upgrades
            upgradePoints--;
        }
    }

    // Example method to earn upgrade points
    public void EarnUpgradePoints(int points)
    {
        upgradePoints += points;
    }
}
