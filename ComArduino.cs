using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO.Ports;

public class ComArduino : MonoBehaviour
{
    public Button button1; // Variable para el primer botón
    public Button button2; // Variable para el segundo botón
    public Button button3; // Variable para el tercer botón

    SerialPort serialPort = new SerialPort("/dev/cu.usbmodem14601", 9600); // Puerto serial para comunicarse con Arduino

    void Start()
    {
        serialPort.Open();
        serialPort.ReadTimeout = 100;

        // Asignar funciones a los botones
        button1.onClick.AddListener(OnButton1Click);
        button2.onClick.AddListener(OnButton2Click);
        button3.onClick.AddListener(OnButton3Click);
    }

    public void OnButton1Click()
    {
        // Acción a realizar cuando se hace clic en el primer botón
        if (serialPort.IsOpen)
        {
            serialPort.Write("1"); // Envía '1' al Arduino para encender el LED 1
        }
    }

    public void OnButton2Click()
    {
        // Acción a realizar cuando se hace clic en el segundo botón
        if (serialPort.IsOpen)
        {
            serialPort.Write("2"); // Envía '2' al Arduino para encender el LED 2
        }
    }

    public void OnButton3Click()
    {
        // Acción a realizar cuando se hace clic en el tercer botón
        if (serialPort.IsOpen)
        {
            serialPort.Write("3"); // Envía '3' al Arduino para encender el LED 3
        }
    }
}
