using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Scriptable Objects/Item")]
public class Item : ScriptableObject
{
    [SerializeField] protected string itemName;
    [SerializeField] protected double weight;
    [SerializeField] protected int price;
    [SerializeField] protected Sprite sprite;

    public virtual string GetDescription()
    {
        return $"{itemName}, {weight} stone, {price} coins";
    }
    
    public string GetName()
    {
        return itemName;
    }

    public double GetWeight()
    {
        return weight;
    }

    public int GetPrice()
    {
        return price;
    }

    public Sprite GetSprite()
    {
        return sprite;
    }
}



