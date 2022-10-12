using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public SimpleCharacterMovement player;
    public bool followPlayer = false;
    [Header("Follow parameters")] 
    //TPS 0, 2.5, 3.5
    public Vector3 followDistance;

    public float followSmoothing;
    public bool cameraRotatesWithPlayer;
    void Start()
    {
        
    }

    void Update()
    {
        if (followPlayer)
        {
            transform.position = player.transform.position + followDistance;
            if (cameraRotatesWithPlayer)
            {
                //TODO rotation
            }
        }
    }
}
