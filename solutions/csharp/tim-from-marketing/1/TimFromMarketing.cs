static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string isOwner = department ?? "owner";
        string newId = id == null ? "" : $"[{id}] - ";

        return $"{newId}{name} - {isOwner.ToUpper()}";
    }
}
