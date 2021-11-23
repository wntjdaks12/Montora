using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 데이터 관리
public class DataManager : MonoBehaviour
{
    private void Start()
    {
        new BrickJson().ReadData();
    }
}
