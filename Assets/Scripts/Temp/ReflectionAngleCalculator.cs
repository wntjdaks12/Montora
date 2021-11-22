using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//반사각 계산
public class ReflectionAngleCalculator
{
    /// <summary>
    /// 반사각을 리턴합니다.
    /// </summary>
    /// <param name="x">현재 X 값</param>
    /// <param name="collision">충돌 대상</param>
    /// <returns></returns>
    public float getAngle(float x, Collision2D collision)
    {
        // 충돌 대상의 사이즈를 가져옵니다.
        var collBounds = collision.transform.GetComponent<SpriteRenderer>().bounds;

        // 충돌 대상의 사이즈 비율에 따른 0 ~ 90도의 각도를 구합니다.
        var angle = (Mathf.Abs(collBounds.center.x - collision.contacts[0].point.x)) * 90.0f / (collBounds.size.x * 0.5f);

        // 수월하게 게임을 진행하기 위해 사잇각을 `10 ~ 80으로 변경합니다.
        angle = Mathf.Clamp(angle, 10, 80);

        // 현재 X 값이 충돌 대상의 우측일 경우 반대 방향으로 바꿉니다.
        if (x >= collision.transform.position.x)
            return angle * -1.0f;

        return angle;
    }

    /// <summary>
    /// 반대 방향의 각도를 리턴합니다.
    /// </summary>
    /// <param name="eulerAngle"현재 각도></param>
    /// <returns></returns>
    public float getAngle(float eulerAngle) 
    {
        //-1를 곱하면 방향이 바뀝니다.
        return eulerAngle * -1.0f;
    }

    /// <summary>
    /// 진행 방향을 바꾸는 각도를 리턴합니다.
    /// </summary>
    /// <param name="eulerAngle">현재 각도</param>
    /// <returns></returns>
    public float getAngle2(float eulerAngle)
    {
        //-1을 곱하고 180을 더하면 진행 방향이 바뀝니다.
        return eulerAngle * -1.0f + 180.0f;
    }
}
