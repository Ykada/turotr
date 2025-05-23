using System.Diagnostics.Tracing;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.tvOS;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

public class updatevaluecount : MonoBehaviour
{

    public GameObject[] objects;
    public GameObject valuegetting;
    public Canvas Canvas;
    public Text textcomponent;
    public int value = 0;

    void Start()
    {

        value = 0;

    }
    void Update()
    {
    GameObject.Find(" somethingsomethinglookatlater").GetComponent<Value>();
    value = +1;
    textcomponent.text = "score" + value;
}
}
