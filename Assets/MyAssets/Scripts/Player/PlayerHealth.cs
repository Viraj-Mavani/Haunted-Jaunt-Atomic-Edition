using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public PlayerHealthBar playerHealthBar;
    public GameEnding gameEnding;
    public int maxHealth = 100;
    public int currentHealth;
    public AudioSource pulseAudio;
    private bool isPulsePlaying = false;
    
    void Start()
    {
        currentHealth = maxHealth;
        playerHealthBar.SetMaxHealth(maxHealth);
    }
    public void Damage()
    {
        currentHealth--;
        playerHealthBar.SetHealth(currentHealth);
        if (currentHealth < 30 && !isPulsePlaying)
            PlayPulseSound();
        else if(currentHealth < 0)
            gameEnding.CaughtPlayer();
    }
    
    public void IncreaseHealth(int amount)
    {
        currentHealth += amount;
        if (currentHealth > maxHealth)
            currentHealth = maxHealth;
        playerHealthBar.SetHealth(currentHealth);
        
        if (currentHealth >= 20 && isPulsePlaying)
            StopPulseSound();
    }
    
    private void PlayPulseSound()
    {
        pulseAudio.Play();
        isPulsePlaying = true;
    }
    
    private void StopPulseSound()
    {
        pulseAudio.Stop();
        isPulsePlaying = false;
    }
}
