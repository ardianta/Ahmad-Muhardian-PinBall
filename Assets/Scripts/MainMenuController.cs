using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;

    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        exitButton.onClick.AddListener(ExitGame);
    }


    public void PlayGame()
    {
        SceneManager.LoadScene("Pinball Game");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
