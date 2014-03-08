using UnityEngine;
using System.Collections;

namespace com.opg.colorfling.common {
	[Implements(typeof(IScreenUtil))]
	public class ScreenUtil : IScreenUtil {
		[Inject]
		public IRoutineRunner routineRunner { get; set; }

		[Inject]
		public GameScreenSignal gameScreenSignal { get; set; }

		int previousScreenWidth = int.MinValue;
		int previousScreenHeight = int.MinValue;

		[PostConstruct]
		public void PostConstruct() {
			routineRunner.StartCoroutine(Update());
		}

		protected IEnumerator Update() {
			while (true) {
				if (previousScreenWidth != Screen.width || 
				    previousScreenHeight != Screen.height) {
					gameScreenSignal.Dispatch(GameScreenEvent.ScreenSizeChanged);
				}

				previousScreenWidth = Screen.width;
				previousScreenHeight = Screen.height;

				yield return null;
			}
		}
	}
}