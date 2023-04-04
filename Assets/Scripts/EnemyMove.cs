using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour
{
    private Rigidbody2D KimEnemy1;
    public float speed = 2.0f;

    private Vector3 targetPosition;

    private void Start()
    {
        targetPosition = transform.position;
    }

    void Update()
    {
        if (transform.position.x == 16f)
        {
            targetPosition.x = 12f;
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (transform.position.x == 12f)
        {
            targetPosition.x = 16f;
            GetComponent<SpriteRenderer>().flipX = true;
        }

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }

}