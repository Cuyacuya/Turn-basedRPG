using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager
{
    public HashSet<Player> Player { get; } = new HashSet<Player>();
    public HashSet<Monster> Monster { get; } = new HashSet<Monster>();

    #region Roots
    public Transform GetRootTransform(string name)
    {
        GameObject root = GameObject.Find(name);
        if (root == null)
            root = new GameObject() { name = name };

        return root.transform;
    }

    public Transform PlayerRoot { get { return GetRootTransform("@Players"); } }
    public Transform MonsterRoot { get { return GetRootTransform("@Monsters"); } }
    #endregion

    // TODO
    // ������Ʈ ����
    // ����
}