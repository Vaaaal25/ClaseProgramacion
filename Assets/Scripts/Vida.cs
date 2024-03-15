using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public int VidaPlayer;

    private void Update()
    {
        if(VidaPlayer <=0)
        {
            Debug.Log("game over");
        }
    }
}
