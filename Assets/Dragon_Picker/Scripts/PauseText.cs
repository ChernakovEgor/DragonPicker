using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseText : MonoBehaviour
{
    private bool isPaused = false;
    [SerializeField]
    private GameObject pauseCanvas; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (isPaused == false) {
                isPaused = true;
                pauseCanvas.SetActive(true);
                Time.timeScale = 0.0f;
            } else {
                isPaused = false;
                pauseCanvas.SetActive(false);
                Time.timeScale = 1.0f;
            }
        }
    }
}
