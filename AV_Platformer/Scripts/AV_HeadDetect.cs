using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AV_HeadDetect : MonoBehaviour
{   //Parent object of HeadDetect
    GameObject Enemy;

    // Update is called once per frame
    void Update()
    {
        //Allows access to parent game object "Enemy"
        Enemy = gameObject.transform.parent.gameObject;
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //On collision this disables colliders of Enemy object and moves Enemy
        //down the y axis
        GetComponent<Collider2D>().enabled = false;
        Enemy.GetComponent<Collider2D>().enabled = false;
        Vector3 movement = new Vector3(Random.Range(30, 60), Random.Range(-40, -20), 0f);
        Enemy.transform.position += movement * Time.deltaTime;
    }
}
