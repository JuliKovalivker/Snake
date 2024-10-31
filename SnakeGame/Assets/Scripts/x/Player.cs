using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public GameObject snakeHead;
    private List<GameObject> segments = new List<GameObject>();
    public GameObject segmentPrefab;

    private float gridSize = 0.5f;
    private Vector3 inputDirection = Vector3.right;
    private Vector3 direction = Vector3.right;
    private float moveInterval = 0.2f;
    private float moveTimer;

    void Start()
    {
        segments.Add(snakeHead);
        moveTimer = moveInterval;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && direction != Vector3.left)
            inputDirection = Vector3.right;
        if (Input.GetKeyDown(KeyCode.LeftArrow) && direction != Vector3.right)
            inputDirection = Vector3.left;
        if (Input.GetKeyDown(KeyCode.UpArrow) && direction != Vector3.down)
            inputDirection = Vector3.up;
        if (Input.GetKeyDown(KeyCode.DownArrow) && direction != Vector3.up)
            inputDirection = Vector3.down;

        moveTimer -= Time.deltaTime;
        if (moveTimer <= 0)
        {
            moveTimer = moveInterval;
            MoveSnake();
        }
    }

    void MoveSnake()
    {
        direction = inputDirection;

        Vector3 headPosition = snakeHead.transform.position + new Vector3(direction.x, direction.y, 0f) * gridSize;

        for (int i = 1; i < segments.Count; i++)
        {
            if (Vector3.Distance(headPosition, segments[i].transform.position) < 0.1f)
            {
                SceneManager.LoadScene("GameOverScene");
                //return;
            }
        }

        for (int i = segments.Count - 1; i > 0; i--)
        {
            segments[i].transform.position = segments[i - 1].transform.position;
        }

        snakeHead.transform.position = headPosition;
    }

    void OnCollisionEnter(Collision col)
    {
        GameObject segment = Instantiate(segmentPrefab);
        segment.transform.position = segments[segments.Count - 1].transform.position;
        segments.Add(segment);
    }
}