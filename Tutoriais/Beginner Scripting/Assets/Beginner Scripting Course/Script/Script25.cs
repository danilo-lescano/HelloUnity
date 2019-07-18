using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script25 : MonoBehaviour{
    public GameObject target;
    public Transform pontaCanhao;

    void Start(){
        InvokeRepeating("SpawnObject", 2, 1);
    }

    void SpawnObject(){
        GameObject projetil = Instantiate(target, pontaCanhao.position, pontaCanhao.rotation);
        projetil.GetComponent<Rigidbody>().AddForce(pontaCanhao.forward * 5000);
    }
}