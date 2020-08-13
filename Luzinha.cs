using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luzinha : MonoBehaviour
{
    Light luz;
    public bool piscando;
    float time;
    public float delay;
    int numeroDePisca = 0;
    public float minIntensity;
    public float maxIntensity;
    // Start is called before the first frame update
    void Start()
    {
        luz = gameObject.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (piscando)
        {
            luz.color = Color.green;
            time += Time.deltaTime;
            if (time >= delay)
            {
                time = 0;
                numeroDePisca++;
                ToggleLight();
            }
            if (numeroDePisca == 4)
            {
                piscando = false;
            }
        }
    }
    void ToggleLight()
    {

        if (luz.intensity == minIntensity)
        {
            luz.intensity = maxIntensity;
        }

        else if (luz.intensity == maxIntensity)
        {
            luz.intensity = minIntensity;
        }
    }
}
