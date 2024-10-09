using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject snakeHead;
    private List<GameObject> segments;
    public GameObject segmentPrefab;

    bool right;
    bool up;
    bool pressedRight;
    bool pressedUp;

    // Start is called before the first frame update
    void Start()
    {
        segments = new List<GameObject>();
        segments.Add(snakeHead);
    }

    // Update is called once per frame
    void Update()
    {
        right = false;
        up = false;
        pressedRight = false;
        pressedUp = false;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            snakeHead.transform.position += new Vector3(0.01f, 0f, 0f);
            right = true;
            pressedRight = true;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            snakeHead.transform.position -= new Vector3(0.01f, 0f, 0f);
            right = false;
            pressedRight = true;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            snakeHead.transform.position+= new Vector3(0f, 0.01f, 0f);
            up = true;
            pressedUp = true;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            snakeHead.transform.position -= new Vector3(0f, 0.01f, 0f);
            up = false;
            pressedUp = true;
        }

        float x = 0.0f;
        float y = 0.0f;
        if (right && pressedRight)
        {
            x = -0.5f;
        }
        else if (right == false && pressedRight)
        {
            x = 0.5f;
        }
        if (up && pressedUp)
        {
            y = -0.5f;
        }
        else if (up == false && pressedUp)
        {
            y = 0.5f;
        }

        if (pressedUp || pressedRight)
        {
            for (int i = 1; i < segments.Count; i++)
            { 
                segments[i].transform.position = segments[i - 1].transform.position + new Vector3(x, y, 0f);
            }
        }

    }

    void OnCollisionEnter(Collision col)
    {
        GameObject segment = Instantiate(this.segmentPrefab);
        segment.transform.position = segments[segments.Count - 1].transform.position;
        segments.Add(segment);
    }
}
