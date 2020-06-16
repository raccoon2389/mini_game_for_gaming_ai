using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RightDownTrainCAKE: MonoBehaviour {
    public static float y;
    public static float x;
    // Start is called before the first frame update
    void Start() {

        
        x = Random.Range(-3.61f, 5.25f);
        y = Random.Range(-3.77f, 1.71f );

        // float randomX = Random.Range(-5.47f, 5.51f); 적이 나타날 X좌표를 랜덤으로 생성해 줍니다. float
        // randomY = Random.Range(-3.86f, 3.59f); 적이 나타날 X좌표를 랜덤으로 생성해 줍니다.

        transform.position = new Vector2(x, y);

    }


    // Update is called once per frame
    void Update() {}
}
