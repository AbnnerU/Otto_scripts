using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Pontos : MonoBehaviour
{
    Text texto;
    public int ponto;
    // Start is called before the first frame update
    void Start()
    {
        texto = gameObject.GetComponent<Text>();
        ponto = 0;
    }

    // Update is called once per frame
    void Update()
    {
        texto.text = ponto.ToString("0");
        Salvar();
    }
    public void Salvar()
    {
        Global.Instance.ponto = ponto;
        

    }
}
