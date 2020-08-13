using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto_para_otto : MonoBehaviour
{
    public float speed;
    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Lanterna").GetComponent<Light>().GetComponent<Light>().enabled == false)
        {
            speed = 0;

        }
        else
        {
            speed = 5000;
            
        }
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
