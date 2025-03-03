using SlotcarRennenM320.Enums;

namespace SlotcarRennenM320.DataClasses
{
    public class TrackNode
    {
        public Orientation IngoingOrientation { get; set; }
        public Orientation OutgoingOrientation { get; set; }

        // Helper property to check if this is an active track piece
        public bool IsActive => IngoingOrientation != Orientation.None || OutgoingOrientation != Orientation.None;
    }
}
