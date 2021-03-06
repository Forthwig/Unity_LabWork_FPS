using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
	[SerializeField] private GameObject prefab = default; // = default est pour éviter les warnings
	[SerializeField] private Transform ballsParentTransdform = default;
	[SerializeField] private float spwaningSpeed = 1f; 
	[SerializeField] private float spawningForce = 500f; 
	private Transform cameraTransform;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(prefab,2); //Détruit la balle au bout de 2sec une fois tirer

    }

    void Awake(){
    	cameraTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnBall(){
    	GameObject ball = Instantiate(prefab, cameraTransform.position, Quaternion.identity, ballsParentTransdform);
    	ball.GetComponent<Rigidbody>().AddForce(cameraTransform.forward * spawningForce);
    }
}
