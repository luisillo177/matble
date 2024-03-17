using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class volver : MonoBehaviour
{
    public string nombreDeEscena; // Nombre de la escena a la que deseas regresar
    public KeyCode teclaParaVolver = KeyCode.Escape; // Tecla que activará el regreso a la escena

    // Update is called once per frame
    void Update()
    {
        // Verificar si la tecla especificada ha sido presionada
        if (Input.GetKeyDown(teclaParaVolver))
        {
            // Llamar a la función para cargar la escena
            CargarEscena();
        }
    }

    void CargarEscena()
    {
        // Cargar la escena por su nombre
        SceneManager.LoadScene(nombreDeEscena);
    }
}