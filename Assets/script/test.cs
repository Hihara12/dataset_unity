using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player {

    private int hp = 100;
    private int power = 50;

    public void Attack () {
        Debug.Log(this.power + "のダメージを与えた");
    }
    public void Damage(int damage) {
        this.hp -= damage;
        Debug.Log(damage + "のダメージを受けた");
    }
}

public class test : MonoBehaviour {

    void Start () {
        Vector2 startPOs = new Vector2(2.0f,1.0f);
        Vector2 endPos = new Vector2(8.0f,5.0f);
        Vector2 dir = endPos - startPOs;

        float len = dir.magnitude;
        Debug.Log(len);
    }

	void Update () {
	}
}
