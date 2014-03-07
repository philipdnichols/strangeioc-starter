using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using strange.extensions.signal.impl;

namespace com.opg.colorfling.game {
	public class GameDebugView : View {
		[Inject]
		public IScreenUtil screenUtil { get; set; }

		internal Signal startGameSignal = new Signal();
		internal Signal startLevelSignal = new Signal();

		protected void OnGUI() {

		}
	}
}