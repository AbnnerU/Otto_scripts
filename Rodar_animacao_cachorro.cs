using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rodar_animacao_cachorro : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.Play("Cachorro_correndo_direita");
    }
}
