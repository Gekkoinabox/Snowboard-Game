using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {


    public GameObject player;
    public float health = 50f;

    //private bool dead;

    private void Start()
    {

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

