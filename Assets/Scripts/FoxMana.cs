using UnityEngine;
using UnityEngine.UI;

public class FoxMana : MonoBehaviour {

	public float CurrentTime {get; set;}
	public float TotalTime {get; set;}

	public Slider manaBar;

	void Start()
	{
		TotalTime = 100f;
		CurrentTime = TotalTime;

		manaBar.value = CalculateMana();
	}

	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.X))
		{
			TakeMana(20);
		}

		CurrentTime += (Time.deltaTime*5);
		manaBar.value = CalculateMana();
	}

	void TakeMana(float manaTkn)
	{
		CurrentTime -= manaTkn;
		
		if (CurrentTime <= 0)
		{
			Restart();
		}
	}

	float CalculateMana()
	{
		return CurrentTime / TotalTime;
	}
	
	void Restart()
	{
		CurrentTime = 0;
		Debug.Log("Out of mana.");
	}
}
