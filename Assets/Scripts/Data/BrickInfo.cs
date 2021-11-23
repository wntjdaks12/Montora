using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

// ���� ����
[System.Serializable]
public class BrickInfo
{
    public Vector3 pos;

    public BrickInfo(Vector3 pos)
    {
        this.pos = pos;
    }
}

// ���� ������
[System.Serializable]
public class BrickData
{
    public List<BrickInfo> brickInfos = new List<BrickInfo>();
}

// ���� ���̽�
public class BrickJson
{
    private static BrickData data = new BrickData();

    /// <summary>
    /// ���� �����͸� �н��ϴ�.
    /// </summary>
    public void ReadData()
    {
        // �ش� ��ο� ������ ���� ��� �����մϴ�.
        if (!new FileInfo(Application.dataPath + "Brick.json").Exists)
        {
            data.brickInfos.Add(new BrickInfo(new Vector3(0.5f, 10.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(-0.5f, 10.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(1.5f, 10.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(-1.5f, 10.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(-2.5f, 10.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(2.5f, 10.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(3.5f, 10.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(-3.5f, 10.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(4.5f, 10.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(-4.5f, 10.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(5.5f, 10.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(-5.5f, 10.5f, 0f)));
            //--
            data.brickInfos.Add(new BrickInfo(new Vector3(0.5f, 9.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(-0.5f, 9.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(1.5f, 9.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(-2.5f, 9.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(2.5f, 9.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(3.5f, 9.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(-3.5f, 9.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(-4.5f, 9.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(5.5f, 9.5f, 0f)));
            //--
            data.brickInfos.Add(new BrickInfo(new Vector3(0.5f, 8.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(-0.5f, 8.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(-1.5f, 8.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(-2.5f, 8.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(2.5f, 8.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(-3.5f, 8.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(-4.5f, 8.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(-5.5f, 8.5f, 0f)));
            //--
            data.brickInfos.Add(new BrickInfo(new Vector3(0.5f, 7.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(1.5f, 7.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(-1.5f, 7.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(-2.5f, 7.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(2.5f, 7.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(3.5f, 7.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(-3.5f, 7.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(-4.5f, 7.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(5.5f, 7.5f, 0f)));
            data.brickInfos.Add(new BrickInfo(new Vector3(-5.5f, 7.5f, 0f)));
            File.WriteAllText(Application.dataPath + "Brick.json", JsonUtility.ToJson(data));
        }

        // �ش� ��ο� ������ �н��ϴ�.
        var dataStr = File.ReadAllText(Application.dataPath + "Brick.json");
        data = JsonUtility.FromJson<BrickData>(dataStr);
    }

    public static BrickData brickData { get { return data; } }
}
