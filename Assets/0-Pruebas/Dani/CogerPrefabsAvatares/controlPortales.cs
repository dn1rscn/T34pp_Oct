using UnityEngine;
using System.Collections;

public class controlPortales : MonoBehaviour {

	Animator animator_PanelCanvas;
	Animator animator_botonesPortal;

	string destinoPortal;

	ControlDatosGlobales_Mundo3D CDG_Mundo3D;

	// Use this for initialization
	void Start ()
	{
		//ACCEDEMOS AL SCRIPT DE DATOS GLOBALES
		//CDG_Mundo3D = GameObject.Find("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D>();

		animator_PanelCanvas = GameObject.Find ("CanvasPortal_Verde").GetComponent<Animator> ();
		animator_botonesPortal = GameObject.Find("botonesPortal").GetComponent<Animator>();
	}
	
	void OnTriggerEnter(Collider coli)
	{
		if (coli.gameObject.tag == "Portal")
		{
			//Ejecutamos la animacion del canvas al entrar en algun portal
 			animator_PanelCanvas.Play("CanvasPortal_animIntro");
			animator_botonesPortal.Play("IntroBotonesPortales");

			print ("Colision con: "+coli.gameObject.name);
			if(coli.gameObject.name=="trigger_EjercicioPictogramas")
			{
				//CDG_Mundo3D.posicionPersonaje = 2;
				destinoPortal= "ejercicioDado";
				print(destinoPortal);

			}
			else if(coli.gameObject.name=="trigger_EjercicioSonidos")
			{
				//CDG_Mundo3D.posicionPersonaje = 2;
				destinoPortal= "ejercicioSonidos";
				print(destinoPortal);

				//animator_PanelCanvas.Play("pasarABlanco");
				//Invoke("cargarPictogramas2",100*Time.deltaTime);
			}
			else if(coli.gameObject.name=="trigger_IslaFantasma")
			{
				//CDG_Mundo3D.posicionPersonaje = 2;
				destinoPortal= "islaFantasma";
				print(destinoPortal);
				
				//animator_PanelCanvas.Play("pasarABlanco");
				//Invoke("cargarPictogramas2",100*Time.deltaTime);
			}


		}
	}

	void OnTriggerExit(Collider coli)
	{
		if (coli.gameObject.tag == "Portal")
		{
			//Ejecutamos la animacion de salida canvas al salir del portal
			animator_PanelCanvas.Play("CanvasPortal_animSalida");
			animator_botonesPortal.Play("SalidaBotonesPortales");
		}
	}


	public void usarPortal(){
		switch (destinoPortal)
		{
		case "ejercicioDado":
			Application.LoadLevel("Dado_SeleccionNivel");
			break;
		case "ejercicioSonidos":
			Application.LoadLevel("Sonidos_menu_Seleccion");
			print ("Cargando ejercicio sonidos...");
			break;
		case "islaFantasma":
			Application.LoadLevel("Isla_fantasma");
			print ("Cargando islaFantasma...");
			break;

		}
	}

}
