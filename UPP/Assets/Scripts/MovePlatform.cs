using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public Rigidbody2D rb;
    public float v = 3f;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(-1, 0) * v;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.x >= 50 && rb.velocity.x > 0)
        {
            rb.velocity = new Vector2(-1, 0) * v;
        }
        else if (transform.position.x <= 37 && rb.velocity.x < 0)
        {
            rb.velocity = new Vector2(1, 0) * v;
        }
    }
}
