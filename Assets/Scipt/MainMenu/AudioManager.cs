using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public AudioSource MainMenuSource;
    public AudioSource GameplaySource;

    // Start is called before the first frame update
    void Start()
    {
        if(SceneManager.GetActiveScene().buildIndex == 0)
        {
            GameplaySource.Stop();
            MainMenuSource.Play();
        }else if(SceneManager.GetActiveScene().buildIndex == 1){
            MainMenuSource.Stop();
            GameplaySource.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
