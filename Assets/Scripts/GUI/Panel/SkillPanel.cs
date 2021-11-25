using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 스킬을 선택할 수 있는 패널입니다.
/// </summary>
public class SkillPanel : MonoBehaviour
{
    // 런타임 속도를 조절하기 위해 참조를 합니다.
    private TimeScale timeSacle;

    private void OnEnable()
    {
        // 활성화 시 런타임 속도를 낮춥니다.
        timeSacle?.Scale(0.4f);
    }

    private void Awake()
    {
        timeSacle = new TimeScale();
    }

    private void Start()
    {
        timeSacle?.Scale(0.4f);
    }

    private void OnDisable()
    {
        // 비활성화 시 런타임 속도를 정상으로 바꿉니다.
        timeSacle?.Scale(1.0f);
    }
}
