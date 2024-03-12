using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaCaer : MonoBehaviour
{
  bool isFalling = false;
  float downSpeed = 0;

  void OnTriggerEnter(Collider collider)
  {
    if(collider.gameObject.name == "Player")
    {
      isFalling = true;
      Destroy(gameObject, 10);
    }
  }
  
    
    void Start()
    {
       
    }

    void Update()
    {
        if (isFalling)
        {
          downSpeed += Time.deltaTime/200;
          transform.position = new Vector3(transform.position.x, transform.position.y+downSpeed, transform.position.z);

        }
    }
}
