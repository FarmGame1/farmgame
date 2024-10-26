using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySystem : MonoBehaviour
{
    public GameObject inventoryUI; // Envanter aray�z� i�in GameObject referans�
    public List<string> items = new List<string>(); // Envanterdeki e�yalar� tutacak liste
    public GameObject inventorySlotPrefab; // Envanter slotlar� i�in prefab referans�
    public Transform inventoryGrid; // Envanterdeki grid layout i�in referans
    public int gridRows = 4; // Grid sat�r say�s�
    public int gridColumns = 4; // Grid s�tun say�s�

    private bool isInventoryOpen = false;

    void Start()
    {
        inventoryUI.SetActive(false); // Envanteri ba�lang��ta kapal� tut
        InitializeInventoryGrid(); // Envanter gridini olu�tur
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I)) // 'I' tu�una basarak envanteri a��p kapat
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
        // Burada envanter aray�z�n� g�ncellemek i�in kod ekleyebilirsin.
        // �rne�in, her e�ya i�in bir UI ��esi olu�turabilirsin.
        Debug.Log("Envanterdeki e�yalar: " + string.Join(", ", items));
    }

    private void InitializeInventoryGrid()
    {
        // Envanterde grid yap�s�n� olu�tur
        for (int i = 0; i < gridRows * gridColumns; i++)
        {
            GameObject slot = Instantiate(inventorySlotPrefab, inventoryGrid);
            slot.name = "Slot " + (i + 1);
        }
    }
}
