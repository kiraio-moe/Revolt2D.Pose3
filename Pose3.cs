namespace Revolt2D.Pose.Json
{
    public class Pose3
    {
        public string Type;
        public List<List<Group>> Groups;

        public override string ToString()
        {
            string groupsString = string.Join(
                "\n",
                Groups.Select(
                    (groupList, i) =>
                        $"  Group[{i}]:\n"
                        + string.Join(
                            "\n",
                            groupList.Select((group, gi) => $"    Group[{gi}]:\n{group}")
                        )
                )
            );
            return $"Type: {Type}\nGroups:\n{groupsString}";
        }
    }
}
