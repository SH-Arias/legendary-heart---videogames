using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firefly : MonoBehaviour
{
    public bool listening = false;
    public ParticleSystem ff;

    // Start is called before the first frame update
    void Start()
    {
        ff = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("l"))
        {
            if (listening)
            {
                    ff.Play();
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
           this.listening = true;
        }
        //this.listening = true;
    }
    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player"){
           this.listening = false;
        }
        //this.listening = false;
    }

    void OnGUI ()
	{
        if(listening){
            GUI.skin.box.fontSize = 20;
            GUI.Box (new Rect (Screen.width - 500, 300, 400, 40), "Presiona 'L' para invocar Luciérnagas");
        }
	}
}
