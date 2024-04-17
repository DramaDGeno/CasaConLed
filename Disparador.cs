using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO.Ports;

public class Disparador : MonoBehaviour
{
	SerialPort serialPort = new SerialPort("/dev/cu.usbmodem14601", 9600); // Puerto serial para comunicarse con Arduino

	void Start()
	{
		serialPort.Open();
		serialPort.ReadTimeout = 100;
	}

	// Método que se llama cuando algo entra en el trigger
	private void OnTriggerEnter(Collider other)
    {
		if (other.CompareTag("Player"))
		{
			// Acción a realizar cuando el trigger se activa
			if (serialPort.IsOpen)
			{
				serialPort.Write("2"); // Envía '1' al Arduino para encender el LED cuando el trigger se active
			}
		}
	}
}