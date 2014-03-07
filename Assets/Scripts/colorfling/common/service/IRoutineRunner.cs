using UnityEngine;
using System.Collections;

namespace com.opg.colorfling {
	public interface IRoutineRunner {
		Coroutine StartCoroutine(IEnumerator method);
	}
}