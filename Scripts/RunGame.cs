using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RunGame : MonoBehaviour
{

    [SerializeField]
    private DialogueManager dialogueManager;

    [SerializeField]
    private TMP_InputField inputName;
    [HideInInspector]
    public string playerName;

    [SerializeField]
    private Canvas dialogueCanvas;
    [SerializeField]
    private Canvas nameInputCanvas;

    // Start is called before the first frame update
    void Start()
    {
       dialogueManager.gameObject.SetActive(false);
       dialogueCanvas.gameObject.SetActive(false);
       nameInputCanvas.gameObject.SetActive(true);
    }

    public void StartGame()
    {
        SetName();
        if(!playerName.Equals(""))
        {
            nameInputCanvas.gameObject.SetActive(false);
            dialogueManager.gameObject.SetActive(true);
            dialogueCanvas.gameObject.SetActive(true);
        }
    }

    public void SetName()
    {
        playerName = inputName.text;
    }
}
