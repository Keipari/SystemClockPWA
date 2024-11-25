using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SystemClockScript : MonoBehaviour
{

    public GameObject textTime;
    DateTime systemTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        systemTime = DateTime.Now;
        textTime.GetComponent<Text>().text = systemTime.ToString("dd/MMM/yyyy - HH:mm:ss");
    }

}
