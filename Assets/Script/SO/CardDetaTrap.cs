using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "MyScriptable/Create CardDeta/Trap")]
public class CardDetaTrap : ScriptableObject
{
    public string Name;
    public int Volume;
    public int Cost;
    public bool Dragon;
    public bool Fanfale;
    public bool Dangerous;
    public string Others;

    public virtual void Text()
    {
        //実行内容
    }
}
