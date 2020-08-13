using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Tempo : MonoBehaviour
{
    Text tempo;
    float time;
    static bool parou;
    public bool stop;
    public int minutes;
    public int seconds;
    public int milliseconds;
    // Start is called before the first frame update
    void Start()
    {
        tempo = gameObject.GetComponent<Text>();
        parou = stop;
        minutes = 0;
        milliseconds = 0;
        seconds = 0;
    }

    // Update is called once per frame
    void Update()
    {
        parou = stop;
        if (parou == false)
        {
            time += Time.deltaTime;

              minutes = Mathf.FloorToInt(time / 60F);
             seconds = Mathf.FloorToInt(time % 60F);
             milliseconds = Mathf.FloorToInt((time * 100F) % 100F);
            tempo.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
        }
        Salvar();
    }
    public void Salvar()
    {
        Global.Instance.minutes = minutes;
        Global.Instance.seconds = seconds;
        Global.Instance.milliseconds = milliseconds;

    }
}
