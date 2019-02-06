using UnityEngine;

public class CameraFollow : MonoBehaviour{
    public Transform target;
    float speed = 0.125f;

    void LateUpdate(){
        //lerp faz com que o objeto acompanhe o outro com uma velocidade menor
        transform.position = Vector3.Lerp(
            transform.position,
            new Vector3(target.position.x, transform.position.y, -10),
            speed
        );
    }
}
