using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveHombre : MonoBehaviour
{
    private Animator anim;
    public float tiempo_start; //Los segundos por los quales comienza i la variable que utilizaremos para que vaya contando segundos.
    public float tiempo_end;
    public float timeStop;
    public float timeTalk;
    public float timeTalkStop;
    public float timeTalk2;
    public float timeScene;
    public GameObject script;
    public AudioClip audioHombre;
    
    AudioSource fuenteAudio;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        fuenteAudio = GetComponent<AudioSource>();
        anim.SetInteger("estado", 0);
        fuenteAudio.clip = audioHombre;
        fuenteAudio.PlayDelayed(10.3f);

    }

    // Update is called once per frame
    void Update()
    {
        tiempo_start += Time.deltaTime;
        if (tiempo_start >= tiempo_end)
        {
            
            //animacion = this.gameObject.GetComponent<Animation>();
            //animacion.GetComponent<Animation>().enabled = true;

            anim.SetInteger("estado", 1);

            script.GetComponent<hoMove>().enabled = true;

        }
        if (tiempo_start >= timeStop)
        {

            
            gameObject.GetComponent<Animator>().enabled = false;
            

        }
        if (tiempo_start >= timeTalk)
        {
            gameObject.GetComponent<Animator>().enabled = true;
            anim.SetInteger("estado", 2);
        }
        if (tiempo_start >= timeTalkStop)
        {
            gameObject.GetComponent<Animator>().enabled = false;
            
        }
        if (tiempo_start >= timeTalk2)
        {
            gameObject.GetComponent<Animator>().enabled = true;

        }
        if (tiempo_start >= timeScene)
        {
            SceneManager.LoadScene("Demo_Scene");

        }

    }
}
