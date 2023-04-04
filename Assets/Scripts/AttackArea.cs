using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    private int damage = 1;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.GetComponent<Health>() != null)
        {
            Health health = collider.GetComponent<Health>();
            health.Damage(damage);
        }if(collider.GetComponent<HealthEnemy>() != null)
        {
            HealthEnemy health = collider.GetComponent<HealthEnemy>();
            health.Damage(damage);
        }
    }

}
