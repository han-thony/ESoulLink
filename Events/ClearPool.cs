using HkmpPouch;

namespace ESoulLink.Events
{
    public class ClearPoolsEvent : PipeEvent
    {
        internal static char[] separator = new char[] { '|' };

        internal static string Name = "ClearPools";

        public override string GetName()
        {
            return Name;
        }

        public override string ToString()
        {
            return Name;
        }

    }
    public class ClearPoolsEventFactory : IEventFactory
    {
        public static ClearPoolsEventFactory Instance = new ClearPoolsEventFactory();
        public string GetName()
        {
            return ClearPoolsEvent.Name;
        }

        public PipeEvent FromSerializedString(string serializedData)
        {
            var Event = new ClearPoolsEvent();
            return Event;
        }
    }
}
