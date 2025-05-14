using UnityEditor;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float yRotation = 0f;
    [SerializeField] float xRotation = 0f;
    [SerializeField] float zRotation = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(xRotation, yRotation, zRotation * Time.deltaTime);
    }
}
