using CommandPattern.Commands;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var remote = new SimpleRemoteControl();
            var light = new Light();

            var lightOnCommand = new LightOnCommand(light);

            remote.SetCommand(lightOnCommand);
            remote.ButtonWasPressed();
        }
    }
}
