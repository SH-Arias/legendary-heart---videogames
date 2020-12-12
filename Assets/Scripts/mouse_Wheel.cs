using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_Wheel : MonoBehaviour
{
    public float ZoomAmount = 0.0f; //With Positive and negative values
    public float MaxToClamp = 10.0f;
    public float ROTSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }
 
    // Update is called once per frame
    private void Update() {
     ZoomAmount += Input.GetAxis("Mouse ScrollWheel");
     ZoomAmount = Mathf.Clamp(ZoomAmount, -MaxToClamp, MaxToClamp);
     var translate = Mathf.Min(Mathf.Abs(Input.GetAxis("Mouse ScrollWheel")), MaxToClamp - Mathf.Abs(ZoomAmount));
     gameObject.transform.Translate(0,0,translate * ROTSpeed * Mathf.Sign(Input.GetAxis("Mouse ScrollWheel")));
    }
}
