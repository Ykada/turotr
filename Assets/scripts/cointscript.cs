using NUnit.Framework;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cointscript : MonoBehaviour
{
    public int score;
    public float time = 25f;
    public List<GameObject> Coins;
    public LayerMask coinLayerMask;
    float x;
    float y;
    float z;
    Vector3 pos;
    void Start()
    {
        foreach (GameObject coinPrefab in Coins)
        {
            float x = Random.Range(-5f, 5f);
            float z = Random.Range(-5f, 5f);
            Vector3 pos = new Vector3(x, y, z);

            Instantiate(coinPrefab, pos, Quaternion.identity);
        }
        score = 0;
        Coins = new List<GameObject>(GameObject.FindGameObjectsWithTag("Coin"));
        foreach (GameObject coin in Coins)
        {
            coin.GetComponent<Collider>().isTrigger = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            score++;
            Debug.Log("Score: " + score);
            Destroy(collision.gameObject);
        }
    }
    void Update()
    {
        if (score >= 5)
        {
            Debug.Log("You win");
        }
        if (time <= 0)
        {
            Debug.Log("Game Over");
        }
        else
        {
            time -= Time.deltaTime;
            Debug.Log("Time left: " + time + score);
            Debug.Log("Score: " + score);
        }
    }
}