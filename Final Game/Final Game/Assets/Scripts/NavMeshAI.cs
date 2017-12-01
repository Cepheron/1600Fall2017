using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshAI : MonoBehaviour
{
    public Transform player;
    public NavMeshAgent agent;
    public GameObject gameOverUI;   

    void Update()
    {
        agent.destination = player.position; 
        
        if(PlayerController.gameOver)
        {
            agent.destination = transform.position;
        }
    }    
}