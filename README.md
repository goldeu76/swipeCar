# 작성 에디터 버전 : 2022.3.60f1

🎰 Roulette Game
Unity로 처음 만든 아주 단순한 2D 랜덤 룰렛 프로젝트입니다.

---

## 📌 프로젝트 소개
2022년 Unity를 처음 배우면서 제작한 연습용 프로젝트입니다.  
마우스 클릭으로 룰렛을 회전시키고, 감속을 통해 자연스럽게 멈추는 기본 회전 로직을 구현했습니다.

---

## 🎮 현재 구현된 기능
- 마우스 왼쪽 클릭으로 룰렛 회전 시작
- 회전 속도 점점 감소 (rotSpeed *= 0.96f)
- 자연스럽게 멈추는 감속 효과 구현
- 고정된 화살표 기준으로 결과 확인 가능

---

## 🧠 주요 스크립트 (RouletController.cs)

```csharp
public class RouletController : MonoBehaviour
{
    float rotSpeed = 0f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))     // 마우스 왼쪽 클릭
        {
            rotSpeed = 10f;
        }

        transform.Rotate(0, 0, rotSpeed);   // 회전 적용
        rotSpeed *= 0.96f;                  // 자연 감속
    }
}
