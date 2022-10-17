using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AV_EnemyController : MonoBehaviour
{
    //Fields to input enemy speed and to get rigidbody
    public float speed;
    public Rigidbody2D rb2D;

    private void Update()
    {
        //checks that Enemy moves down the y axis from AV_HeadDetect and destroys Enemy object
        if (transform.position.y < -0.5)
        {
            Destroy(this.gameObject);
        }
    }
    //movement for Enemy starting towards the left
    private void FixedUpdate()
    {
        rb2D.velocity = new Vector2(-1 * speed * Time.fixedDeltaTime, 0);
    }
    //reverses direction when Enemy collide is triggered
    private void OnTriggerEnter2D(Collider2D collision)
    {
        speed = speed * -1;
    }
}
