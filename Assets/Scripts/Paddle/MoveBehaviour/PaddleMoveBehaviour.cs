using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��Ʈ��Ƽ�� ���� - �е� �̵� �������̽�
public interface PaddleMoveBehaviour
{
    /// <summary>
    /// �̵� �� �ʿ��� ��ҵ��Դϴ�.
    /// </summary>
    /// <param name="paddleObj">�е� ������Ʈ</param>
    /// <param name="pos">�̵��� ������ ��</param>
    /// <param name="lerpSpd">�̵� �� �ε巯�� �ӵ�</param>
    public void Move(GameObject paddleObj, Vector3 pos, float lerpSpd);
}
