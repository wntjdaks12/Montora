using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

// 벽돌 정보
[System.Serializable]
public class BrickInfo
{
    public Vector3 pos;

    public BrickInfo(Vector3 pos)
    {
        this.pos = pos;
    }
}

// 벽돌 데이터
[System.Serializable]
public class BrickData
{
    public List<BrickInfo> brickInfos = new List<BrickInfo>();
}

// 벽돌 제이슨
public class BrickJson
{
    private BrickData data = new BrickData();

    /// <summary>
    /// 벽돌 데이터를 읽습니다.
    /// </summary>
    public void ReadData()
    {
        // 해당 경로에 파일이 없을 경우 생성합니다.
        if (!new FileInfo(Application.dataPath + "Brick.json").Exists)
        {
            data.brickInfos.Add(new BrickInfo(new Vector3(1, 1, 1)));
            data.brickInfos.Add(new BrickInfo(new Vector3(1, 1, 1)));
            data.brickInfos.Add(new BrickInfo(new Vector3(1, 1, 1)));
            data.brickInfos.Add(new BrickInfo(new Vector3(1, 1, 1)));
            data.brickInfos.Add(new BrickInfo(new Vector3(1, 1, 1)));
            data.brickInfos.Add(new BrickInfo(new Vector3(1, 1, 1)));
            data.brickInfos.Add(new BrickInfo(new Vector3(1, 1, 1)));
            data.brickInfos.Add(new BrickInfo(new Vector3(1, 1, 1)));
            data.brickInfos.Add(new BrickInfo(new Vector3(1, 1, 1)));
            data.brickInfos.Add(new BrickInfo(new Vector3(1, 1, 1)));

            File.WriteAllText(Application.dataPath + "Brick.json", JsonUtility.ToJson(data));
        }

        // 해당 경로에 파일을 읽습니다.
        var dataStr = File.ReadAllText(Application.dataPath + "Brick.json");
        data = JsonUtility.FromJson<BrickData>(dataStr);
    }
}
