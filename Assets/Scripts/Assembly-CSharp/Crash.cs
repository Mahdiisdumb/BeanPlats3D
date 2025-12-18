using System.Runtime.InteropServices;
using UnityEngine;

public class Crash : MonoBehaviour
{
	[DllImport("msvcrt.dll")]
	public static extern int memset(int dest, int c, int count);

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			Debug.LogError("Player touched the object. Crashing the game now...");
			memset(0, 0, 10);
		}
	}
}
