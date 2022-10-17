using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AV_GameManager : MonoBehaviour
{
    //fields for the coin count
    public int coins = 0;
    public delegate void OnCoinChangedCallBack();
    public OnCoinChangedCallBack onCoinChangedCallBack;

    //Creates instance of GameManager object in Game Scene
    public static AV_GameManager instance;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    //Increments the variable of coins 
    public void AddCoinPoints(int points)
    {
        coins += points;
        onCoinChangedCallBack.Invoke();
    }
   
}
