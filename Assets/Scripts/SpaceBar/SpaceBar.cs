using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 스페이스 바
public class SpaceBar : MonoBehaviour
{
    /*------------------------------------------------------------------
    스페이스 바와 상태, 움직임은 의존적이며 합성관계                       */ 
    private SpaceBarState state;
    private SpaceBarMoveBehaviour moveBehaviour;
    //------------------------------------------------------------------

    private void Awake()
    {
        state = SpaceBarIdleState.GetInstance();
        moveBehaviour = new SpaceBarHorizontalMove();
    }

    /*------------------------------------------------------------------
     상태, 움직임 인스턴스 변경                                            */
    public void SetState(SpaceBarState state)
    {
        this.state = state;
    }

    public void SetMoveBehaviour(SpaceBarMoveBehaviour moveBehaviour)
    {
        this.moveBehaviour = moveBehaviour;
    }
    //------------------------------------------------------------------

    /*------------------------------------------------------------------
     스페이스 바가 수행하는 상태들                                          */
    public void Idle()
    {
        state?.Idle(this);
    }

    public void Move(Vector3 pos)
    {
        moveBehaviour?.Move(transform, Camera.main.ScreenToWorldPoint(pos), 0.3f);
        state?.Move(this);
    }
    //------------------------------------------------------------------
}
