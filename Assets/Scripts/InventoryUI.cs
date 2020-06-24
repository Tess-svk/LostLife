using System.Diagnostics.SymbolStore;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
	public GameObject inventory;

	void Start ()
	{

	}
	
	void Update () 
	{
		if (Input.GetKey(KeyCode.Tab))
		{
//			active/deactive		
//			bool invActive = inventory.activeSelf;
//			
//			inventory.gameObject.SetActive(!invActive);
			inventory.gameObject.SetActive(true);
		}
	}
}
