using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��Ʈ��Ƽ�� ���� - �����̽� �� ���� �̵� Ŭ����
public class SpaceBarHorizontalMove : SpaceBarMoveBehaviour
{
    /*------------------------------------------------------------------
    �̵�                                                                 */
    public void Move(Transform ts, Vector3 pos, float lerpSpd)
    {
        var tempPos = Vector3.Lerp(ts.position, pos, lerpSpd);
        ts.position = new Vector3(tempPos.x, tempPos.y, ts.position.z);
    }
    //------------------------------------------------------------------
}
