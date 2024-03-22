using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    int score = 0;
    Animator myani;
    Rigidbody myrb;

    // Start is called before the first frame update
    void Start()
    {
        myani = GetComponent<Animator>();
        myrb = GetComponent<Rigidbody>();
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
        else if (Input.GetKeyDown(KeyCode.Space) && myrb.velocity.y == 0)
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
        myrb.velocity = new Vector3(0, 5f, 0);
    }

    void Roll()
    {
        myani.SetTrigger("roll");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "coin")
        {
            score += 1;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
        }
    }
}
