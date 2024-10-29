using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apples : MonoBehaviour
{
    public GameObject apple;

    void OnCollisionEnter(Collision col){
        //Destroy(apple);
        int x_pos = Random.Range(-11, 11);
        int y_pos = Random.Range(-6, 7);
        apple.transform.position = new Vector3(x_pos, y_pos, 3.5f);
    }
}
