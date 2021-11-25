using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ��ų ��ư �߻� Ŭ�����Դϴ�.
/// </summary>
public abstract class SkillButton : MonoBehaviour
{
    /// <summary>
    /// ��ų ������ �����ϴ� �븮���Դϴ�.
    /// </summary>
    /// <param name="skillBehaviour">��ų ����</param>
    public delegate void skillBehaviourDelegate(SkillBehaviour skillBehaviour);

    /// <summary>
    /// ��ų ������ �����ϴ� �̺�Ʈ�Դϴ�.
    /// </summary>
    public static event skillBehaviourDelegate skillBehaviourEvent;

    /// <summary>
    /// �̺�Ʈ �߻� �� ��ų ������ �����մϴ�. 
    /// </summary>
    /// <param name="skillBehaviour">��ų ����</param>
    public void skillBehaviourEventHandler(SkillBehaviour skillBehaviour)
    {
        skillBehaviourEvent?.Invoke(skillBehaviour);
    }

    /// <summary>
    /// ��ų�� ������ �����մϴ�.
    /// </summary>
    public abstract void Click();
}
