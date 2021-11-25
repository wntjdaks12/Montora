using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  스킬 행위에 캡슐화된 미사일 스킬입니다.
/// </summary>
public class MissileSkill : SkillBehaviour
{
    public void Use(GameObject obj)
    {
        MonoBehaviour.Instantiate(Resources.Load("Prefabs/MissileObject"));
    }
}
