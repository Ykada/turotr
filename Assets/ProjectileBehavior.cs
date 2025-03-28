using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform firePoint;
    public float projectileSpeed = 20f;
    public float fireRate = 0.5f;
    public float lifetime = 5f;
    public GameObject impactEffectPrefab;

    public GameObject replacementObject;

    private float nextFireTime = 0f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time >= nextFireTime)
        {
            FireProjectile();
            nextFireTime = Time.time + fireRate;
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

        ProjectileLifetime projectileLifetime = projectile.AddComponent<ProjectileLifetime>();
        projectileLifetime.lifetime = lifetime;
        projectileLifetime.impactEffectPrefab = impactEffectPrefab;
        projectileLifetime.replacementObject = replacementObject;
    }
}

public class ProjectileLifetime : MonoBehaviour
{
    public float lifetime = 5f;
    public GameObject impactEffectPrefab;
    public GameObject replacementObject;

    public GameObject playerDeathEffectPrefab;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector3 collisionPosition = collision.gameObject.transform.position;

            if (playerDeathEffectPrefab != null)
            {
                Instantiate(playerDeathEffectPrefab, collisionPosition, Quaternion.identity);
            }

            Destroy(collision.gameObject);

            if (replacementObject != null)
            {
                Instantiate(replacementObject, collisionPosition, Quaternion.identity);
            }
        }

        if (impactEffectPrefab != null)
        {
            Vector3 impactPosition = collision.contacts[0].point;
            Quaternion impactRotation = Quaternion.LookRotation(collision.contacts[0].normal);
            Instantiate(impactEffectPrefab, impactPosition, impactRotation);
        }

        Destroy(gameObject);
    }
}
