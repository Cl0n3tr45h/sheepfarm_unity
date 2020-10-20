using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class Dialogue : MonoBehaviour {
    /*public string[] sentences;
    public float typingSpeed = 0.02f;
    private int index;

    
    IEnumerator Type(){ //use type only for people dialogue
        foreach(char letter in sentences[index].ToCharArray()){
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
    */
#pragma warning disable 0649
    [SerializeField] Image speakerPortrait;
    [SerializeField] TextMeshProUGUI txt_SpeakerName;
    [SerializeField] TextMeshProUGUI txt_Dialog;
#pragma warning restore 0649

    public DialogueRunner dialogueRunner;
    public static Dialogue instance;

    public void Awake () {
        instance = this;
    }
    public void Start () {
        //Hide ();
    }

    public void Show () {
        gameObject.SetActive (true);
    }

    public void Hide () {
        gameObject.SetActive (false);
    }
}