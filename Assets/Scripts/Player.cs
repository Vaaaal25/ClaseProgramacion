using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velCaminar;

    void Start()
    {
        
    }

    
    void Update()
    {
        float movX = Input.GetAxis("Horizontal")*velCaminar;
        float movY = Input.GetAxis("Vertical")*velCaminar;
    }
}
