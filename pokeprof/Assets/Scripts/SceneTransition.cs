using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SceneTransition : MonoBehaviour
{
    public Animator transitionAnim;

    private bool pressed = false;

    public string sceneName;

    public void isPressed()
    {
        pressed = true;
    }
    
    //check every frame if the tap to play screen is pressed
    void Update()
    {
        if (pressed)
        {
            StartCoroutine(LoadScene(sceneName));
        }
    }

    //trigger the animation, wait for 1.5s for the animation to finish then change the scene
    IEnumerator LoadScene(string sceneName)
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);
    }

    //when quit button is pressed in main menu then quit the app
    public void QuitGame()
    {
        Application.Quit();
    }
}
