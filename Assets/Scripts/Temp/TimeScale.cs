using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 런타임 속도를 조절합니다.
/// </summary>
public class TimeScale{

    /// <summary>
    /// 런타임 속도를 조절합니다.
    /// </summary>
    /// <param name="spd">속도 값</param>
    public void Scale(float spd)
    {
        Time.timeScale = spd;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;
    }
}
