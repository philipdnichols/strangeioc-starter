using UnityEngine;
using System.Collections;

namespace com.opg.colorfling.common {
	public abstract class AbstractInput : IInput {
		[Inject]
		public IRoutineRunner routineRunner { get; set; }
		
		[Inject]
		public GameInputSignal gameInputSignal { get; set; }
		
		[PostConstruct]
		public void PostConstruct() {
			routineRunner.StartCoroutine(Update());
		}
		
		protected IEnumerator Update() {
			while (true) {
				// Process Game Input
				GameInputEvent input = ProcessGameInput();

				if (input != GameInputEvent.Null) {
					gameInputSignal.Dispatch(input);
				}
				
				yield return null;
			}
		}

		protected abstract GameInputEvent ProcessGameInput();
	}
}