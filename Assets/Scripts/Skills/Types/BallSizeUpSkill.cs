using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using System.Threading;
using System;

/// <summary>
///  ��ų ������ ĸ��ȭ�� �� ũ�� ������ �� ��ų�Դϴ�.
/// </summary>
public class BallSizeUpSkill : SkillBehaviour
{
    // ������ �ӽ� �׽�Ʈ �ڵ� �Դϴ�. �����ʿ�  
    private static CancellationTokenSource tokenSource;

    public void Use(GameObject obj)
    {
        //������ 2�踸 �����մϴ�.
        if (obj.transform.localScale.x < 2)
            obj.transform.localScale = obj.transform.localScale * 2;

        tokenSource?.Cancel();

        Delay(obj);
    }

    // ������ �ӽ� �׽�Ʈ �ڵ� �Դϴ�. �����ʿ�  
    private async void Delay(GameObject obj)
    {
        tokenSource = new CancellationTokenSource();

        try
        {
            await Task.Delay(5000, tokenSource.Token);

            obj.transform.localScale = obj.transform.localScale / 2;
        }
        catch (Exception ex)
        {
        }
    }
}
