using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 일반적인 벽돌 생산 인스턴스 공장
/// </summary>
public class GeneralBrickFactory : BrickFactory
{
    /// <summary>
    /// 벽돌의 생산을 맡는 인스턴스를 리턴합니다.
    /// </summary>
    /// <param name="name">벽돌 이름</param>
    /// <returns></returns>
    public override BrickProduct getInstance(string name)
    {
        //해당 이름의 벽돌 인스턴스를 리턴합니다.
        switch (name)
        {
            case "BasicBrick": return new BasicBrickProduct();
        }

        return null;
    }
}
