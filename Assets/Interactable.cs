using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour {

    [SerializeField] string yarnStartNode;
    [SerializeField] YarnProgram yarnDialogue;
    public bool playerInRange = false;

    void Start () {
        Dialogue.instance.dialogueRunner.Add (yarnDialogue);
    }

    // Update is called once per frame
    void Update () {
        checkForInteraction ();
    }

    void OnTriggerEnter2D (Collider2D otherCollider) {
        if (otherCollider.CompareTag ("Player")) {
            playerInRange = true;
        }
    }

    void OnTriggerExit2D (Collider2D otherCollider) {
        if (otherCollider.CompareTag ("Player")) {
            playerInRange = false;
        }
    }
    void checkForInteraction () {
        //if (Player.isActive == true) {
            if (Input.GetKey (KeyCode.Space) && playerInRange) {

                Player.isActive = false;
                Dialogue.instance.dialogueRunner.StartDialogue (yarnStartNode);

            }
        //}
    }
}