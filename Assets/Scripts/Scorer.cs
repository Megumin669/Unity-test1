using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    int hits = 0;
    
    void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag != "Hit") 
        {
            hits++;
            Debug.Log("You've collided with something this many times: " + hits);
        }
        

         
    }
}



