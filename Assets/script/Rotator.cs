using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

  void Start() {

  }

  // オブジェクトを(x, y, z)すべての成分をランダムにして回転運動をさせる
  void Update() {
    transforms.Rotate(new Vector3(Random.Range(0,300),
                                 Random.Range(0, 300),
                                 Random.Range(0, 300)
                                ) * Time.deltaTime);

    //transform.Rotate(new Vector3(3,3,3));

  }
}
