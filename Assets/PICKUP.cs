using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PICKUP : MonoBehaviour
{
    public GameObject pickupobject;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameObject.Destroy(pickupobject, 0.5f); 
            
        }
    }
    void Start()
    {
    }
    void Update()
    {
        
    }
}

