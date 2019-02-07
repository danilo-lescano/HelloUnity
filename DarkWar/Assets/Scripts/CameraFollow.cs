using UnityEngine;

public class CameraFollow : MonoBehaviour{
    public Transform target;
    float speed = 0.125f;

    void LateUpdate(){
        //Vector3.Lerp(Vector3 origin, Vector3 final, float framesToReach)
        //framesToReach entre 0 e 1
        transform.position = Vector3.Lerp(
            transform.position,
            new Vector3(target.position.x, transform.position.y, -10),
            speed
        );
        //transform.LookAt(target);
    }
}