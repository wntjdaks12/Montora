using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�ݻ簢 ���
public class ReflectionAngleCalculator
{
    /// <summary>
    /// �ݻ簢�� �����մϴ�.
    /// </summary>
    /// <param name="x">���� X ��</param>
    /// <param name="collision">�浹 ���</param>
    /// <returns></returns>
    public float getAngle(float x, Collision2D collision)
    {
        // �浹 ����� ����� �����ɴϴ�.
        var collBounds = collision.transform.GetComponent<SpriteRenderer>().bounds;

        // �浹 ����� ������ ������ ���� 0 ~ 90���� ������ ���մϴ�.
        var angle = (Mathf.Abs(collBounds.center.x - collision.contacts[0].point.x)) * 90.0f / (collBounds.size.x * 0.5f);

        // �����ϰ� ������ �����ϱ� ���� ���հ��� `10 ~ 80���� �����մϴ�.
        angle = Mathf.Clamp(angle, 10, 80);

        // ���� X ���� �浹 ����� ������ ��� �ݴ� �������� �ٲߴϴ�.
        if (x >= collision.transform.position.x)
            return angle * -1.0f;

        return angle;
    }

    /// <summary>
    /// �ݴ� ������ ������ �����մϴ�.
    /// </summary>
    /// <param name="eulerAngle"���� ����></param>
    /// <returns></returns>
    public float getAngle(float eulerAngle) 
    {
        //-1�� ���ϸ� ������ �ٲ�ϴ�.
        return eulerAngle * -1.0f;
    }

    /// <summary>
    /// ���� ������ �ٲٴ� ������ �����մϴ�.
    /// </summary>
    /// <param name="eulerAngle">���� ����</param>
    /// <returns></returns>
    public float getAngle2(float eulerAngle)
    {
        //-1�� ���ϰ� 180�� ���ϸ� ���� ������ �ٲ�ϴ�.
        return eulerAngle * -1.0f + 180.0f;
    }
}
