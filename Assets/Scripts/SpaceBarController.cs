using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �����̽� �� ��Ʈ�ѷ�
public class SpaceBarController : MonoBehaviour
{
    /*------------------------------------------------------------------
    �����̽� �� ����                                                       */
    public SpaceBar spaceBar;
    //------------------------------------------------------------------

    private void Update()
    {
        Control();
    }

    /*------------------------------------------------------------------
    �����̽� �� ��Ʈ��                                                  */
    public void Control()
    {
        if (spaceBar == null)
            return;

        if (Input.GetMouseButton(0))
            spaceBar.Move(Input.mousePosition);
        else
            spaceBar.Idle();
    }
    //------------------------------------------------------------------
}
