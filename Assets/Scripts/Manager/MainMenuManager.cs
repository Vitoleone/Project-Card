using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject optionsPanel;
    public void StartButton()
    {
        SceneManager.LoadScene("Scenes/CharacterScene");
    }

    public void OptionsButton()
    {
        optionsPanel.SetActive(true);
    }

    public void OptionsButtonDisable()
    {
        optionsPanel.SetActive(false);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
    
}
