using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePause : MonoBehaviour
{
    public void Pause()
    {
        StartCoroutine(PauseGame());
    }
    
    public void Resume()
    {
        Time.timeScale = 1;
    }

    IEnumerator PauseGame(){
        yield return new WaitForSeconds(1.5f);
        Time.timeScale = 0;
    }
}
