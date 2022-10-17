using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AV_PlayerCamera : MonoBehaviour
{
    public GameObject player;
    private Vector3 playerPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Sets position of camera to the player object and has it follow the player as they move around the level
        playerPosition = transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
    }
}
