using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       RaycastHit hit; 

       Debug.DrawRay(transform.position, transform.up*10,Color.red);

       if (Physics.Raycast(transform.position, transform.up,out hit, 10))
       {
       	Debug.Log("Ca touchheeeeuuuh!");
       }
    }
}
