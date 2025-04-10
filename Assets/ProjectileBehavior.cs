using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Explosion : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject particle;
    [SerializeField] private GameObject explosion;
    [SerializeField] private string tag;
    public GameObject player;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == tag)
        {
            explosion = Instantiate(particle, transform.position, transform.rotation);
            Destroy(explosion, 2f);

            if (tag == "Object")
            {
                Destroy(player);
            }
        }

    }
}
