using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreBoardManager : MonoBehaviour
{
    [SerializeField] TextMeshPro scoreText;

    [SerializeField] private GameObject cracks;

    [SerializeField] private Animator cracksAnim;
    
    [SerializeField] private int score;
    [SerializeField] private int lives = 3;
    [SerializeField] private int waves = 1;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score + "\n\nLives: " + lives + "/3\n\nWave: " + waves;
    }

    public void IncreaseScore100()
    {
        score += 100;
    }
    
    public void IncreaseScore250()
    {
        score += 250;
    }
    
    public void IncreaseScore2500()
    {
        score += 2500;
    }

    public void DecreaseLives()
    {
        lives--;
        
        cracks.SetActive(true);
        cracksAnim.SetTrigger("Hit");
    }
    
    public void IncreaseLives()
    {
        lives++;
    }

    public void IncreaseWave()
    {
        waves++;
    }
}
