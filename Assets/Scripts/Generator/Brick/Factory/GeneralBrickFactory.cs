using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �Ϲ����� ���� ���� �ν��Ͻ� ����
/// </summary>
public class GeneralBrickFactory : BrickFactory
{
    /// <summary>
    /// ������ ������ �ô� �ν��Ͻ��� �����մϴ�.
    /// </summary>
    /// <param name="name">���� �̸�</param>
    /// <returns></returns>
    public override BrickProduct getInstance(string name)
    {
        //�ش� �̸��� ���� �ν��Ͻ��� �����մϴ�.
        switch (name)
        {
            case "BasicBrick": return new BasicBrickProduct();
        }

        return null;
    }
}
