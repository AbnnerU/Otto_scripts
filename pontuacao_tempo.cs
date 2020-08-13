using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pontuacao_tempo : MonoBehaviour
{
    Text texto;
    tempo_final tempo;
    int n1, n2, total;
    // Start is called before the first frame update
    void Start()
    {
        texto = gameObject.GetComponent<Text>();
        tempo = GameObject.Find("tempo ").GetComponent<tempo_final>();
        n1 = tempo.minutes * 50;
        n2 = (tempo.seconds / 30) * 50;
        total = 15000 - (n1 + n2);
        texto.text = total.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
