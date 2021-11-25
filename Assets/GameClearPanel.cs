using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClearPanel : MonoBehaviour
{
    // ��Ÿ�� �ӵ��� �����ϱ� ���� ������ �մϴ�.
    private TimeScale timeSacle;

    private void OnEnable()
    {
        // Ȱ��ȭ �� ��Ÿ�� �ӵ��� ����ϴ�.
        timeSacle?.Scale(0);
    }

    private void Awake()
    {
        timeSacle = new TimeScale();
    }

    private void Update()
    {
        timeSacle?.Scale(0f);
    }

    private void OnDisable()
    {
        // ��Ȱ��ȭ �� ��Ÿ�� �ӵ��� �������� �ٲߴϴ�.
        timeSacle?.Scale(1.0f);
    }
}
