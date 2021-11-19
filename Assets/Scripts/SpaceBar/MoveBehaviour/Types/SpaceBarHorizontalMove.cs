using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//스트레티지 패턴 - 스페이스 바 가로 이동 클래스
public class SpaceBarHorizontalMove : SpaceBarMoveBehaviour
{
    /*------------------------------------------------------------------
    이동                                                                 */
    public void Move(Transform ts, Vector3 pos, float lerpSpd)
    {
        var tempPos = Vector3.Lerp(ts.position, pos, lerpSpd);
        ts.position = new Vector3(tempPos.x, tempPos.y, ts.position.z);
    }
    //------------------------------------------------------------------
}
