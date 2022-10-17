using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AV_Item : MonoBehaviour
{
    //Determines the value of each coin to increment for each coin
    public int CoinValue = 1;

    //On trigger into coin it destroys coin and adds to coins vairable in AV_GameManager
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && collision is CapsuleCollider2D)
        {
            AV_GameManager.instance.AddCoinPoints(CoinValue);
            Destroy(this.gameObject);
        }
    }
}
