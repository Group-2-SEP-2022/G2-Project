using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SceneTransition : MonoBehaviour
{

    public Animator transitionAnim;

    public bool pressed = false;

    public string sceneName;

    public SceneName sceneStorage;

    public void isPressed() {
        pressed = true;
    }

    void Update()
    {   
        if(pressed) {
        StartCoroutine(LoadScene(sceneName));
        }
    }

    IEnumerator LoadScene(string sceneName){
        sceneStorage.initialValue = SceneManager.GetActiveScene().name;
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);
    }

    void QuitGame() {
        Application.Quit();
    }
}

