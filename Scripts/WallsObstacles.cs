using UnityEngine;

public class WallsObstacles : MonoBehaviour
{
   void OnCollisionEnter(Collision other) 
   {
       if (other.gameObject.tag == "Player")
        {
          GetComponent<MeshRenderer>().material.color = Color.red;
          gameObject.tag = "Hit";         
        }
   }
}
