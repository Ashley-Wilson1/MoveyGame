
using UnityEngine;

public class playerCollision : MonoBehaviour
{
     public PlayerMovement movement;
   

     void OnCollisionEnter(Collision collision)
     {

        if(collision.collider.tag == "Obstacle")
        {
           movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        } 
        
     }

}
