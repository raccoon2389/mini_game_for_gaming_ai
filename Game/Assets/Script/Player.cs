using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    private GameObject target;

    public float speed;
    public Vector2 speed_vec;
    public float stay;
    // Start is called before the first frame update
    void Start()
    {

        float randomX = Random.Range(-5.47f, 5.51f); //적이 나타날 X좌표를 랜덤으로 생성해 줍니다.
        float randomY = Random.Range(-3.86f, 3.59f); //적이 나타날 X좌표를 랜덤으로 생성해 줍니다.

        transform.position = new Vector2(randomX,randomY);
        
    }
    // private void OnTriggerEnter2D(Collider2D collision)
    // {
    //     transform.position = new Vector2(1000f,1000f);
    //     SceneManager.LoadScene("YOUWIN");

    // }
    

    // Update is called once per frame
    void Update()
    {
        speed_vec.x = Input.GetAxis("Horizontal")*speed;
        speed_vec.y = Input.GetAxis("Vertical")*speed;
        GetComponent<Rigidbody2D>().velocity = speed_vec;

    }
    void move()
    {
        
    }
}