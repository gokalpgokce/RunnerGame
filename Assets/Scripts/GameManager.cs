using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int score;

    public static GameManager inst;

    public Text scoreText;

    public PlayerMovement playerMovement;

    public void IncScore()
    {
        score++;
        scoreText.text = "SCORE: " + score;

        playerMovement.speed += playerMovement.speedIncreasePerPoint;
    }
    private void Awake()
    {
        inst = this;
    }
}
