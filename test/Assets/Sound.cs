using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip audioHombre;
    AudioSource fuenteAudio;
    public float tiempo_start; //Los segundos por los quales comienza i la variable que utilizaremos para que vaya contando segundos.
    public float timeStop;
    // Start is called before the first frame update
    void Start()
    {
        fuenteAudio = GetComponent<AudioSource>();
        fuenteAudio.clip = audioHombre;

    }

    // Update is called once per frame
    void Update()
    {
        if (tiempo_start >= timeStop)
        {

            fuenteAudio.PlayDelayed(10.3f);
            
            

        }
    }
}
