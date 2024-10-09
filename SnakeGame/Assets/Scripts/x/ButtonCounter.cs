using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonCounter : MonoBehaviour
{

    public TextMeshProUGUI textCounter;
    int counter;

    public void ButtonOnClick()
    {
        counter++;
        textCounter.text = counter.ToString();
    }
}
