using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public playerMovement movement;
    

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.tag == "obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
