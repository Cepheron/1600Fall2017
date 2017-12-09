using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReplayGame : MonoBehaviour
{
    public Transform player;
    public Image uiBar;
    public GameObject GameOverUI;
    public static Vector3 startPosition;
    private float fillAmount;

    void Start()
    {
        // starts the function that makes game over false until health bar is empty
        startPosition = player.position;
        fillAmount = uiBar.fillAmount;
        GameOverUI.SetActive(false);
    }

    public void Click ()
    {
        // function that makes the replay button able to be clicked and restarts the scene upon the game over being active
        PlayerController.gameOver = false;
        player.position = startPosition;
        uiBar.fillAmount = fillAmount;
        GameOverUI.SetActive(false);
        SceneManager.LoadScene (SceneManager.GetActiveScene().name);
    }	
}
