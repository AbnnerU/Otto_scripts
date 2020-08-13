using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animacao_planta : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        anim.Play("Planta_escondendo");
    }
}
