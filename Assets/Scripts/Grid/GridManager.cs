using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GridManager : MonoBehaviour
{
    /// <summary>
    /// 格子列表
    /// </summary>
    private List<Grid> gridList = new List<Grid>();
    
    /// <summary>
    /// 格子父对象
    /// </summary>
    [SerializeField]
    private Transform gridParent;
    
    /// <summary>
    /// 格子类型图片
    /// </summary>
    [SerializeField]
    private Sprite[] gridSpriteArray;
    
    /// <summary>
    /// 格子图片
    /// </summary>
    [SerializeField]
    private Sprite gridSprite;
    
    /// <summary>
    /// 格子移动
    /// </summary>
    private void GridMove()
    {
        
    }

    /// <summary>
    /// 格子生成
    /// </summary>
    private void GridGenerate(int[,] gridArray)
    {
        int index = 0;
        for (var i = 0; i < gridArray.GetLength(0); i++)
        {
            for (var j = 0; j < gridArray.GetLength(1); j++)
            {
                index++;
                var grid = new Grid();
                grid.GridData.Index = index;
                grid.GridData.GridType = (GridType)Random.Range(0, 4);
                grid.GridData.X = i;
                grid.GridData.Y = j;
                grid.GridGameObject = Generate(gridSprite, new Vector3(i, j), gridParent,
                    grid.GridData.GridType.ToString(), 0);
                grid.GridTypeGameObject = Generate(gridSpriteArray[(int)grid.GridData.GridType], new Vector3(i, j),
                    grid.GridGameObject.transform, grid.GridData.GridType.ToString(), 1);
            }
        }
    }

    /// <summary>
    /// 生成格子
    /// </summary>
    /// <param name="sprite"></param>
    /// <param name="pos"></param>
    /// <param name="parent"></param>
    /// <param name="gridName"></param>
    /// <param name="layer"></param>
    /// <returns></returns>
    private GameObject Generate(Sprite sprite, Vector3 pos, Transform parent, string gridName, int layer)
    {
        var gridGameObject = new GameObject();
        var spriteRenderer = gridGameObject.AddComponent<SpriteRenderer>();
        gridGameObject.transform.parent = parent;
        spriteRenderer.sortingOrder = layer;
        spriteRenderer.sprite = sprite;
        gridGameObject.transform.position = pos;
        gridGameObject.name = gridName;
        return gridGameObject;
    }

    private void Start()
    {
        GridGenerate(new int[10, 10]);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) 
        {
            
        }
    }
}
