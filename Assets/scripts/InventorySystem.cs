using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySystem : MonoBehaviour
{
    public GameObject inventoryUI; // Envanter arayüzü için GameObject referansý
    public List<string> items = new List<string>(); // Envanterdeki eþyalarý tutacak liste
    public GameObject inventorySlotPrefab; // Envanter slotlarý için prefab referansý
    public Transform inventoryGrid; // Envanterdeki grid layout için referans
    public int gridRows = 4; // Grid satýr sayýsý
    public int gridColumns = 4; // Grid sütun sayýsý

    private bool isInventoryOpen = false;

    void Start()
    {
        inventoryUI.SetActive(false); // Envanteri baþlangýçta kapalý tut
        InitializeInventoryGrid(); // Envanter gridini oluþtur
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I)) // 'I' tuþuna basarak envanteri açýp kapat
        {
            ToggleInventory();
        }
    }

    public void ToggleInventory()
    {
        isInventoryOpen = !isInventoryOpen;
        inventoryUI.SetActive(isInventoryOpen);
    }

    public void AddItem(string itemName)
    {
        items.Add(itemName);
        UpdateInventoryUI();
    }

    private void UpdateInventoryUI()
    {
        // Burada envanter arayüzünü güncellemek için kod ekleyebilirsin.
        // Örneðin, her eþya için bir UI öðesi oluþturabilirsin.
        Debug.Log("Envanterdeki eþyalar: " + string.Join(", ", items));
    }

    private void InitializeInventoryGrid()
    {
        // Envanterde grid yapýsýný oluþtur
        for (int i = 0; i < gridRows * gridColumns; i++)
        {
            GameObject slot = Instantiate(inventorySlotPrefab, inventoryGrid);
            slot.name = "Slot " + (i + 1);
        }
    }
}
