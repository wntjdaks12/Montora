using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 스킬 버튼에 캡슐화된 공 크기 사이즈 업 스킬 버튼입니다.
/// </summary>
public class BallSizeUpSkillButton : SkillButton
{
    public override void Click()
    {
        skillBehaviourEventHandler(new BallSizeUpSkill());
    }
}
