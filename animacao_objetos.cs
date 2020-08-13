using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacao_objetos : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    public string nome;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        anim.Play(nome);
    }
}
