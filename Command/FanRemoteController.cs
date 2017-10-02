namespace Command
{
    public class FanRemoteController : RemoteController
    {
        private FanRemoteController(ICommand upArrowCommand, ICommand downArrowCommand, ICommand rightArrowCommand, ICommand leftArrowCommand) 
            : base(upArrowCommand, downArrowCommand, rightArrowCommand, leftArrowCommand)
        {
        }

        public FanRemoteController()
            : this(new IncreaseFanSpeed(), new DecreaseFanSpeed(), new FanOn(), new FanOff())
        {
        }
    }
}