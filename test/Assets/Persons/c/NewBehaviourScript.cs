using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Animator anim;
    public float tiempo_start; //Los segundos por los quales comienza i la variable que utilizaremos para que vaya contando segundos.
    public float tiempo_end;

    public AnimationEvent animacion;
    // Update is called once per frame
    private void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetInteger("Estado", 0);
    }
    void Update()
    {

        tiempo_start += Time.deltaTime;
        if (tiempo_start >= tiempo_end)
        {
            //gameObject.GetComponent<Animator>().enabled = false;
            //animacion = this.gameObject.GetComponent<Animation>();
            //animacion.GetComponent<Animation>().enabled = true;
            anim.SetInteger("Estado", 1);
            
        }

    }
}
