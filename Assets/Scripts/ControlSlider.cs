using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControlSlider : MonoBehaviour 
{
	public Slider BarraProgreso;

	public GameObject[] estrellas;
	public Sprite estrellaactiva;

	ControlDatosGlobales_PICTOGRAMAS cdg;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void ProgresoDado()
	{
		cdg = GameObject.Find ("DatosGlobales").GetComponent<ControlDatosGlobales_PICTOGRAMAS> ();


		//while (BarraProgreso.value<cdg.aciertos) 
		//{
		BarraProgreso.value = cdg.aciertos; //(Valor += Time.deltaTime);
		if (BarraProgreso.value == 5) 
		{
			estrellas[0].GetComponent<Image>().sprite=estrellaactiva;
		}
		if (BarraProgreso.value == 10) 
		{
			estrellas[1].GetComponent<Image>().sprite=estrellaactiva;
			estrellas[2].GetComponent<Image>().sprite=estrellaactiva;
		}
		if (BarraProgreso.value == 15) 
		{
			estrellas[3].GetComponent<Image>().sprite=estrellaactiva;
			estrellas[4].GetComponent<Image>().sprite=estrellaactiva;
			estrellas[5].GetComponent<Image>().sprite=estrellaactiva;
		}

		//}
	}
}
