using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ��ų ��ư�� ĸ��ȭ�� �� ũ�� ������ �� ��ų ��ư�Դϴ�.
/// </summary>
public class BallSizeUpSkillButton : SkillButton
{
    public override void Click()
    {
        skillBehaviourEventHandler(new BallSizeUpSkill());
    }
}
