using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float DropTime = 3f;

    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;
    bool isTriggered = false;
    float triggerTime;
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myMeshRenderer.enabled = false;

        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.useGravity = false;
    }

    

    void Update()
    {
        if (isTriggered && Time.time > triggerTime + DropTime)
        {
            Debug.Log("Triggered action in Dropper script.");
            myRigidbody.useGravity = true;
            myMeshRenderer.enabled = true;
        }
    }
    public void TriggeredAction()
    {
        isTriggered = true;
        triggerTime = Time.time;
        
    }
    

}
