﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SelectNextLevel : MonoBehaviour {
    private readonly string scoreS = "Score:";
    public  Text ScoreText;
    public int score;

    void Start()
    {
        score = PlayerPrefs.GetInt(scoreS);
        ScoreText.text = "Score: " + score;
    }
    
    public void LoadScene()
    {
        SceneManager.LoadScene(0);
    }
    
}
