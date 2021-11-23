using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;

    public static GameManager inst;

    public Text scoreText;

    public void IncScore()
    {
        score++;
        scoreText.text = "SCORE: " + score;
    }
    private void Awake()
    {
        inst = this;
    }
}
