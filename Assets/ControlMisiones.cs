﻿using UnityEngine;
using System.Collections;

public class ControlMisiones : MonoBehaviour 
{
	public static ControlMisiones cont;

	public bool dado1;
	public bool dado2;

	public bool[] ejerB_3estrellas;
	public bool[] ejerF_3estrellas;
	public bool[] ejerM_3estrellas;

	int i;

	// Use this for initialization
	void Start () 
	{
		DontDestroyOnLoad (this);
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void Mision_Dino()
	{
		i = 0;

		while (i<=ejerB_3estrellas.Length-1 && ejerB_3estrellas[i]==true) 
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
	void Awake ()
	{
		
		if (cont == null) {
			cont = this;
			DontDestroyOnLoad (gameObject);
		} else if (cont != this) {
			Destroy(gameObject);
		}
	}
}
