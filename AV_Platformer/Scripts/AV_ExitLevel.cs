using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AV_ExitLevel : MonoBehaviour
{
    //Field of AV_SceneController and instantiation of object
    AV_SceneController av_SceneController;
    [SerializeField] GameObject sceneController;

    ////Field of AV_GameManager and instantiation of object
    AV_GameManager av_gameManager;
    [SerializeField] GameObject gameManager;

    // Start is called before the first frame update
    void Awake()
    {
        //Allows access to respective scripts from Player and GameManager game objects
        av_SceneController = sceneController.GetComponent<AV_SceneController>();
        av_gameManager = gameManager.GetComponent<AV_GameManager>();
    }

    //if player collides with goal post at end of level, and the coins variable 
    //count is 5, then the WinScene loads
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && av_gameManager.coins == 5)
        {
            av_SceneController.WinScene();
        }
    }
}
