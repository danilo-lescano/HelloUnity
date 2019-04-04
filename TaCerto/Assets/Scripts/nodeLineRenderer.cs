using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nodeLineRenderer : MonoBehaviour{
    public List<GameObject> nodes = new List<GameObject>();

    void Start(){
        for (int i = 0; i < 50; i++)
            nodes.Add(transform.GetChild(i).gameObject);
    }

    void Update(){
        if(!Input.GetMouseButton(0)){
            for (int i = 1; i < nodes.Count; i++){
                //nodes[i].gameObject.GetComponent<Rigidbody2D>().Simulated = true;
                if(Vector3.Distance(nodes[i - 1].transform.position, nodes[i].transform.position) > 0.1f){
                    Vector3 direction = (nodes[i].transform.position - nodes[i - 1].transform.position).normalized;
                    nodes[i].transform.position = nodes[i - 1].transform.position + direction * 0.1f;
                }
            }
        }
        else{
            for (int i = 1; i < nodes.Count; i++){
                //nodes[i].gameObject.GetComponent<Rigidbody2D>().Simulated = false;
            }

            for (int i = nodes.Count - 2; i >= 0; i++){
                if(Vector3.Distance(nodes[i + 1].transform.position, nodes[i].transform.position) > 0.2f){
                    Vector3 direction = (nodes[i].transform.position - nodes[i + 1].transform.position).normalized;
                    nodes[i].transform.position = nodes[i + 1].transform.position + direction * 0.2f;
                }
            }
        }

        Vector3[] pos = new Vector3[50];
        for(int i = 0; i < nodes.Count; i++){
            pos[i] = nodes[i].transform.position;
        }
        GetComponent<LineRenderer>().SetPositions(pos);
    }
}
