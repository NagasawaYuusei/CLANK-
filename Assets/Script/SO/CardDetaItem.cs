using UnityEngine;

[CreateAssetMenu(menuName = "MyScriptable/Create CardDeta/Item")]
public class CardDetaItem : ScriptableObject
{
	public string Name;
	public int Volume;

	public virtual void Text()
	{
		//実行内容
	}
}