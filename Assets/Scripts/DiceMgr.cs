using UnityEngine;
using System.Collections;

public class DiceMgr : MonoBehaviour {

	private static DiceMgr _instance;

	public static DiceMgr instance
	{
		get
		{
			if(_instance == null)
				_instance = GameObject.FindObjectOfType<DiceMgr>();
			return _instance;
		}
	}


	public int Roll2D6() {
		//ANTHONY TODO
	}
}
