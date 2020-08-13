using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Criança : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject[] pontosDeSpawn = new GameObject[16];
    GameObject novoObjeto;
    int a = 0;
    int Rand;
    int tamanho;
    List<int> list = new List<int>();
    public GameObject prefabDaCrianca;

    void Start()
    {
        for (int i = 0; i < 15; i++)
        {

            pontosDeSpawn[i] = GameObject.Find("SpawCrianca (" + i + ")");

        }


        tamanho = pontosDeSpawn.Length;

        list = new List<int>(new int[tamanho]);

        for (int j = 0; j < tamanho; j++)
        {
            Rand = Random.Range(0, tamanho - a);

            while (list.Contains(Rand))
            {
                Rand = Random.Range(0, tamanho - a);
            }
            list[j] = Rand;
            print(list[j]);
            list[j] = Rand;
            print(list[j]);
            a++;


        }
        for(int i=0;i <tamanho; i++)
        {
             novoObjeto = Instantiate<GameObject>(prefabDaCrianca);
            novoObjeto.transform.position = pontosDeSpawn[list[i]].transform.position;

        }
    }
    
}

  

