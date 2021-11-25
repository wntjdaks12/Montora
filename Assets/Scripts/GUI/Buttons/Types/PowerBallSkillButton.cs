using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 스킬 버튼에 캡슐화된 파워볼 스킬 버튼입니다.
/// </summary>
public class PowerBallSkillButton : SkillButton
{
    public override void Click()
    {
        skillBehaviourEventHandler(new PowerBallSkill());
    }
}
