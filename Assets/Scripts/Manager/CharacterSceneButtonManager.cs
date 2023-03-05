using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSceneButtonManager : MonoBehaviour
{
    [SerializeField] GameObject levellingPanel;
    [SerializeField] private CharacterScriptableToGameObject characterScriptableToGameObject;
    private int i = 0;
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

    public void NextCharacterButton()
    {
        if (i < characterScriptableToGameObject.characters.Count-1)
        {
            i += 1;
            characterScriptableToGameObject.AssignCharacterProps(characterScriptableToGameObject.characters[i]);
        }
      
        
    }

    public void PreviousCharacterButton()
    {
        if (i > 0)
        {
            i -= 1;
            characterScriptableToGameObject.AssignCharacterProps(characterScriptableToGameObject.characters[i]);
        }
       
    }
    
}
