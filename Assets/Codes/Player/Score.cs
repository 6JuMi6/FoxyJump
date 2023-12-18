using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    private float score;
    private float GrowingScore;

    void Start()
    {
        score = 0f;
        GrowingScore = 1f;
    }

    void Update()
    {
        scoreText.text = "Seconds: " + (int)score;
        score += GrowingScore * Time.deltaTime;
    }
}
