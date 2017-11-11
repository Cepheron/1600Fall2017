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
        startPosition = player.position;
        fillAmount = uiBar.fillAmount;
        GameOverUI.SetActive(false);
    }

    public void Click ()
    {
        PlayerController.gameOver = false;
        player.position = startPosition;
        uiBar.fillAmount = fillAmount;
        GameOverUI.SetActive(false);
        SceneManager.LoadScene (SceneManager.GetActiveScene().name);
    }	
}
