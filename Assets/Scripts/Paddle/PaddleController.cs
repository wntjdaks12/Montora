using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

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

        if (Input.GetMouseButton(0) && EventSystem.current.currentSelectedGameObject == null)
            paddle.Operate(Input.mousePosition);
        else
            paddle.Stop();
    }
}
