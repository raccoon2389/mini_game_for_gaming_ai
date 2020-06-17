using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CAKE : MonoBehaviour
{
    public float stay = 0;
    static float y;
    
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        stay = 0;

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
        stay +=1;
    }
    // Update is called once per frame
    void Update()
    {
        if (stay > 22f)
        {
            SceneManager.LoadScene("YOUWIN");
        }
        
    }
}
