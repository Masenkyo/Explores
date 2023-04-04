using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthEnemy : MonoBehaviour
{
    [SerializeField] private int health = 100;

    private int MAX_HEALTH = 100;

    private GameObject player;

    public Sprite Kimmislukkeling;
    public Sprite Kimmislukkeling1;
    public Sprite Kimmislukkeling2;

    private void Start()
    {
        
    }
    void Update()
    {
        
    }

    public void Damage(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative Damage");
        }

        this.health -= amount;

        if (health <= 0)
        {
            Die();
        }

        if (health == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Kimmislukkeling1;
        }
        else if (health == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Kimmislukkeling2;
        }
    }

    public void Heal(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative Healing");
        }

        bool wouldBeOverMaxHealth = health + amount > MAX_HEALTH;

        if (wouldBeOverMaxHealth)
        {
            this.health = MAX_HEALTH;
        }
        else
        {
            this.health += amount;
        }
        
    }
    
    private void Die()
    {
        Debug.Log("I am Dead!");
        Destroy(gameObject);
    }
}
