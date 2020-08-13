using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class criancas_salvas : MonoBehaviour
{
    Text texto;
    public int ponto;
    // Start is called before the first frame update
    void Start()
    {
        ponto = Global.Instance.ponto;
        texto = gameObject.GetComponent<Text>();
        texto.text = ponto.ToString("0");
        print(ponto);
    }

    // Update is called once per frame
   
}
