﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeM : MonoBehaviour
{
    Transform[] trees;
    public int Length;
    // Start is called before the first frame update
    void Start()
    {
        trees = gameObject.GetComponentsInChildren<Transform>();
        Length = trees.Length;
        Set_Num();
    }

    // Update is called once per frame
    void Update()
    {
        Destroy_tree();
    }
    public void Destroy_tree() //오브젝트 파괴 시 번호를 서버에 넘겨줌
    {
        if (Singleton.instance.pTree.status == 1)
        {
            DIE_M des_num = trees[Singleton.instance.pTree.number].GetComponent<DIE_M>();
            Destroy(des_num.gameObject);
            Singleton.instance.Reset_Tree();
        }

    }
    public void Set_Num() // 오브젝트 번호 설정
    {
        for (int i = 0; i < trees.Length; i++)
        {
            DIE_M num = trees[i].GetComponent<DIE_M>();
            if (num != null)
            {
                num.Num = i;
            }
        }
    }
}
