using UnityEngine;
using System.Collections;
using strange.extensions.context.impl;

namespace com.opg.colorfling.game {
	public class GameBootstrap : ContextView {
		void Start() {
			context = new GameContext(this);
		}
	}
}