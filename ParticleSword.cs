using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSword : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Setup(Vector2 velocity, Vector3 direction)
    {
        rb.velocity = velocity.normalized * speed;
        transform.rotation = Quaternion.Euler(direction);
    }

    public void OnEnterTrigger2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {            
            Destroy(this.gameObject);
        }
    }
}
