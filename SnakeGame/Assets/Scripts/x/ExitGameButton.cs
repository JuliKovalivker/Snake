using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGameButton : MonoBehaviour
{
    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
