using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;

public class DropSheetScript : MonoBehaviour
{

    [Header("Chest Type")]
    [SerializeField]
    string[] namesForChestType;
    [SerializeField]
    int[] weightsForChestType;

    [Header("Wooden Chest")]
    [SerializeField]
    string[] namesForWoodenChest;
    [SerializeField]
    int[] weightsForWoodenChest;

    [Header("Bronze Chest")]
    [SerializeField]
    string[] namesForBronzeChest;
    [SerializeField]
    int[] weightsForBronzeChest;

    [Header("Silver Chest")]
    [SerializeField]
    string[] namesForSilverChest;
    [SerializeField]
    int[] weightsForSilverChest;

    [Header("Golden Chest")]
    [SerializeField]
    string[] namesForGoldenChest;
    [SerializeField]
    int[] weightsForGoldenChest;

    [Header("Mythical Chest")]
    [SerializeField]
    string[] namesForMythicalChest;
    [SerializeField]
    int[] weightsForMythicalChest;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Random.Range(1, 6);
        }
    }

    string GetRarity(string[] names, int[] ranges)
    {

    }

}
