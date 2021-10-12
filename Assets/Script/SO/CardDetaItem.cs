using UnityEngine;

[CreateAssetMenu(menuName = "MyScriptable/Create CardDeta/Item")]
public class CardDetaItem : ScriptableObject
{
	public string Name;
	public int Volume;
	public int Cost;
	public bool Buddy;
	public bool Dragon;
	public bool Jewelry;
	public int Skill;
	public int Boots;
	public int Sword;
	public int Clank;
	public int Point;
	public int Life;
	public int GetSword;
	public int GetBoots;
	public string Others;

	public virtual void Text()
	{
		//実行内容
	}
}