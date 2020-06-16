using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class StayTrainPlayer : MonoBehaviour
{
    public float speed;
    public Vector2 speed_vec;
    
    // Start is called before the first frame update
    void Start()
    {
        float MinX = StayTrainCAKE.x - 0.3f;
        float MaxX = StayTrainCAKE.x + 0.3f;

        float MinY = StayTrainCAKE.y - 0.3f;
        float MaxY = StayTrainCAKE.y + 0.3f;



        float randomX = Random.Range(MinX,MaxX ); //적이 나타날 X좌표를 랜덤으로 생성해 줍니다.
        float randomY = Random.Range(MinY,MaxY );//적이 나타날 X좌표를 랜덤으로 생성해 줍니다.

        transform.position = new Vector2(randomX, randomY);
        
    }
    void Update()
    {
        // speed_vec.x = Input.GetAxis("Horizontal")*speed;
        // speed_vec.y = Input.GetAxis("Vertical")*speed;
        // GetComponent<Rigidbody2D>().velocity = speed_vec;

    }

}