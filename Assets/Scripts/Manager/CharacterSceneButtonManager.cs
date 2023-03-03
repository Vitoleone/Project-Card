using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSceneButtonManager : MonoBehaviour
{
    [SerializeField] GameObject levellingPanel;
    public void OpenCharacterLevellingPanel()
    {
        levellingPanel.SetActive(true);
    }
    public void CloseCharacterLevellingPanel()
    {
        levellingPanel.SetActive(false);
    }

    public void StartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void MenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
}
