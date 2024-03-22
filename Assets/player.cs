using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator myani;

    // Start is called before the first frame update
    void Start()
    {
        myani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveRight();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveLeft();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            MoveBackward();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MoveForward();
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Roll();
        }
    }

    void MoveRight()
    {
        if (transform.position.x < 2)
        {
            transform.position += Vector3.right * 2;
        }
    }

    void MoveLeft()
    {
        if (transform.position.x > -2)
        {
            transform.position += Vector3.left * 2;
        }
    }

    void MoveForward()
    {
        transform.position += Vector3.forward * 2;
    }

    void MoveBackward()
    {
        transform.position += Vector3.back * 2;
    }

    void Jump()
    {
        myani.SetTrigger("jump");
    }

    void Roll()
    {
        myani.SetTrigger("roll");
    }
}
