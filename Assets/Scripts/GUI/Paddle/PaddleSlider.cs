using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//패들 슬라이더
public class PaddleSlider : MonoBehaviour
{
    //슬라이더 요소입니다.
    private Slider slider;

    private void Awake()
    {
        slider = GetComponent<Slider>();
    }
    /// <summary>
    /// 슬라이더 값을 변경합니다.
    /// </summary>
    /// <param name="val"></param>
    public void setValue(float val)
    {
        if (slider == null)
            return;

        slider.value = val;
    }
}
