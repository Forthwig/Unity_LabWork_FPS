
using UnityEngine;

public class Raycast : MonoBehaviour
{
	public float damage = 100f; //Dans l'optique de faire des dégats
	public	float range = 100f;
	public Camera fpsCam;



    // Update is called once per frame
    void Update()
    {
    	if(Input.GetButtonDown("Fire1"))
    	 {
    	 	Shoot();

    	 }

    }

    void Shoot()
    {
    	RaycastHit hit; 

    	if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
    	{
    	Debug.Log(hit.transform);
   		 }
    	//Range ici permet de prendre en comte la distance et donc de ne pas toucher des objetc trop loins
    }

}
