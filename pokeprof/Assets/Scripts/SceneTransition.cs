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
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame() {
        Application.Quit();
    }
}

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.SceneManagement;
// using UnityEngine.EventSystems;
// using UnityEngine.UI;

// public class SceneTransition : MonoBehaviour
// {

//     public Animator transitionAnim;

//     public bool pressed = false;

//     public void isPressed() {
//         pressed = true;
//     }

//     void Update()
//     {   
//         if(pressed) {
//         StartCoroutine(LoadScene());
//         }
//     }

//     IEnumerator LoadScene(){
//         transitionAnim.SetTrigger("end");
//         yield return new WaitForSeconds(1.5f);
//         SceneManager.LoadScene("Game");
//     }

//     public void QuitGame() {
//         Application.Quit();
//     }
// }

