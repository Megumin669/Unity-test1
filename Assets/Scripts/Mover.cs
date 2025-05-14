using UnityEngine;

public class Mover : MonoBehaviour
{


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] float moveSpeed = 10.00f;
    void Start()
    {
        PrintIntsructions();
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();

    }

    void PrintIntsructions ()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls"); 
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0.00f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }
}
