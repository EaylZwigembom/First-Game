using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform camero;
    public Transform player;
    public Vector3 eyes;
public void FixedUpdate(){
    camero.position = player.position + eyes;
}
}
