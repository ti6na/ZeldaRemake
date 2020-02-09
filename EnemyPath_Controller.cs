using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPath_Controller : MonoBehaviour
{
    // Array of waypoints
    [SerializeField]
    private Transform[] waypoints;

    // Walkspeed
    [SerializeField]
    private float moveSpeed = 2f;

    // Index of waypoints
    private int waypointIndex = 0;
    
    // Start is called before the first frame update
    private void Start()
    {
        // Set position of first waypoint
        transform.position = waypoints[waypointIndex].transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (waypointIndex <= waypoints.Length - 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                waypoints[waypointIndex].transform.position, 
                moveSpeed * Time.deltaTime);

            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex++;
            }

            if (waypointIndex == waypoints.Length)
            {
                waypointIndex = 0;
            }
        }
    }
}
