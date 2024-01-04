
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    private int runesCollected = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Rune"))
        {
            runesCollected++;
            Destroy(other.gameObject);
            // Update UI here
        }
        if(other.gameObject.CompareTag("Potion"))
        {
            // Increase health or spells
            Destroy(other.gameObject);
            // Update UI here
        }
    }
}
