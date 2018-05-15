
using UnityEngine;

public class Gun : MonoBehaviour {

    public float damage = 10f; //Set damage
    public float range = 100f; //Set range you can shoot
    public float fireRate = 15f; //Set rate of fire for the gun
    
    public Camera fpsCam; //Set the camera we are going to use to shoot the raycast from
    public ParticleSystem muzzleFlash; //Set the particle system for the muzzle flash
    public GameObject impactEffect; //Set the game object for the ground impacts
    AudioSource gunShot;

    private float nextTimeToFire = 0f; //Set the net time to fire delay so we dont shoot constantly in a single beam
    
    void Start()
    {
        gunShot = GetComponent<AudioSource>();
    }

	// Update is called once per frame
	void Update () {
		
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire) //Check if the mouse button is being held down with its time to fire
        {
            nextTimeToFire = Time.time + 1f / fireRate; //Reset the time to fire next
            Shoot(); //Call the shoot function
            gunShot.Play();
        }
	}

    void Shoot() //Shoot function to handle shooting
    {
        muzzleFlash.Play(); //Play muzzle flash animation 
        RaycastHit hit; //Set raycast for collision
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range)) //Shoot the raycast out from the camera for the range
        {
            Debug.Log(hit.transform.name); //print in console what we hit

            Enemy enemy = hit.transform.GetComponent<Enemy>(); //Check if we hit an enemy

            if (enemy != null) //If we hit an enemy
            {
                enemy.Damage(damage); //Call the enemy damage function
            }

            GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal)); //Spawn impact particle as a instance so we can spawn multiple 
            Destroy(impactGO, 2f); //Destroy impact particle effect after 2 seconds
           
        }
    }
}
