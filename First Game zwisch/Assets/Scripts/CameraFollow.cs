using UnityEngine;

public class CameraFollow : 
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 eyes;

    
private void FixedUpdate(){
    transform.position = player.position + eyes;
}
}
