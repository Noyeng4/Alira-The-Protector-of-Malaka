using UnityEngine;

public class LowHealingItem : MonoBehaviour
{
    public float healAmount = 20f; // Besarnya heal yang diberikan oleh item ini

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Health playerHealth = other.GetComponent<Health>();
            if (playerHealth != null)
            {
                playerHealth.Heal(healAmount);
                Destroy(gameObject); // Hancurkan item setelah diambil oleh player
            }
        }
    }
}