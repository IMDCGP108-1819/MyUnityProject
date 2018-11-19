using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float HorizontalMovement;
    public Rigidbody2D rb;

    private void LateUpdate()
    {
        if (transform.position.x > 8.5)
        {
            transform.position = new Vector3(8.5f, transform.position.y);
        }

        if (transform.position.x < -8.5)
        {
            transform.position = new Vector3(-8.5f, transform.position.y);
        }
    }

    void FixedUpdate () {
        float horizontal = Input.GetAxis("Horizontal") * HorizontalMovement;

        rb.velocity = new Vector2(horizontal, rb.velocity.y); 
	}
}
