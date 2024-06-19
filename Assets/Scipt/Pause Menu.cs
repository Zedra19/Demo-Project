using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PausePanel;
    bool ispaused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(ispaused == false){
                ispaused = true;
                Time.timeScale = 0f;
                PausePanel.SetActive(true);
            }
            else if(ispaused == true){
                ispaused = false;
                Time.timeScale = 1f;
                PausePanel.SetActive(false);
            }
        }
    }

    public void ResumeButton()
    {
        ispaused = false;
        Time.timeScale = 1f;
        PausePanel.SetActive(false);
    }

    public void retry(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenuButton(){
        SceneManager.LoadScene(0);
    }
}
