using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 格子数据
/// </summary>
public struct GridData
{
    /// <summary>
    /// 格子的类型
    /// </summary>
    public GridType GridType;
    
    /// <summary>
    /// 格子的X轴位置
    /// </summary>
    public int X;
    
    /// <summary>
    /// 格子的Y轴位置
    /// </summary>
    public int Y;
    
    /// <summary>
    /// 格子索引
    /// </summary>
    public int Index;
}

public enum GridType
{
    /// <summary>
    /// 木
    /// </summary>
    Wood,

    /// <summary>
    /// 火
    /// </summary>
    Fire,

    /// <summary>
    /// 土
    /// </summary>
    Earth,

    /// <summary>
    /// 金
    /// </summary>
    Metal,

    /// <summary>
    /// 水
    /// </summary>
    Water
}