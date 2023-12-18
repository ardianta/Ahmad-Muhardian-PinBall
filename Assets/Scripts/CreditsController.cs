using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class CreditsController : MonoBehaviour
{

    public Button mainMenuButton;
    
    // Start is called before the first frame update
    void Start()
    {
        mainMenuButton.onClick.AddListener(MainMenu);  
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}