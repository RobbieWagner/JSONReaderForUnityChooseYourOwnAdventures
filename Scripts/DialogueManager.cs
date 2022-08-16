using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{

    public TextAsset textJSON;

    [System.Serializable]
    public class Scene
    {
        public Dialogue[] dialogues;
    }

    [System.Serializable]
    public class SceneList
    {
        public Scene[] scenes;
    }

    [System.Serializable]
    public class Dialogue
    {
        public int dialogueID;
        public Sentence[] sentences;
        public StrongChoice[] choices;
    }

    [System.Serializable]
    public class Sentence
    {
        public int textID;
        public string text;
        public WeakChoice[] choices;
    }

    [System.Serializable]
    public class WeakChoice
    {
        public string choiceText;
        public int nextTextID;
    }

    [System.Serializable]
    public class StrongChoice
    {
        public string choiceText;
        public int nextDialogueID;
    }

    public SceneList chapterScenes = new SceneList();

    void Start()
    {
        chapterScenes = JsonUtility.FromJson<SceneList>(textJSON.text);
    }
}
