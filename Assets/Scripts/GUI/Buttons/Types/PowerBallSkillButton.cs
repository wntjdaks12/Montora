using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ��ų ��ư�� ĸ��ȭ�� �Ŀ��� ��ų ��ư�Դϴ�.
/// </summary>
public class PowerBallSkillButton : SkillButton
{
    public override void Click()
    {
        skillBehaviourEventHandler(new PowerBallSkill());
    }
}
