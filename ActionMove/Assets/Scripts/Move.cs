﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Move : MonoBehaviour
{
    [SerializeField] protected float _moveSpeed = 0.0f; // 移動速度

    /// <summary>
    /// 移動
    /// </summary>
    /// <param name="dir">進行方向</param>
    public abstract void Moving(Vector3 dir);
}