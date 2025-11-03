using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;

public class DropSheetScript : MonoBehaviour
{
    [Header("Chest Types")]
    [SerializeField] private WeightedItem[] chestTypes;

    [Header("Wooden Chest Items")]
    [SerializeField] private WeightedItem[] woodenItems;

    [Header("Bronze Chest Items")]
    [SerializeField] private WeightedItem[] bronzeItems;

    [Header("Silver Chest Items")]
    [SerializeField] private WeightedItem[] silverItems;

    [Header("Golden Chest Items")]
    [SerializeField] private WeightedItem[] goldenItems;

    [Header("Mythical Chest Items")]
    [SerializeField] private WeightedItem[] mythicalItems;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            WeightedItem chest = GetRandomItem(chestTypes);
            Debug.Log($"Chest Dropped: {chest.name}");

            WeightedItem item = GetItemFromChest(chest.name);
            Debug.Log($"Item from {chest.name}: Rarity {item.name}");
        }
    }

    WeightedItem GetItemFromChest(string chestName)
    {
        switch (chestName.ToLower())
        {
            case "wooden": return GetRandomItem(woodenItems);
            case "bronze": return GetRandomItem(bronzeItems);
            case "silver": return GetRandomItem(silverItems);
            case "golden": return GetRandomItem(goldenItems);
            case "mythical": return GetRandomItem(mythicalItems);
            default: return new WeightedItem { name = "Unknown", weight = 0 };
        }
    }

    WeightedItem GetRandomItem(WeightedItem[] items)
    {
        int totalWeight = 0;
        foreach (var item in items)
            totalWeight += item.weight;

        int randomValue = Random.Range(0, totalWeight);
        int cumulative = 0;

        foreach (var item in items)
        {
            cumulative += item.weight;
            if (randomValue < cumulative)
                return item;
        }

        return items[items.Length - 1]; // fallback
    }

}

[System.Serializable]
public class WeightedItem
{
    public string name;
    public int weight;
}

