using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 패들 제어자
/// </summary>
public class PaddleController : MonoBehaviour
{
    /// <summary>
    /// 패들을 참조합니다.
    /// </summary>
    public Paddle paddle;

    private void Update()
    {
        Control();
    }

    /// <summary>
    /// 패들을 제어 합니다.
    /// </summary>
    public void Control()
    {
        if (paddle == null)
            return;

        if (Input.GetMouseButton(0))
            paddle.Move(Input.mousePosition);
        else
            paddle.Idle();
    }
}
