using strange.extensions.signal.impl;

namespace com.opg.colorfling {
	public class StartSignal : Signal {}

	// Input
	public class GameInputSignal : Signal<GameInputEvent> {}

	// Game
	public class GameStartSignal : Signal {}
	public class GameEndSignal : Signal {}
	public class LevelStartSignal : Signal {}
	public class LevelEndSignal : Signal {}
}