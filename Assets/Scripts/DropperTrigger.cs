using UnityEngine;
using UnityEngine.UIElements;

public class DropperTrigger : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {   
        if (other.gameObject.tag == "Player")
        {
            Dropper dropper = GetComponent<Dropper>();
            if (dropper != null)
            {
                dropper.TriggeredAction();
            }
            else
            {
                Debug.LogWarning("Dropper component not found on the game object.");
            }
        }
    }
}
