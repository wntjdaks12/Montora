using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 스킬 버튼 추상 클래스입니다.
/// </summary>
public abstract class SkillButton : MonoBehaviour
{
    /// <summary>
    /// 스킬 행위를 변경하는 대리자입니다.
    /// </summary>
    /// <param name="skillBehaviour">스킬 행위</param>
    public delegate void skillBehaviourDelegate(SkillBehaviour skillBehaviour);

    /// <summary>
    /// 스킬 행위를 변경하는 이벤트입니다.
    /// </summary>
    public static event skillBehaviourDelegate skillBehaviourEvent;

    /// <summary>
    /// 이벤트 발생 시 스킬 행위를 변경합니다. 
    /// </summary>
    /// <param name="skillBehaviour">스킬 행위</param>
    public void skillBehaviourEventHandler(SkillBehaviour skillBehaviour)
    {
        skillBehaviourEvent?.Invoke(skillBehaviour);
    }

    /// <summary>
    /// 스킬의 행위를 변경합니다.
    /// </summary>
    public abstract void Click();
}
