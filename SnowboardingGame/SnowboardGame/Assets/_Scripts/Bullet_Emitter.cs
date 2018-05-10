using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Emitter : MonoBehaviour {

    //Delcare Variables
    //Drag in the bullet emitter from the compenent inspector
    public GameObject Bullet_emitter;

    //Get the bullet prefab from the component inspector
    public GameObject Bullet;
    public GameObject Player;

    //bullet speed
    public float Bullet_Forward_Force;
    
   
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            //Game object to put bullet in
            GameObject Temporary_Bullet_Handler;
            //Spawn in bullet
            Temporary_Bullet_Handler = Instantiate(Bullet, Bullet_emitter.transform.position, Bullet_emitter.transform.rotation) as GameObject;

            //Correct rotation
            Temporary_Bullet_Handler.transform.Rotate(Vector3.left * 90);

            //Set bullet direction
            //Rigidbody for physics
            Rigidbody Temporary_Rigidbody;
            Temporary_Rigidbody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();

            Temporary_Rigidbody.AddForce(transform.forward * Bullet_Forward_Force);

            //Destroy bullet after 10 seconds THIS WILL BE REMOVED LATER WHEN COLISSIONS ARE PUT IN
            Destroy(Temporary_Bullet_Handler, 10.0f);
        }		 
	}
}
