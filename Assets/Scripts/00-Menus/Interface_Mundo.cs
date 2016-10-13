using UnityEngine;
using System.Collections;

public class Interface_Mundo : MonoBehaviour 
{
	control_datosGlobalesPersonalizacion cdgP;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Mapa()
	{
		Application.LoadLevel ("Mapa");
	}
	public void PersonalizacionJuego()
	{
		cdgP = GameObject.Find ("datosGlobalesPersonalizacion").GetComponent<control_datosGlobalesPersonalizacion> ();
		print ("hola");
		cdgP.inicio = false;
		Application.LoadLevel ("personalizacion2.0");
	}
}
