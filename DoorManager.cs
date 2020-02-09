/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    [SerializeField]
    private Transform[] spawnLocation;

    // Index of waypoints
    private int spawnIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = spawnLocation[spawnIndex].transform.position;

        switch (PlayerData.spawnLocation)
        {
            case 1:
                // Door 1
                break;
            case 2:
                // Door 2 
                break;
            default:
                // Initial spawn
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

        }
    }

    /////////////////////////////////
    //        Camera Script        //
    /////////////////////////////////

    [SerializeField]
    public static float xAxisPlayer = 0f;
    public static float yAxisPlayer = 0f;
    public static float xAxisCamera = 0f;
    public static float yAxisCamera = 0f;

    void CameraMove()
    {
        transform.position = new Vector2(xAxisPlayer, yAxisPlayer);
        Camera.main.transform.position = new Vector3(xAxisCamera, yAxisCamera);
    }

    void CameraMove()
    {
        transform.position = new Vector2(-23.0f, 6.0f);
        Camera.main.transform.position = new Vector3(-23.0f, 11.15f, -10f);
    }
}*/
