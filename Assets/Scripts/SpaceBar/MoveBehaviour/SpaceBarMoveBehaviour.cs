using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��Ʈ��Ƽ�� ���� - �����̽� �� �̵� �������̽�
public interface SpaceBarMoveBehaviour
{
    public void Move(Transform ts, Vector3 pos, float lerpSpd);
}
