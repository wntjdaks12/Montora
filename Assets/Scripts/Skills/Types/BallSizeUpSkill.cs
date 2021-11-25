using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using System.Threading;
using System;

/// <summary>
///  스킬 행위에 캡슐화된 공 크기 사이즈 업 스킬입니다.
/// </summary>
public class BallSizeUpSkill : SkillBehaviour
{
    // 딜레이 임시 테스트 코드 입니다. 수정필요  
    private static CancellationTokenSource tokenSource;

    public void Use(GameObject obj)
    {
        //사이즈 2배만 적용합니다.
        if (obj.transform.localScale.x < 2)
            obj.transform.localScale = obj.transform.localScale * 2;

        tokenSource?.Cancel();

        Delay(obj);
    }

    // 딜레이 임시 테스트 코드 입니다. 수정필요  
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
