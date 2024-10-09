using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnakesBodyCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        SceneManager.LoadScene("GameOverScene");
    }
}
