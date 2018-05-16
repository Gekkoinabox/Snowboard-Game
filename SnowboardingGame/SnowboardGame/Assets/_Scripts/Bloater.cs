using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloater : Enemy {

    protected override void setEnemy()
    {
        base.setEnemy();
        startHealth = 500f;
        health = 500f;
        damage = 50f;
    }

    public override void Damage(float amount)
    {
        base.Damage(amount);
        health -= amount;
        healthBar.fillAmount = health / startHealth;

        if (health <= 0f)
        {
            Die();
        }
    }
}
