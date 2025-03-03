using SlotcarRennenM320.DataClasses;
using SlotcarRennenM320.Enums;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace SlotcarRennenM320.Services
{
    public class TrackLoader
    {
        public static ObservableCollection<ObservableCollection<TrackNode>> LoadTrack(string path)
        {
            var track = new ObservableCollection<ObservableCollection<TrackNode>>();

            try
            {
                XDocument doc = XDocument.Load(path);
                var rows = doc.Root?.Element("Rows")?.Elements("Row");

                if (rows != null)
                {
                    foreach (var row in rows)
                    {
                        var trackRow = new ObservableCollection<TrackNode>();

                        foreach (var node in row.Elements("Node"))
                        {
                            var ingoing = Enum.Parse<Orientation>(
                                node.Attribute("IngoingOrientation")?.Value ?? "None");
                            var outgoing = Enum.Parse<Orientation>(
                                node.Attribute("OutgoingOrientation")?.Value ?? "None");

                            trackRow.Add(new TrackNode
                            {
                                IngoingOrientation = ingoing,
                                OutgoingOrientation = outgoing
                            });
                        }

                        track.Add(trackRow);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading track: {ex.Message}");
                return CreateEmptyTrack();
            }

            return track;
        }

        private static ObservableCollection<ObservableCollection<TrackNode>> CreateEmptyTrack()
        {
            var track = new ObservableCollection<ObservableCollection<TrackNode>>();

            for (int i = 0; i < 15; i++)
            {
                var row = new ObservableCollection<TrackNode>();
                for (int j = 0; j < 10; j++)
                {
                    row.Add(new TrackNode());
                }
                track.Add(row);
            }

            return track;
        }
    }
}