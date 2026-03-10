using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Mover : MonoBehaviour
{

    [SerializeField] float MoveSpeed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
       MovePlayers();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome To The Game");
        Debug.Log("Move Your Player with arrow keys or WASD.");
    }

    void MovePlayers()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * MoveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * MoveSpeed;
        transform.Translate(xValue,0,zValue);
    }
}
