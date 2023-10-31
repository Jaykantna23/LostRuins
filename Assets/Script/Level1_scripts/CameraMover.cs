using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public GameObject camera;
    public GameObject player;

    void Update()
    {
        if(player.transform.position.x < 0)
        {
            camera.transform.position = new Vector3(0, 0, -10);
        }
        else
        {
            camera.transform.position = new Vector3(player.transform.position.x, 0, -10);
        }
    }
}
