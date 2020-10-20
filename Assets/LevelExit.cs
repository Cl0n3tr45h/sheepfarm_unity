using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour {
    public Animator transition;
    public string nextScene;
    public float transitionTime = 1f;
    public string sourceTag;

    void OnTriggerEnter2D (Collider2D collider) {
           if(collider.CompareTag("Player")){
            LoadNextLevel ();
           }
    }

    public void LoadNextLevel () {
        StartCoroutine (LoadLevel ());
        Player.IsActive = true;
    }

    IEnumerator LoadLevel () {
        LevelEntry.activeTag = sourceTag;
        transition.SetTrigger ("Start");
        Player.IsActive = false;
        yield return new WaitForSeconds (transitionTime);
        SceneManager.LoadScene (nextScene);
    }

}