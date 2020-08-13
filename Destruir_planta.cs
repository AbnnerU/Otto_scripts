using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir_planta : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.name == "Slime")
        {
            print("Deu certo desgraça");
            Destroy(collision.gameObject);
        }
    }
}

