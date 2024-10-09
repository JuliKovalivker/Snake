using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Apples : MonoBehaviour
{
    public GameObject apple;

    void OnCollisionEnter(Collision col)
    {
        int rand1 = Random.Range(-8, 8); 
        int rand2 = Random.Range(-3, 5); 
        apple.transform.position = new Vector3(rand1, rand2, -4f);
    }
}
