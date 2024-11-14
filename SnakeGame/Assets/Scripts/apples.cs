using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apples : MonoBehaviour
{
    public GameObject apple;

    void OnCollisionEnter(Collision col){
        //Destroy(apple);
        int x_pos = Random.Range(8, 8);
        int y_pos = Random.Range(-3, 5);
        apple.transform.position = new Vector3(x_pos, y_pos, -4f);
    }
}
