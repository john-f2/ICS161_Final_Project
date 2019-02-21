using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryButtonScript : MonoBehaviour
{
    public GameObject inventoryPanel;
    private bool inventoryOpen = false;
    private Image button_image;

    [SerializeField] protected Sprite closed_bag;
    [SerializeField] protected Sprite open_bag;

    void Awake()
    {
        button_image = this.GetComponent<Image>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnInventoryButtonClick()
    {
        inventoryOpen = !inventoryOpen;
        if (inventoryOpen)
        {
            button_image.sprite = open_bag;
            inventoryPanel.SetActive(true);
        }
        else
        {
            button_image.sprite = closed_bag;
            inventoryPanel.SetActive(false);
        }
    }
}
