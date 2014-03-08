using UnityEngine;
using System.Collections;

namespace com.opg.colorfling.common {
	public interface IRoutineRunner {
		Coroutine StartCoroutine(IEnumerator method);
	}
}