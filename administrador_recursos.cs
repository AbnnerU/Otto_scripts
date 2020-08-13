using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class administrador_recursos : MonoBehaviour
{
    GameObject cartaoVerde;
    GameObject cartaoAzul;
    Image cvImage;
    Image caImage;

    public bool cartaoV=false, cartoaA=false;
    // Start is called before the first frame update
    void Start()
    {
        cartaoVerde = GameObject.Find("cartao_verde");
        cartaoAzul = GameObject.Find("cartao_azul");
        cvImage = GameObject.Find("Catao_verdeI").GetComponent<Image>();
        caImage = GameObject.Find("Cartao_azulI").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cartaoVerde == null)
        {
            cvImage.enabled = true;
            cartaoV = true;
        }
        if (cartaoAzul == null)
        {
            caImage.enabled = true;
            cartoaA = true;
        }
    }
}
