using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Apples : MonoBehaviour
{
    public GameObject apple;
    public GameObject snake2;
    int counter = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        //Destroy(apple);
        Instantiate(snake2);
        snake2.transform.position -= new Vector3(1f, 0f, 0f);
        counter++;
        int rand1 = Random.Range(-8, 8); 
        int rand2 = Random.Range(-3, 5); 
        //Instantiate(apple);
        apple.transform.position = new Vector3(rand1, rand2, -4f);

    }
}
