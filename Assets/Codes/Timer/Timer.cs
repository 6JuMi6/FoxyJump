using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [Header("Component")]
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI highscoreText;

    [Header("Timer Settings")]
    private float currentTime;
    private bool countDown;
    private float highscore;

    void Start()
    {
        highscore = PlayerPrefs.GetFloat("Highscore");
    }

    void Update()
    {
        currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;
        timerText.text = currentTime.ToString("Seconds: 0");
        highscoreText.text = highscore.ToString("Highscore: 0s");

        if (currentTime > highscore)
        {
            PlayerPrefs.SetFloat("Highscore", currentTime);
        }
    }
}
