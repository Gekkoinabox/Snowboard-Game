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
}
