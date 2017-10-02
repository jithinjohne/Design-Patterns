namespace Command
{
    public class LightRemoteController : RemoteController
    {
        private LightRemoteController(ICommand upArrowCommand, ICommand downArrowCommand, ICommand rightArrowCommand, ICommand leftArrowCommand)
            : base(upArrowCommand, downArrowCommand, rightArrowCommand, leftArrowCommand)
        {
        }

        public LightRemoteController()
            : this(new IncreaseBrightness(), new DecreaseBrightness(), new LightOn(), new LightOff())
        {
        }
    }
}