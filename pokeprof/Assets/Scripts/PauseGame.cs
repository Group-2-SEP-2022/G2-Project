using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    //set the time to zero to pause the game
    public void Pause()
    {
        Time.timeScale = 0;
    }

    //set the time to one to resume the game
    public void Resume()
    {
        Time.timeScale = 1;
    }
}
