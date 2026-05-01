using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CarController : MonoBehaviour
{
    GameObject flag;
    float speed = 0;
    Vector2 startPos;
    // Start is called before the first frame update
    void Start()
    {
        
        this.flag = GameObject.Find("flag");
        //this.flag.transform.position = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            transform.position = this.flag.transform.position;
        }*/
        if(Input.GetMouseButtonDown(0)) //마우스 좌클릭 할때
        {
            this.startPos = Input.mousePosition; //클릭한 순간 마우스 위치값 저장
        }
        else if (Input.GetMouseButtonUp(0)) //마우스를 땟을때
        {
            Vector2 endPos = Input.mousePosition; //땐 순간의 마우스 위치값 저장
            float swipeLength = endPos.x - this.startPos.x; //나중위치에서 처음위치 뺌(거리)
            this.speed = swipeLength / 500.0f; //거리를 500f로 나눔
            //this.flag.transform.position = transform.position;

            GetComponent<AudioSource>().Play(); //사운드 재생
        }
        transform.Translate(this.speed,0,0); //속도 누적
        this.speed *= 0.98f; // 감속
    }
}
