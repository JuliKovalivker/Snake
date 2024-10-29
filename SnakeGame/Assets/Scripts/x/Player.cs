using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject snakeHead;
    private List<GameObject> segments = new List<GameObject>();
    public GameObject segmentPrefab;

    public float gridSize = 0.5f; // Grid size for discrete movement
    private Vector2 direction = Vector2.right; // Initial movement direction
    private Vector2 inputDirection = Vector2.right;
    public float moveInterval = 0.2f;
    private float moveTimer;

    void Start()
    {
        segments.Add(snakeHead);
        moveTimer = moveInterval;
    }

    void Update()
    {
        // Capture input but only change direction if it's not a reverse
        if (Input.GetKeyDown(KeyCode.RightArrow) && direction != Vector2.left)
            inputDirection = Vector2.right;
        if (Input.GetKeyDown(KeyCode.LeftArrow) && direction != Vector2.right)
            inputDirection = Vector2.left;
        if (Input.GetKeyDown(KeyCode.UpArrow) && direction != Vector2.down)
            inputDirection = Vector2.up;
        if (Input.GetKeyDown(KeyCode.DownArrow) && direction != Vector2.up)
            inputDirection = Vector2.down;

        // Move the snake at regular intervals
        moveTimer -= Time.deltaTime;
        if (moveTimer <= 0)
        {
            moveTimer = moveInterval;
            MoveSnake();
        }
    }

    void MoveSnake()
    {
        // Update the direction for the next move
        direction = inputDirection;

        // Move the body segments to follow the head
        for (int i = segments.Count - 1; i > 0; i--)
        {
            segments[i].transform.position = segments[i - 1].transform.position;
        }

        // Move the head in the current direction
        Vector3 newPosition = snakeHead.transform.position + new Vector3(direction.x, direction.y, 0f) * gridSize;
        snakeHead.transform.position = newPosition;
    }

    void OnCollisionEnter(Collision col)
    {
        // Grow snake by adding a new segment at the last segment's position
        GameObject segment = Instantiate(segmentPrefab);
        segment.transform.position = segments[segments.Count - 1].transform.position;
        segments.Add(segment);
    }
}