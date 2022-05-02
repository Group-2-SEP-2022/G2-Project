using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Back : MonoBehaviour
{

    public Animator transitionAnim;

    public bool pressed = false;

    public SceneName sceneStorage;

    public void isPressed() {
        pressed = true;
    }

    void Update()
    {   
        if(pressed) {
        StartCoroutine(LoadScene(sceneStorage.initialValue));
        }
    }

    IEnumerator LoadScene(string sceneName){
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);
    }
}

