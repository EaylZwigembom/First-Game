using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform camero;
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 eyes;

    
private void FixedUpdate(){
    camero.position = player.position + eyes;
}
}
