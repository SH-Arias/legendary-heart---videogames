using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc_uc : MonoBehaviour
{

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            anim.Play("WIN00", -1, 0f);
        }
        //anim.Play("WIN00", -1, 0f);
    }
}
