using UnityEngine;

public class HitEvent : MonoBehaviour
{
    void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";
        }
        else

        GetComponent<MeshRenderer>().material.color = Color.black;
       


    }
}