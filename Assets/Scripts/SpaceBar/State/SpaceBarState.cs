using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//������Ʈ ���� - �����̽� �� �������̽�
public interface SpaceBarState
{
    public void Idle(SpaceBar spaceBar);
    public void Move(SpaceBar spaceBar);
}
