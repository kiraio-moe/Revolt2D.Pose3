namespace Revolt2D.Pose.Json
{
    public class Group
    {
        public string Id;
        public List<string>? Link = new List<string>();

        public override string ToString()
        {
            string linkString = string.Join(
                "\n",
                Link.Select((l, i) => $"        Link[{i}]:\n{l}")
            );
            return $"      Id: {Id}\n      Link:\n{linkString}";
        }
    }
}
