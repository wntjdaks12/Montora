using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �е� ���� �̵� Ŭ����
/// </summary>
public class PaddleHorizontalMove : PaddleMoveBehaviour
{
    // ���ηθ� �����̴� �޼ҵ� �Դϴ�.
    public void Move(GameObject paddleObj, Vector3 pos, float lerpSpd)
    {
        // �е��� ������ ���ݰ� �ش� ��ũ�� ���� ���մϴ�.
        var paddleHalfX = paddleObj.GetComponent<SpriteRenderer>().bounds.extents;
        var scrWidth = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        // �ش� ��ũ���� ���� �е��� �����̴� ������ �����մϴ�.
        var resultPos = new Vector3(Mathf.Clamp(pos.x, -scrWidth.x + paddleHalfX.x, scrWidth.x - paddleHalfX.x), paddleObj.transform.position.y, paddleObj.transform.position.z);

        // ���� ������ ����Ͽ� �������� �ε巴�� �մϴ�.
        paddleObj.transform.position = Vector3.Lerp(paddleObj.transform.position, resultPos, lerpSpd);
    }
}