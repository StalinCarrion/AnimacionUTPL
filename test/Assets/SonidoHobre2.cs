using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoHobre2 : MonoBehaviour
{
    public float timeSound;
    public AudioClip audioHombre2;
    AudioSource fuenteAudio;

    // Start is called before the first frame update
    void Start()
    {
        fuenteAudio = GetComponent<AudioSource>();
        fuenteAudio.clip = audioHombre2;
        fuenteAudio.PlayDelayed(timeSound);
    }

}
