using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento_personagem2 : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 3.0f;
    private Vector3 pos ;
    private Transform tr;
 
void Start()
    {
        pos = transform.position;
        tr = transform;
    }

    void Update()
    {
       
        if (Input.GetKey(KeyCode.D) && tr.position == pos)
        { 
                pos += Vector3.right;
         
        }
        else if (Input.GetKey(KeyCode.A) && tr.position == pos)
        {
            pos += Vector3.left;
        }
        else if (Input.GetKey(KeyCode.W) && tr.position == pos)
        {
            pos += Vector3.up;
        }
        else if (Input.GetKey(KeyCode.S) && tr.position == pos)
        {
            pos += Vector3.down;
        }

        transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);

        
    }
}

