namespace Command
{
    public abstract class RemoteController
    {
        private readonly ICommand upArrowCommand;
        private readonly ICommand downArrowCommand;
        private readonly ICommand rightArrowCommand;
        private readonly ICommand leftArrowCommand;

        protected RemoteController(ICommand upArrowCommand, ICommand downArrowCommand, ICommand rightArrowCommand, ICommand leftArrowCommand)
        {
            this.upArrowCommand = upArrowCommand;
            this.downArrowCommand = downArrowCommand;
            this.rightArrowCommand = rightArrowCommand;
            this.leftArrowCommand = leftArrowCommand;
        }

        public void PressUpArrow()
        {
            upArrowCommand.Execute();
        }

        public void PressDownArrow()
        {
            downArrowCommand.Execute();
        }

        public void PressLeftArrow()
        {
            leftArrowCommand.Execute();
        }

        public void PressRightArrow()
        {
            rightArrowCommand.Execute();
        }
    }
}