using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakePlayer : MonoBehaviour
{
    public GameObject snake;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            snake.transform.position += new Vector3(0.01f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            snake.transform.position -= new Vector3(0.01f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            snake.transform.position += new Vector3(0f, 0.01f, 0f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            snake.transform.position -= new Vector3(0f, 0.01f, 0f);
        }
    }

}
