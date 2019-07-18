using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script4 : MonoBehaviour{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    void Update(){
        if(Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();
        coffeeTemperature -= 5f * Time.deltaTime;
    }

    void TemperatureTest(){
        if(coffeeTemperature > hotLimitTemperature)
            print("Hot");
        else if(coffeeTemperature < coldLimitTemperature)
            print("cold");
        else
            print("good");
    }
}