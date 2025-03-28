using UnityEngine;

public class enemyhit : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Check if the object collides with a bullet (or any object with the "Projectile" tag)
        if (collision.gameObject.CompareTag("Projectile"))
        {
            Destroy(gameObject);  // Destroy the object this script is attached to
        }
    }
}