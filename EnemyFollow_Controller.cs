using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow_Controller : MonoBehaviour
{
    // References player position
    public Transform player;
    private Rigidbody2D rb;

    // Allows movement
    public float moveSpeed = 5f;
    private Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
        //rb.rotation = angle;

        direction.Normalize();
        movement = direction;
    }

    void FixedUpdate()
    {
        moveCharacter(movement);
    }

    void moveCharacter(Vector2 direction)
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
    }
}
