using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
   void OnCollisionEnter(Collision collisionInfo)
   {
       // Debug.Log("bişeye vurduk");
       //Debug.Log(collisionInfo.collider.name);

    //    if(collisionInfo.collider.name == "Obstacle")
    //    {
    //        Debug.Log("engele çarptık");
    //    }

        if(collisionInfo.collider.tag == "ObstacleTag")
       {
           Debug.Log("engele çarptık");
           movement.enabled = false;

           FindObjectOfType<GameManager>().EndGame();

       }
   }
}
