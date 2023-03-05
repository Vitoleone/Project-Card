using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterScriptableToGameObject : MonoBehaviour
{
    public List<CharacterScriptable> characters;

    public TextMeshProUGUI characterLevel;
    public TextMeshProUGUI characterName;
    public Image characterImage;
    
    // Start is called before the first frame update
    void Start()
    {
        AssignCharacterProps(characters[0]);
    }

    public void AssignCharacterProps(CharacterScriptable character)
    {
        characterName.text = character.character.ToString();
        characterLevel.text = character.characterLevel.ToString();
        characterImage.sprite = character.characterImage;
    }
}
