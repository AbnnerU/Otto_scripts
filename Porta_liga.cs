using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta_liga : MonoBehaviour
{
    Animator anim;
    BoxCollider2D colider;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        colider = gameObject.GetComponent<BoxCollider2D>();
        anim.Play("Porta_fechada");
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Gerador_liga").GetComponent<BoxCollider2D>().enabled == false)
        {
            anim.Play("Porta_abrindo");
            colider.enabled = false;
        }
    }
}
