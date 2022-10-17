using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Added to use SceneManager methods

public class AV_SceneController : MonoBehaviour
{
    GameObject sceneLoader;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    //Loads Game Scene on button press
    public void ButtonStartGame()
    {
        SceneManager.LoadScene("AV_CJGameScene");
    }
    //Loads Title Screen on button press
    public void ButtonTitleScreen()
    {
        SceneManager.LoadScene("AV_CJTitleScreen");
    }
    //Loads Win Scene
    public void WinScene()
    {
        SceneManager.LoadScene("AV_CJWinScene");
    }
    
}
