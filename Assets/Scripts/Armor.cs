using UnityEngine;

[CreateAssetMenu(fileName = "Armor", menuName = "Scriptable Objects/Armor")]
public class Armor: Item
{
    [SerializeField] private int defense;

    public override string GetDescription()
    {
        return $"{base.GetDescription()}, Defense: +{defense}";
    }

    public int GetDefense()
    {
        return defense;
    }
}