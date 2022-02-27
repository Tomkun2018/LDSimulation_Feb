using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int minutes, seconds;

    Text text;

    void Start()
    {
        text = GetComponent<Text>();

        seconds += minutes * 60;
    }

    void Update()
    {
        int time = seconds - ((int)Time.timeSinceLevelLoad);
        if (time <= 0)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        int sec = time % 60;
        int min = time / 60 % 60;

        text.text = min.ToString().PadLeft(2, '0') + ":" + sec.ToString().PadLeft(2, '0');
    }
}
