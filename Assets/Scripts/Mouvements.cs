using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvements : MonoBehaviour
{
	public CharacterController controller; 
	[SerializeField] private float speed = 0.1f;
	[SerializeField] private float Ballspawner = default;
	[SerializeField] private Shoot shot; 
 

    // Update is called once per frame
    void Update()
    {
    	float x = Input.GetAxis("Horizontal"); //On récup les x:z 
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z; 

        controller.Move(move * speed * Time.deltaTime); // L'emplois du Time.deltaTime permet de ne plus être dépendant des frames 

        if(Input.GetButtonDown("Fire1")) shot.SpawnBall(); // On regarde si on "Pioupioupiouuu"
    
    }
}
