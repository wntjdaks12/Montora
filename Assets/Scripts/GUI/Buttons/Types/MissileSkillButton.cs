using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ��ų ��ư�� ĸ��ȭ�� �̻��� ��ų ��ư�Դϴ�.
/// </summary>
public class MissileSkillButton : SkillButton
{
    public override void Click()
    {
        skillBehaviourEventHandler(new MissileSkill());
    }
}
