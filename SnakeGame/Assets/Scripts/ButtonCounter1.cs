using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonCounter1 : MonoBehaviour
{
    public TextMeshProUGUI textCounter;
    int counter;

    public void ButtonClick()
    {
        counter++;
        textCounter.text = counter.ToString();
    }
}
