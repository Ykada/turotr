using UnityEngine;

public class enemyhit : MonoBehaviour
{
public string targettag;

    void OnCollisionEnter(Collision collision)
    {
        // Check if the object collides with a bullet (or any object with the "Projectile" ta
        if (collision.gameObject.CompareTag(targettag))
        {
            Destroy(gameObject);  // Destroy the object this script is attached to
        }
    }
}
