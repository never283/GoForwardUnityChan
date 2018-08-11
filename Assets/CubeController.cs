using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour
{

    // キューブの移動速度
    private float speed = -0.2f;

    // 消滅位置
    private float deadLine = -10;



    // 地面の位置
    private float groundLevel = -3.0f;

    //当たり判定
    bool hit_FLG;


    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // キューブを移動させる
        transform.Translate(this.speed, 0, 0);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }


    }


   

    void OnCollisionEnter(Collision hit)
    {
        if(hit_FLG == true)
        {
            if (hit.gameObject.tag == "Load")
            {

                GetComponent<AudioClip>();

            }


            if (hit.gameObject.tag == "Cube")
            {

                GetComponent<AudioClip>();

            }

            if (hit.gameObject.tag == "UnityChan")
            {

                GetComponent<AudioSource>().volume = 0;

            }



        }


    }







}