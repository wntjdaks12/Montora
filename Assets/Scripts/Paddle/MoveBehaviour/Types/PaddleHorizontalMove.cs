using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 패들 가로 이동 클래스
/// </summary>
public class PaddleHorizontalMove : PaddleMoveBehaviour
{
    // 가로로만 움직이는 메소드 입니다.
    public void Move(GameObject paddleObj, Vector3 pos, float lerpSpd)
    {
        // 패들의 사이즈 절반과 해당 스크린 값을 구합니다.
        var paddleHalfX = paddleObj.GetComponent<SpriteRenderer>().bounds.extents;
        var scrWidth = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        // 해당 스크린에 맞춰 패들의 움직이는 범위를 제어합니다.
        var resultPos = new Vector3(Mathf.Clamp(pos.x, -scrWidth.x + paddleHalfX.x, scrWidth.x - paddleHalfX.x), paddleObj.transform.position.y, paddleObj.transform.position.z);

        // 선형 보간을 사용하여 움직임을 부드럽게 합니다.
        paddleObj.transform.position = Vector3.Lerp(paddleObj.transform.position, resultPos, lerpSpd);
    }
}