using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �����̽� ��
public class SpaceBar : MonoBehaviour
{
    /*------------------------------------------------------------------
    �����̽� �ٿ� ����, �������� �������̸� �ռ�����                       */ 
    private SpaceBarState state;
    private SpaceBarMoveBehaviour moveBehaviour;
    //------------------------------------------------------------------

    private void Awake()
    {
        state = SpaceBarIdleState.GetInstance();
        moveBehaviour = new SpaceBarHorizontalMove();
    }

    /*------------------------------------------------------------------
     ����, ������ �ν��Ͻ� ����                                            */
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
     �����̽� �ٰ� �����ϴ� ���µ�                                          */
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
