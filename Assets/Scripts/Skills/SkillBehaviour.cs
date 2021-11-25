using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 스킬 행위입니다.
/// </summary>
public interface  SkillBehaviour
{
    /// <summary>
    /// 스킬을 사용합니다.
    /// </summary>
    /// <param name="obj">스킬 대상</param>
    public void Use(GameObject obj);
}
