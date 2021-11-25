using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using System.Threading;
using System;

/// <summary>
///  ��ų ������ ĸ��ȭ�� �Ŀ��� ��ų�Դϴ�.
/// </summary>
public class PowerBallSkill : SkillBehaviour
{
    // ������ �ӽ� �׽�Ʈ �ڵ� �Դϴ�. �����ʿ�  
    private static CancellationTokenSource tokenSource;

    public void Use(GameObject obj)
    {
        if (obj.GetComponent<Ball>() == null || obj.GetComponentInChildren<SpriteRenderer>() == null)
            return;

        // ���� ������ �մϴ�.
        obj.GetComponent<Ball>().isPiercing = true;
        // ���ο� ��������Ʈ�� �ε��մϴ�.
        obj.GetComponentInChildren<SpriteRenderer>().sprite = Resources.Load <Sprite> ("Images/Balls/" + "PowerBall");

        Delay(obj);
    }

    // ������ �ӽ� �׽�Ʈ �ڵ� �Դϴ�. �����ʿ�  
    private async void Delay(GameObject obj)
    {
        await Task.Delay(5000);

        obj.GetComponent<Ball>().isPiercing = false;
        obj.GetComponentInChildren<SpriteRenderer>().sprite = Resources.Load<Sprite>("Images/Balls/" + "Ball");
    }
}
