using UnityEngine;
using System.Collections;
using strange.extensions.signal.impl;

namespace com.opg.colorfling.game {
	// Game
	public class GameStartedSignal : Signal {}

	// Level
	public class SetupLevelSignal : Signal {}
	public class LevelStartedSignal : Signal {}
}