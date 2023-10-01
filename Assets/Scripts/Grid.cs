using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// For generating and managing grids
/// </summary>
public class Grid
{
    /// <summary>
    /// 格子数据
    /// </summary>
    public GridData GridData;
    
    /// <summary>
    /// 相邻的格子  0：↑   1：↓   2：←   3：→
    /// </summary>
    public Dictionary<int, Grid> AdjacentGrid = new Dictionary<int, Grid>();
    
    /// <summary>
    /// 格子的游戏对象
    /// </summary>
    public GameObject GameObject;
}
