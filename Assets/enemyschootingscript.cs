using UnityEngine;

public class enemyschootingscript : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform firePoint;
    public float projectileSpeed = 20f;
    public float fireRate = 0.5f;
    public GameObject player;

    private float nextFireTime = 0f;

    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            if (Time.time >= nextFireTime)
            {
                FireProjectile();
                nextFireTime = Time.time + fireRate;
            }
        }
        else
        {
            // No player detected, switch to automatic shooting every 1 second
            if (Time.time >= nextFireTime)
            {
                FireProjectile();
                nextFireTime = Time.time + 1f; // Automatic fire rate of 1 second
            }
        }
    }

    void FireProjectile()
    {
        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);

        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(firePoint.forward * projectileSpeed, ForceMode.VelocityChange);
        }
    }
}