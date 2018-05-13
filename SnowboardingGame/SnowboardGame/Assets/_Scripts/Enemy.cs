using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {


    public GameObject player;
    public float startHealth = 100f;
    private float health = 100f;

    public Image healthBar;

    //private bool dead;

    void Start()
    {
        health = startHealth;
    }

    // Update is called once per frame
    void Update () {
        GetComponent<UnityEngine.AI.NavMeshAgent>().destination = player.transform.position;
        //CheckIfDead(health);
	}

    //void CheckIfDead(float health)
    //{
    //    if (health <= 0)
    //    {
    //        dead = true;
    //        Destroy(gameObject);
    //    }
    //    else
    //    {
    //        dead = false;
    //    }
    //}

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
}

