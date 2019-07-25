using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mujer2Escena2 : MonoBehaviour
{
    public GameObject script;
    private Animator anim;
    public float tiempo_start; //Los segundos por los quales comienza i la variable que utilizaremos para que vaya contando segundos.
    public float tiempo_end;
    public float timetalk;
    public float timeTalkEnd;
    public AudioClip audioMujer;
    AudioSource fuenteAudio;

    void Start()
    {
        anim = GetComponent<Animator>();
        fuenteAudio = GetComponent<AudioSource>();
        anim.SetInteger("estado", 0);
        fuenteAudio.clip = audioMujer;
        fuenteAudio.PlayDelayed(timetalk);
    }

    // Update is called once per frame
    void Update()
    {
        tiempo_start += Time.deltaTime;
        if (tiempo_start >= tiempo_end)
        {
            anim.SetInteger("estado", 1);
        }
        if (tiempo_start >= timeTalkEnd)
        {
            gameObject.GetComponent<Animator>().enabled = false;
        }
    }
}
