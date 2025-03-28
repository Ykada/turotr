using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 100f;  // Starting health of the player
    public float damageAmount = 10f;  // Amount of health to be taken per bullet hit

    // This method is called when the player is hit by a bullet
    public void TakeDamage(float damage)
    {
        health -= damage;  // Decrease health

        // Prevent health from going below zero
        if (health < 0)
        {
            health = 0;
        }

        // Optionally, you can handle a message here or feedback, but don't destroy the player
        Debug.Log("Player health: " + health);
    }

    // You can still have a method for updating the UI (if you choose to add one)
    public void UpdateHealthUI()
    {
        // You could update the health UI here (if you have one)
        // For example: healthText.text = "Health: " + health.ToString();
    }
}
