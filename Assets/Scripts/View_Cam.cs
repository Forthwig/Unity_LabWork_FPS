using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View_Cam : MonoBehaviour
{
	public float mouseSensitivity = 100f;
	public Transform playerBody;

	float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState= CursorLockMode.Locked; // Enleve le cursor en game (plutôt sympa)
    }

    // Update is called once per frame
    void Update()
    {
    	float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime ; // *time.demtatime nous permet d'être independant du nombre de frame 
    	float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime ;
        
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f,90f); //Restreint les mouvements de la tête sur x, ce qui nous évite des 3.6 de la tête impossible en réalité

        transform.localRotation = Quaternion.Euler(xRotation, 0f,0f);
        playerBody.Rotate(Vector3.up * mouseX);


    }
}
