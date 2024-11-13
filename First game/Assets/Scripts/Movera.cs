using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movera : MonoBehaviour
{
    [SerializeField] float moveSpeed = 200f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
       MovePlayer();
    }

    // Methods
    void PrintInstructions()
    {
        Debug.Log("Welcome to my game cuh.");
        Debug.Log("Use WASD or arrow keys to move.");
        Debug.Log("Don't touch the walls unless you're gay, bitch.");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,0,zValue);
    }
}
