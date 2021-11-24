using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface BallState 
{
    public void UpMove(Ball ball);
    public void DownMove(Ball ball);
}
