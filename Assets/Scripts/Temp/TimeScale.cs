using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ��Ÿ�� �ӵ��� �����մϴ�.
/// </summary>
public class TimeScale{

    /// <summary>
    /// ��Ÿ�� �ӵ��� �����մϴ�.
    /// </summary>
    /// <param name="spd">�ӵ� ��</param>
    public void Scale(float spd)
    {
        Time.timeScale = spd;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;
    }
}
