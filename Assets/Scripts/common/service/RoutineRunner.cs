using UnityEngine;
using System.Collections;
using strange.extensions.context.api;
using strange.extensions.injector.api;

namespace com.opg.colorfling.common {
	[Implements(typeof(IRoutineRunner), InjectionBindingScope.CROSS_CONTEXT)]
	public class RoutineRunner : IRoutineRunner {
		[Inject(ContextKeys.CONTEXT_VIEW)]
		public GameObject contextView { get; set; }

		private RoutineRunnerBehavior routineRunnerBehavior;

		[PostConstruct]
		public void PostConstruct() {
			routineRunnerBehavior = contextView.AddComponent<RoutineRunnerBehavior>();
		}

		public Coroutine StartCoroutine(IEnumerator routine) {
			return routineRunnerBehavior.StartCoroutine(routine);
		}
	}

	public class RoutineRunnerBehavior : MonoBehaviour {}
}