using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {
    public Animator transition;
    public string nextScene;
    public float transitionTime = 1f;

    void OnTriggerEnter2D (Collider2D collider) {
            Debug.Log("Entered");
            LoadNextLevel ();
    }

    public void LoadNextLevel () {
        StartCoroutine (LoadLevel ());
    }

    IEnumerator LoadLevel () {
        transition.SetTrigger ("start");
        yield return new WaitForSeconds (transitionTime);
        SceneManager.LoadScene (nextScene);
    }

}