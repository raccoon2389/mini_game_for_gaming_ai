using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class LeftTrainPlayer : MonoBehaviour
{
    public float speed;
    public Vector2 speed_vec;
    
    // Start is called before the first frame update
    void Start()
    {

        float randomX = Random.Range(LeftTrainCAKE.x+0.9f,5.54f); //적이 나타날 X좌표를 랜덤으로 생성해 줍니다.
        float randomY =  Random.Range((float)LeftTrainCAKE.y-0.2f,(float)LeftTrainCAKE.y+0.2f);//적이 나타날 X좌표를 랜덤으로 생성해 줍니다.

        transform.position = new Vector2(randomX,randomY);
        
    }
    void Update()
    {
        // speed_vec.x = Input.GetAxis("Horizontal")*speed;
        // speed_vec.y = Input.GetAxis("Vertical")*speed;
        // GetComponent<Rigidbody2D>().velocity = speed_vec;

    }

}