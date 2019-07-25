using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMujer : MonoBehaviour
{
    private Animator anim;
    public float tiempo_start; //Los segundos por los quales comienza i la variable que utilizaremos para que vaya contando segundos.
    public float tiempo_end;
    //public float timeStop;
    public float timeTalk;
    public float timeStopAnimator;
    //public float timeTalkStop;
    public GameObject script;
    public AudioClip audioMujer;
    AudioSource fuenteAudio;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        fuenteAudio = GetComponent<AudioSource>();
        anim.SetInteger("estado", 0);
        fuenteAudio.clip = audioMujer;
        fuenteAudio.PlayDelayed(54);
    }
    void Update()
    {
        tiempo_start += Time.deltaTime;
        if (tiempo_start >= tiempo_end)
        {
            script.GetComponent<hoMove>().enabled = true;
        }
        if (tiempo_start >= timeTalk)
        {
            anim.SetInteger("estado", 1);
        }
        if (tiempo_start >= timeStopAnimator)
        {
            gameObject.GetComponent<Animator>().enabled = false;
        }
        //if (tiempo_start >= timeStop)
        //{
        //    gameObject.GetComponent<Animator>().enabled = false;

        //}

    }
}
