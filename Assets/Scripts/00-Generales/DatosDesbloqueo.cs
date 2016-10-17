using UnityEngine;
using System.Collections;

public class DatosDesbloqueo : MonoBehaviour 
{
	public static DatosDesbloqueo cont;

	public int Posicion;

	public bool Nivel2Dado=false;

	public bool Nivel2Sonidos=false;
	public bool Nivel3Sonidos=false;

	public bool[] ADado;
	public bool[] ASonidos;

	// Use this for initialization
	void Start () 
	{
		DontDestroyOnLoad (this);
	}
	
	// Update is called once per frame
	void Update () {
	
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
