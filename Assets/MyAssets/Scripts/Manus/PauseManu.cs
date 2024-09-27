using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManu : MonoBehaviour
{
    public GameObject pauseManu;
    public static bool isPaused;
    
    public AudioSource[] backgroundAudioSources;
    
    void Start()
    {
        pauseManu.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
                ResumeGame();
            else
                PauseGame();
        }
    }
    
    public void ResumeGame()
    {
        pauseManu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        
        ReactivateAudioSources();
    }
    
    public void PauseGame()
    {
        pauseManu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        
        DeactivateAudioSources();
    }
    
    public void GoToMainManu()
    {
        Time.timeScale = 1f;
        isPaused = false;
        ReactivateAudioSources();
        SceneManager.LoadScene("MainManu");
    }
    
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
    
    private void DeactivateAudioSources()
    {
        foreach (var audioSource in backgroundAudioSources)
            audioSource.enabled = false;
    }

    private void ReactivateAudioSources()
    {
        foreach (var audioSource in backgroundAudioSources)
            audioSource.enabled = true;
    }
}
