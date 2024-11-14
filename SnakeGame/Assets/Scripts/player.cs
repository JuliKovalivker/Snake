using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject snake;
    public GameObject segment;
    //float x;
    //float y;

    private List<GameObject> snake_segments = new List<GameObject>();

    private Vector3 input_direction = Vector3.right; //new Vector3(1f, 0f, 0f);
    private Vector3 direction = Vector3.right;

    // Start is called before the first frame update
    void Start()
    {
        snake_segments.Add(snake);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) && direction != Vector3.left)
        {
            input_direction = Vector3.right;
        }
        if (Input.GetKey(KeyCode.LeftArrow) && direction != Vector3.right)
        {
            input_direction = Vector3.left;
        }
        if (Input.GetKey(KeyCode.UpArrow) && direction != Vector3.down)
        {
            input_direction = Vector3.up;
        }
        if (Input.GetKey(KeyCode.DownArrow) && direction != Vector3.up)
        {
            input_direction = Vector3.down;
        }
        //snake.transform.position += new Vector3(x, y, 0f);
    }

    void OnCollisionEnter(Collision col)
    {
        GameObject new_segment = Instantiate(segment);
        ////////////
        new_segment.transform.position = snake.transform.position;
        snake_segments.Add(new_segment);
    }
}
