using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ��ų�� ������ �� �ִ� �г��Դϴ�.
/// </summary>
public class SkillPanel : MonoBehaviour
{
    // ��Ÿ�� �ӵ��� �����ϱ� ���� ������ �մϴ�.
    private TimeScale timeSacle;

    private void OnEnable()
    {
        // Ȱ��ȭ �� ��Ÿ�� �ӵ��� ����ϴ�.
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
        // ��Ȱ��ȭ �� ��Ÿ�� �ӵ��� �������� �ٲߴϴ�.
        timeSacle?.Scale(1.0f);
    }
}
