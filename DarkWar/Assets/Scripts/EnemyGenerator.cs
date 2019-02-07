using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour{
    float time = 1f;
    Vector3 pos00, pos11;
    GameObject enemyPrefab;
    void Start(){
        enemyPrefab = (GameObject) Resources.Load("Prefab/Enemy");
        pos00 = Camera.main.ScreenToWorldPoint(new Vector3 (0f, Screen.height/2, 0f));
        pos11 = Camera.main.ScreenToWorldPoint(new Vector3 (Screen.width, Screen.height, 0f));
        transform.position = new Vector3(
            Random.Range(pos00.x, pos11.x),
            Random.Range(pos00.y, pos11.y),
            0f
        );
    }

    void Update(){
        time -= Time.deltaTime;
        if(time < 0f){
            time = 1f;
            pos00 = Camera.main.ScreenToWorldPoint(new Vector3 (0f, Screen.height/2, 0f));
            pos11 = Camera.main.ScreenToWorldPoint(new Vector3 (Screen.width, Screen.height, 0f));
            transform.position = new Vector3(
                Random.Range(pos00.x, pos11.x),
                Random.Range(pos00.y, pos11.y),
                0f
            );
            GameObject enemy = Instantiate(enemyPrefab);
            enemy.transform.position = transform.position;
        }
    }
}
