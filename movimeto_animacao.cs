using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento_animacao : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 objeto;
    Vector2 player;
    float angulo;
    Animator anim;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        objeto = transform.position;
        player = GameObject.Find("CharacterBody").transform.position;
        angulo = anguloObjetos(objeto, player);

        if (angulo >= 45 && angulo < 135)
        {
            anim.Play("MOrcego_virando_costas");
        }
        else if (angulo >= 135 || angulo < -135)
        {
            anim.Play("Morcego_virando_esquerda");
        }
        else if (angulo >= -135 && angulo < -45)
        {
            anim.Play("Morcego_virando_frente");
        }
        else if (angulo >= -45 && angulo < 45)
        {
            anim.Play("New Animation virando");
        }
    }
    float anguloObjetos(Vector2 vec1, Vector2 vec2)
    {
        Vector2 diference = vec2 - vec1;
        float sign = (vec2.y < vec1.y) ? -1.0f : 1.0f;
        return Vector2.Angle(Vector2.right, diference) * sign;

    }
}
