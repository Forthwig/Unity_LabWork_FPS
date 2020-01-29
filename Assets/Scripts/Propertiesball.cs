using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propertiesball : MonoBehaviour
{
	private void OnCollisionEnter(Collision other){
		Destroy(gameObject);
			}

	private	void OnCollisionExit (Collision other){
		//throw new NotImplementedExeption();

	}

	

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
