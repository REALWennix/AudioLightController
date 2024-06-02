using System;
using System.Collections.Generic;

namespace LightController.Commands
{
    public enum CommandPrefix
    {
        EXEC_ALL,
        ADD_ID,
        CLEAR,
        SET_EFFECT_ON_ALL,
        BRIGHTNESS_ALL,
        CLEAR_ALL,
        ON,
        OFF,
        SET_DURATION_ALL,
        RESET_DURATION_ALL
    }

    public class SerialCommand
    {
        public CommandPrefix Prefix { get; }
        public List<object> Parameters { get; }

        public SerialCommand(CommandPrefix prefix, params object[] parameters)
        {
            if (!Enum.IsDefined(typeof(CommandPrefix), prefix))
            {
                throw new ArgumentException("Invalid command prefix.", nameof(prefix));
            }

            Prefix = prefix;
            Parameters = new List<object>(parameters);
        }

        public override string ToString()
        {
            string commandString = "";

            switch (Prefix)
            {
                case CommandPrefix.EXEC_ALL:
                    commandString = "<EXA>";
                    break;
                case CommandPrefix.ADD_ID:
                    if (Parameters.Count > 0 && Parameters[0] is int pinID)
                    {
                        commandString = "<AD" + pinID.ToString() + ">";
                    }
                    break;
                case CommandPrefix.SET_EFFECT_ON_ALL:
                    // Example: <EF1> sets effect to EffectType::BLINK for all fixtures
                    if (Parameters.Count > 0 && Parameters[0] is int effectInt)
                    {
                        commandString = "<EF" + effectInt.ToString() + ">";
                    }
                    break;
                case CommandPrefix.BRIGHTNESS_ALL:
                    // Example: <BRT50> sets brightness to 50 for all fixtures
                    if (Parameters.Count > 0 && Parameters[0] is int brightness)
                    {
                        commandString = "<BRT" + brightness.ToString() + ">";
                    }
                    break;
                case CommandPrefix.CLEAR_ALL:
                    commandString = "<CL>";
                    break;
                case CommandPrefix.ON:
                    commandString = "<ONL>";
                    break;
                case CommandPrefix.OFF:
                    commandString = "<OFFL>";
                    break;
                case CommandPrefix.SET_DURATION_ALL:
                    // Example: <DUR500> sets duration to 500ms for all fixtures
                    if (Parameters.Count > 0 && Parameters[0] is int duration)
                    {
                        commandString = "<DUR" + duration.ToString() + ">";
                    }
                    break;
                case CommandPrefix.RESET_DURATION_ALL:
                    commandString = "<RDUR>";
                    break;
                default:
                    // Unknown prefix
                    throw new InvalidOperationException("Unknown command prefix.");
            }

            return commandString+"\n";
        }

    }
}
