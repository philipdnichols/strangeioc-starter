using strange.extensions.signal.impl;

namespace com.opg.colorfling.common {
	public class StartSignal : Signal {}

	// Input
	public class GameInputSignal : Signal<GameInputEvent> {}
		
	// Screen
	public class GameScreenSignal : Signal<GameScreenEvent> {}
	public class GameScreenSizeChangedSignal : Signal {}

	// Game
	public class GameStartSignal : Signal {}
	public class GameEndSignal : Signal {}
	public class LevelStartSignal : Signal {}
	public class LevelEndSignal : Signal {}
}