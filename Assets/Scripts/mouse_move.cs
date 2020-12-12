using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_move : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform cam;
 
    private void turn_player()
    {
        player.eulerAngles = new Vector3(0.0f, cam.eulerAngles.y, 0.0f);
        cam.transform.position = player.transform.position;

        player.eulerAngles = new Vector3(cam.eulerAngles.x, 0.0f, 0.0f);
        cam.transform.position = player.transform.position;
    }
 
    private void Update()
    {
        turn_player();
    }
}
