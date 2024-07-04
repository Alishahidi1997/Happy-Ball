using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    private GameObject jelly;
    private float temp; 
    private float timeT = 0f; 
    private Animator anim; 

    private bool firstTime = true; 
    // Start is called before the first frame update
    void Start()
    {
        jelly = transform.parent.gameObject; 
        temp = jelly.transform.position.x;
        anim = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if( math.abs( temp - jelly.transform.position.x) > 0.1 && firstTime){
            Debug.Log("expppppod");
            firstTime = false; 
            anim.SetTrigger("exploded"); 
            jelly.GetComponent<SpriteRenderer>().enabled = false; 
        }
    }
}
