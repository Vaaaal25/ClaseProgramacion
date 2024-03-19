using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float velCaminar;
<<<<<<< HEAD
=======

>>>>>>> af0df91d5726b6fb592cae6719332cde0e94a447
    void Start()
    {
        
    }

<<<<<<< HEAD
    
=======
    // Update is called once per frame
>>>>>>> af0df91d5726b6fb592cae6719332cde0e94a447
    void Update()
    {
        float movX = Input.GetAxis("Horizontal")*velCaminar;
        float movY = Input.GetAxis("Vertical")*velCaminar;
<<<<<<< HEAD
    }
=======
        transform.Translate(movX, 0, movY);
    }

  
>>>>>>> af0df91d5726b6fb592cae6719332cde0e94a447
}
