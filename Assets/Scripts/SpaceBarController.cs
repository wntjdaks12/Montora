using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 스페이스 바 컨트롤러
public class SpaceBarController : MonoBehaviour
{
    /*------------------------------------------------------------------
    스페이스 바 참조                                                       */
    public SpaceBar spaceBar;
    //------------------------------------------------------------------

    private void Update()
    {
        Control();
    }

    /*------------------------------------------------------------------
    스페이스 바 컨트롤                                                  */
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
