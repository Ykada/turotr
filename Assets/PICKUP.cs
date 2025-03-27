using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PICKUP : MonoBehaviour
{
    public GameObject pickupobject;
    public Canvas numbercount;
    public Text textcomponent;

    public int value = 0;
    
    
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            
            GameObject.Destroy(pickupobject, 0.5f);
            value =+ 1;
            textcomponent.text = "score" + value;

            
        }
    }
    void Start()
    {
        textcomponent.text = "score" + value;
    }
    void Update()
    {
        
    }
}

