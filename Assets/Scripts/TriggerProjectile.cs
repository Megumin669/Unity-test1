using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject projectile0;
    [SerializeField] GameObject projectile1;
    [SerializeField] GameObject projectile2;
    [SerializeField] GameObject projectile3;


  
    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Player")
        {
            projectile0.SetActive(true); 
            projectile1.SetActive(true);
            projectile2.SetActive(true);
            projectile3.SetActive(true);
            Destroy(gameObject);

        }

    }



}
