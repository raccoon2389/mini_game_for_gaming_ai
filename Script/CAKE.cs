using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CAKE : MonoBehaviour
{
    static float y;
    
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {

        target = GameObject.FindGameObjectWithTag("Respawn");

        float randomX = Random.Range(-5.47f, 5.51f); //적이 나타날 X좌표를 랜덤으로 생성해 줍니다.
        float randomY = Random.Range(-3.86f, 3.59f); //적이 나타날 X좌표를 랜덤으로 생성해 줍니다.

        transform.position = new Vector2(randomX,randomY);
        
    }
    // private void OnTriggerEnter2D(Collider2D collision)
    // {
    //     Destroy(target);
    // }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Destroy(target);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
