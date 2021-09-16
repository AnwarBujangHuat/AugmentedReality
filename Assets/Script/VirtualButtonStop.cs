using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using System;
class VirtualButtonStop : MonoBehaviour
{
    public
     GameObject Vida;
    VirtualButtonBehaviour vb;
    // Start is called before the first frame update
    void Start()
    {
        Vida.SetActive(false);
        Debug.Log("Start");
        vb = GetComponentInChildren<VirtualButtonBehaviour>();
        vb.RegisterOnButtonPressed(OnButtonPressed);
        


    }
    void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Vida.SetActive(false);
        Debug.Log("Button Pressed");
    }




}