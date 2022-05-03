using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelTransition : MonoBehaviour
{
    public string sceneToLoad;
    public Vector2 playerPosition;
    public VectorValue playerStorage;
    public Animator transitionAnim;

    public VectorValue LVL0;
    public VectorValue LVL1;

    IEnumerator OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player") && !other.isTrigger) {
            playerStorage.initialValue = playerPosition;
            transitionAnim.SetTrigger("end");
            yield return new WaitForSeconds(1.5f);
            SceneManager.LoadScene(sceneToLoad);
        }
    }

    void OnApplicationQuit()
    {
        playerStorage.initialValue = new Vector2(0, 0);
        LVL0.initialValue = new Vector2(0, -5.45f);
        LVL1.initialValue = new Vector2(-4.5f, 2.4f);
    }
}
