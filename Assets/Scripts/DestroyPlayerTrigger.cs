using UnityEngine;

public class DestroyPlayerTrigger : MonoBehaviour
{
void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
    }
}


