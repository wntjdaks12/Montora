using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  ��ų ������ ĸ��ȭ�� �̻��� ��ų�Դϴ�.
/// </summary>
public class MissileSkill : SkillBehaviour
{
    public void Use(GameObject obj)
    {
        MonoBehaviour.Instantiate(Resources.Load("Prefabs/MissileObject"));
    }
}
