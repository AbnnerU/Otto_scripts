using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacao_lanterna : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 pos;

    GameObject objeto;
    void Start()
    {
        objeto = GameObject.Find("Rotacionador");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) )
        
            {
            objeto.transform.rotation = Quaternion.Euler(0,0,-90);

            }
            else if (Input.GetKeyDown(KeyCode.A) )
            {
            objeto.transform.rotation = Quaternion.Euler(0, 0, -270);
        }
            else if (Input.GetKeyDown(KeyCode.W))
            {
            objeto.transform.rotation = Quaternion.Euler(0, 0,-360);
        }
            else if (Input.GetKeyDown(KeyCode.S) )
            {
            objeto.transform.rotation = Quaternion.Euler(0, 0, -180);
        }
    }
}
