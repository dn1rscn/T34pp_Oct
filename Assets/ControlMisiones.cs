using UnityEngine;
using System.Collections;

public class ControlMisiones : MonoBehaviour 
{
	public bool[] ejerB_3estrellas;
	public bool[] ejerF_3estrellas;
	public bool[] ejerM_3estrellas;

	int i;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void Mision_Dino()
	{
		i = 0;

		while (i<=ejerB_3estrellas-1 && ejerB_3estrellas[i]==true) 
		{
			if(i==ejerB_3estrellas.Length-1)
			{
				//desbloqueamos isla
				print("Mision completada");
			}
			
			i++;
			
		}
		if (i<ejerB_3estrellas.Length && ejerB_3estrellas [i] == false) 
		{
			print("Ejercicio "+i+" no completado FULL");
		}
	}

}
