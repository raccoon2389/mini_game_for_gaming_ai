using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class RightTrainPlayer : MonoBehaviour
{
    public float speed;
    public Vector2 speed_vec;
    
    // Start is called before the first frame update
    void Start()
    {

        float randomX = Random.Range(-5.47f,(float)RightTrainCAKE.x-2.02f); //적이 나타날 X좌표를 랜덤으로 생성해 줍니다.
        float randomY =  Random.Range((float)RightTrainCAKE.y-0.4f,(float)RightTrainCAKE.y+0.4f);//적이 나타날 X좌표를 랜덤으로 생성해 줍니다.

        transform.position = new Vector2(randomX,randomY);
        
    }
    void Update()
    {
        // speed_vec.x = Input.GetAxis("Horizontal")*speed;
        // speed_vec.y = Input.GetAxis("Vertical")*speed;
        // GetComponent<Rigidbody2D>().velocity = speed_vec;

    }

}