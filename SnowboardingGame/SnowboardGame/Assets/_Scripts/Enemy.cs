using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {


   //GameObject player;
    public float startHealth = 100f;
    public float health = 100f;
    public float damage = 10f;
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

    protected virtual void setEnemy()
    {
        startHealth = 100f;
        health = 100f;
        damage = 10f;
        waitTime = 2f;
    }

    public virtual void Damage(float amount) //Make public so gun can access it 
    {
        health -= amount;
        healthBar.fillAmount = health / startHealth;

        if (health <= 0f)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        GameObject.Find("Player").GetComponent<Score>().AddScore(10);
        Destroy(gameObject);
    }

    protected virtual void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && Time.time >= timeUntilNextDamage)
        {
            
            Debug.Log("COLLIDING AND TAKING DAMAGE");
            timeUntilNextDamage = Time.time + 1f / fireRate;
            collision.gameObject.GetComponent<PlayerControllerRigidbody>().Damage(10f);
        }
    }
}

