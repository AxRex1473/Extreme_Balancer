using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    private void Start() 
    {
         
    }  

    private void Update() 
    {
        if(Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0f, 90f, 0f) * Time.deltaTime);
        }      
    }      
}
