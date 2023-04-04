using UnityEngine;
using System.Collections;

public class TrapMove : MonoBehaviour
{
    private BoxCollider2D trap;
    public float speed = 2.0f;

    private Vector3 targetPosition;

    private void Start()
    {
        targetPosition = transform.position;
    }

    void Update()
    {
        if (transform.position.x == -16f)
        {
            targetPosition.x = 0f;
        }
        

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }

}