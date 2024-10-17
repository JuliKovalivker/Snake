using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject snake;
    float x;
    float y;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            x = 0.01f;
            y = 0f;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            x = -0.01f;
            y = 0f;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            x = 0f;
            y = 0.01f;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            x = 0f;
            y = -0.01f;
        }
        snake.transform.position += new Vector3(x, y, 0f);
    }
}
