using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float timer = 60f;
    public Text textTimer;
    public GameObject GameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        textTimer.text = "Timer :" + timer;
        if (timer <= 0f){
            GameOverPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
