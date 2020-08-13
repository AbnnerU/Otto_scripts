using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Jumpscare : MonoBehaviour
{
    // Start is called before the first frame update
    public float delay;
    float time;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= delay)
        {
            carregarNivel();
        }
    }
    void carregarNivel()
    {
        SceneManager.LoadScene("MENU");
    }
}
