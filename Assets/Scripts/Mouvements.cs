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
    	float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Fire1")) shot.SpawnBall();
    
    }
}
