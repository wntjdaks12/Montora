using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using System.Threading;
using System;

/// <summary>
///  스킬 행위에 캡슐화된 파워볼 스킬입니다.
/// </summary>
public class PowerBallSkill : SkillBehaviour
{
    // 딜레이 임시 테스트 코드 입니다. 수정필요  
    private static CancellationTokenSource tokenSource;

    public void Use(GameObject obj)
    {
        if (obj.GetComponent<Ball>() == null || obj.GetComponentInChildren<SpriteRenderer>() == null)
            return;

        // 공은 관통을 합니다.
        obj.GetComponent<Ball>().isPiercing = true;
        // 새로운 스프라이트를 로드합니다.
        obj.GetComponentInChildren<SpriteRenderer>().sprite = Resources.Load <Sprite> ("Images/Balls/" + "PowerBall");

        Delay(obj);
    }

    // 딜레이 임시 테스트 코드 입니다. 수정필요  
    private async void Delay(GameObject obj)
    {
        await Task.Delay(5000);

        obj.GetComponent<Ball>().isPiercing = false;
        obj.GetComponentInChildren<SpriteRenderer>().sprite = Resources.Load<Sprite>("Images/Balls/" + "Ball");
    }
}
