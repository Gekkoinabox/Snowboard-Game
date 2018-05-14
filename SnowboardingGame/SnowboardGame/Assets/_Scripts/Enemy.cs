using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {


   //GameObject player;
    public float startHealth = 100f;
    float health = 100f;
    float damage = 10f;
    float waitTime = 2f;

    float fireRate = 1f;
    float timeUntilNextDamage = 0f;

    public Image healthBar;

    //private bool dead;

    void Start()
    {
        health = startHealth;
    }
        
    // Update is called once per frame
    void Update () {
        GetComponent<UnityEngine.AI.NavMeshAgent>().destination = GameObject.Find("Player").GetComponent<PlayerControllerRigidbody>().transform.position;
	}

    public void Damage(float amount) //Make public so gun can access it 
    {
        health -= amount;
        healthBar.fillAmount = health / startHealth;

        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && Time.time >= timeUntilNextDamage)
        {
            Debug.Log("COLLIDING AND TAKING DAMAGE");
            timeUntilNextDamage = Time.time + 1f / fireRate;
            collision.gameObject.GetComponent<PlayerControllerRigidbody>().Damage(10f);
        }
    }
}

