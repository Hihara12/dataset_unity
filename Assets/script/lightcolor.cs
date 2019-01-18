using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class lightcolor : MonoBehaviour {
    public Light lt;
    void Start() {
        lt = GetComponent<Light>();
    }

    public float tmpTime = 0;

    void Update() {

        float interval = 1f;
        tmpTime += Time.deltaTime;

        if(tmpTime>= interval){

            //int r1 = Random.Range(0,255);
            //int r2 = Random.Range(0,255);
            //int r3 = Random.Range(0,255);
            //int r4 = Random.Range(0,255);
            int r5 = Random.Range(0,40);

            //byte c1 = (byte)r1;
            //byte c2 = (byte)r2;
            //byte c3 = (byte)r3;
            //byte c4 = (byte)r4;
            float c5 = (float)r5/10;

            //lt.color = new Color32(c1, c2, c3, c4);
            lt.intensity= c5;

            tmpTime = 0f;
        }

    }
}
