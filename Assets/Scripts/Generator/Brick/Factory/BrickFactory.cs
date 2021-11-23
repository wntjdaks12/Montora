using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 벽돌 생산 인스턴스 공장
/// </summary>
public abstract class BrickFactory
{
    public abstract BrickProduct getInstance(string name);
}
