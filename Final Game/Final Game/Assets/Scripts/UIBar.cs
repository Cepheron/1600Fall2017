using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBar : MonoBehaviour
{
    public Image bar;
    public GameObject gameOverUI;
    public float powerLevel = 0.1f;
    public float amountToAdd = 0.01f;
    public GameObject playerExplosion;

    public enum PowerUpType
    {
        // calls the functions
        PowerUp,
        PowerDown
    }

    public PowerUpType powerUp;

    void OnTriggerEnter(Collider other)
    {
        // makes the functions activate once triggered
        switch (powerUp)
        {
            case PowerUpType.PowerUp:
                StartCoroutine(PowerUpBar());
                break;

            case PowerUpType.PowerDown:
                StartCoroutine(PowerDownBar());
                break;            
        }
                if (bar.fillAmount == 0)        
                {
                    // makes an explosion happen upon the health bar reaching 0
                    Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
                    PlayerController.gameOver = true;                   
                }     
    }
    
    IEnumerator PowerUpBar()
    {        
        // adds a power up drop down unity
        float tempAmount = bar.fillAmount + powerLevel;
        if (tempAmount > 1)
        {
            tempAmount = 1;
        }
        // when player object passes over a power up object, if health is not full, adds an amount to it
        while (bar.fillAmount < tempAmount)
        {
            bar.fillAmount += amountToAdd;
            yield return new WaitForSeconds(amountToAdd);
        }
    }
    IEnumerator PowerDownBar()
    {
        // adds a power down drop down unity
        float tempAmount = bar.fillAmount - powerLevel;
        if (tempAmount < 0)
        {
            tempAmount = 0;
        }
        // when player object passes over a power down object, if there is health left, decreases an amount from it
        while (bar.fillAmount > tempAmount)
        {
            bar.fillAmount -= amountToAdd;
            yield return new WaitForSeconds(amountToAdd);

        }
        // when the health bar reaches 0, triggers the game over screen
        if (bar.fillAmount == 0)        {
            
            gameOverUI.SetActive(true);
            PlayerController.gameOver = true;
        }
    }
}