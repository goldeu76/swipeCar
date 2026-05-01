using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject car; 
    GameObject flag;
    GameObject distance; //text ui
    // Start is called before the first frame update
    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x; //깃발의 x값에서 자동차 x값을 뺌(거리)
        this.distance.GetComponent<Text>().text = "목표 지점까지 " + length.ToString("F2") + "m"; //거리 구한후 출력
    }
}
