using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AV_HUDManager : MonoBehaviour
{
    public TextMeshProUGUI coinText;

    // Start is called before the first frame update
    void Start()
    {
        //Sets text of the UI
        coinText.text = "Coins: 0";
        AV_GameManager.instance.onCoinChangedCallBack += UpdateCoin;
    }
    //Updates coin count on the HUD
    private void UpdateCoin()
    {
        coinText.text = "Coins: " + AV_GameManager.instance.coins;
    }
}
