using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Play() {
        SceneManager.LoadScene("GameScene");
    }

    public void Exit() {
        Application.Quit();
    }

}
