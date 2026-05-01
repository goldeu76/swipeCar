# 작성 에디터 버전 : 2022.3.60f1

🚗 Swipe Car Game
Unity로 만든 마우스 스와이프 기반 2D 자동차 이동 프로젝트입니다.

---

## 📌 프로젝트 소개
마우스 스와이프 입력을 이용해 자동차를 이동시키는 간단한 물리 기반 2D 게임입니다.  
스와이프 길이에 따라 이동 속도가 결정되고, 감속을 통해 자연스럽게 멈추는 구조로 구현했습니다.

---

## 🎮 현재 구현된 기능
- 마우스 드래그 기반 스와이프 입력 감지
- 스와이프 거리 기반 속도 계산
- 자연스러운 감속 효과 (speed *= 0.98f)
- 목표 지점까지 거리 UI 표시
- 이동 시 효과음 재생

---

## 🧠 주요 스크립트 (CarController + UI 포함)

```csharp
public class CarController : MonoBehaviour
{
    GameObject flag;
    float speed = 0;
    Vector2 startPos;

    void Start()
    {
        this.flag = GameObject.Find("flag");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - this.startPos.x;
            this.speed = swipeLength / 500.0f;

            GetComponent<AudioSource>().Play();
        }

        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.98f;
    }
}
