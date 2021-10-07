using UnityEngine;

[CreateAssetMenu(menuName = "MyScriptable/Create CardDeta/Enemy")]
public class CardDetaEnemy : ScriptableObject
{
	public string Name;
	public int Volume;
	public int NecessarySword;
	public bool Dragon;
	public bool Deep;
	public bool Ice;
	public int GetSkill;
	public int GetGold;
	public int GetCard;
	public int GetBoots;
	public string Others;
	public virtual void Text()
	{
		//実行内容
	}
}
