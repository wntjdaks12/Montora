using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �е� ������
/// </summary>
public class PaddleController : MonoBehaviour
{
    /// <summary>
    /// �е��� �����մϴ�.
    /// </summary>
    public Paddle paddle;

    private void Update()
    {
        Control();
    }

    /// <summary>
    /// �е��� ���� �մϴ�.
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
