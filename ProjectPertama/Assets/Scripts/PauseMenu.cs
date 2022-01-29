using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PauseMenu : MonoBehaviour
{
    public static bool Paused;
    public GameObject pauseUI;

    private void Start()
    {
        pauseUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                if (EventSystem.current.IsPointerOverGameObject(i))
                {
                    if (Paused)
                    {
                        Resume();
                    }
                    else
                    {
                        pause();
                    }
                }
            }
        }


    }

    void Resume()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
    }

    void pause()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        Paused = true;
    }
}
